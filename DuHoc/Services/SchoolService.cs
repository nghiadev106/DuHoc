using DuHoc.Models;
using DuHoc.ViewModels.School;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DuHoc.Services
{
    public interface ISchoolService
    {
        Task<PaginationViewModel> Pagination(Dictionary<string, object> data);

        Task<List<SchoolViewModel>> GetAll();

        Task<int> Create(SchoolCreateRequest request);

        Task<SchoolViewModel> Detail(int id);

        Task<SchoolUpdateRequest> Edit(int id);

        Task<int> Update(SchoolUpdateRequest request);

        Task<int> IncreaseView(int id);

        Task<int> Delete(int id);
    }
    public class SchoolService : ISchoolService
    {
        private readonly DuHocContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "uploads";

        public SchoolService(DuHocContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<List<SchoolViewModel>> GetAll()
        {
            return await _context.School.Select(p => new SchoolViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
                CategoryName = p.Category.Name,
                Description = p.Description,
                Detail = p.Detail,
                SortDescription=p.SortDescription,
                IsNew = p.IsNew,
                Url = p.Url,
                Status = p.Status,
                CreateDate = p.CreateDate,
                AddressId = p.AddressId,
                AddressDetail = p.AddressDetail,
                ViewCount=p.ViewCount,
                RankId=p.RankId,
            }).OrderByDescending(x => x.CreateDate).ToListAsync();
        }

        public async Task<PaginationViewModel> Pagination(Dictionary<string, object> data)
        {
            PaginationViewModel paginationViewModel = new PaginationViewModel();
            try
            {
                int page = int.Parse(data["page"].ToString());
                int pageSize = int.Parse(data["pageSize"].ToString());
                string nameSearch = "";
                if (data.ContainsKey("nameSearch") && !string.IsNullOrEmpty(data["nameSearch"].ToString().Trim()))
                    nameSearch = data["nameSearch"].ToString().Trim().ToLower();
                paginationViewModel.Page = page;
                paginationViewModel.PageSize = pageSize;
                paginationViewModel.TotalItems = await _context.School.Where(x => x.Name.ToLower().IndexOf(nameSearch) >= 0).CountAsync();
                var model = from p in _context.School
                            select new SchoolViewModel
                            {
                                Id = p.Id,
                                Name = p.Name,
                                Image = p.Image,
                                CategoryName = p.Category.Name,
                                Description = p.Description,
                                SortDescription = p.SortDescription,
                                Detail = p.Detail,
                                IsNew = p.IsNew,
                                Url = p.Url,
                                Status = p.Status,
                                CreateDate = p.CreateDate,
                                ViewCount = p.ViewCount,
                                RankId = p.RankId,
                                AddressId = p.AddressId,
                                AddressDetail = p.AddressDetail
                            };
                string sortByName = "";
                if (data.ContainsKey("sortByName") && !string.IsNullOrEmpty(data["sortByName"].ToString().Trim()))
                    sortByName = data["sortByName"].ToString().Trim().ToLower();
                switch (sortByName)
                {
                    case "asc":
                        model = model.OrderBy(x => x.Name);
                        break;

                    case "desc":
                        model = model.OrderByDescending(x => x.Name);
                        break;
                }
                string sortByCreatedDate = "";
                if (data.ContainsKey("sortByCreatedDate") && !string.IsNullOrEmpty(data["sortByCreatedDate"].ToString().Trim()))
                    sortByCreatedDate = data["sortByCreatedDate"].ToString().Trim().ToLower();
                switch (sortByCreatedDate)
                {
                    case "asc":
                        model = model.OrderBy(x => x.CreateDate);
                        break;

                    case "desc":
                        model = model.OrderByDescending(x => x.CreateDate);
                        break;
                }
                paginationViewModel.Data = model.Where(x => x.Name.ToLower().IndexOf(nameSearch) >= 0).Skip((page - 1) * pageSize).Take(pageSize);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return paginationViewModel;
        }



        public async Task<int> Create(SchoolCreateRequest request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    School project = new School()
                    {
                        Name = request.Name,
                        Image = request.Image,
                        CategoryId = request.CategoryId,
                        Description = request.Description,
                        SortDescription = request.SortDescription,
                        Detail = request.Detail,
                        IsNew = request.IsNew,
                        Url = request.Url,
                        Status = request.Status,
                        CreateDate = DateTime.Now,
                        ViewCount = 0,
                        RankId = request.RankId,
                        AddressId = request.AddressId,
                        AddressDetail = request.AddressDetail
                    };
                    if (request.File != null)
                    {
                        project.Image = await SaveFile(request.File);
                    }
                    _context.School.Add(project);
                    await _context.SaveChangesAsync();

                    if (request.Files != null)
                    {
                        foreach (var item in request.Files)
                        {
                            SchoolImage image = new SchoolImage()
                            {
                                SchoolId = project.Id,
                                Path = await SaveFile(item)
                            };
                            _context.SchoolImage.Add(image);
                        }
                    };

                    int res = await _context.SaveChangesAsync();
                    transaction.Commit();
                    return res;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return -1;
                }
            }
        }

        public async Task<int> Update(SchoolUpdateRequest request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    School project = await _context.School.FindAsync(request.Id);
                    if (project == null) return -1;
                    project.Name = request.Name;
                    project.CategoryId = request.CategoryId;
                    project.Description = request.Description;
                    project.Detail = request.Detail;
                    project.IsNew = request.IsNew;
                    project.SortDescription = request.SortDescription;
                    project.Url = request.Url;
                    project.Status = request.Status;
                    project.EditDate = DateTime.Now;
                    project.RankId = request.RankId;
                    project.AddressId = request.AddressId;
                    project.AddressDetail = request.AddressDetail;
                    if (request.File != null)
                    {
                        await _storageService.DeleteFileAsync(project.Image);
                        project.Image = await SaveFile(request.File);
                    }

                    if (request.Files != null)
                    {
                        List<SchoolImage> images = await _context.SchoolImage.Where(x => x.SchoolId == project.Id).ToListAsync();
                        if (images.Count() > 0)
                        {
                            foreach (var item in images)
                            {
                                _context.SchoolImage.Remove(item);
                                await _storageService.DeleteFileAsync(item.Path);
                            }
                        }

                        foreach (var item in request.Files)
                        {
                            SchoolImage image = new SchoolImage()
                            {
                                SchoolId = project.Id,
                                Path = await SaveFile(item)
                            };
                            _context.SchoolImage.Add(image);
                        }
                    };
                    await _context.SaveChangesAsync();
                    transaction.Commit();
                    return 1;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return -1;
                }
            }
        }

        public async Task<int> IncreaseView(int id)
        {
                try
                {
                    School project = await _context.School.FindAsync(id);
                    if (project == null) return -1; 
                    project.ViewCount = project.ViewCount+1;
                    await _context.SaveChangesAsync();
                    return 1;
                }
                catch (Exception)
                {
                    return -1;
                }
            
        }


        public async Task<int> Delete(int id)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    School project = await _context.School.FindAsync(id);
                    if (project == null) return -1;
                    if (project.Image != null)
                    {
                        await _storageService.DeleteFileAsync(project.Image);
                    }
                    List<SchoolImage> images = await _context.SchoolImage.Where(x => x.SchoolId == id).ToListAsync();
                    if (images.Count() > 0)
                    {
                        foreach (var item in images)
                        {
                            _context.SchoolImage.Remove(item);
                            await _storageService.DeleteFileAsync(item.Path);
                        }
                    }
                    _context.School.Remove(project);
                    await _context.SaveChangesAsync();
                    transaction.Commit();
                    return 1;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return -1;
                }
            }
        }

        public async Task<SchoolViewModel> Detail(int id)
        {
            try
            {
                return await _context.School.Where(x => x.Id == id).Select(p => new SchoolViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Image = p.Image,
                    CategoryName = p.Category.Name,
                    Description = p.Description,
                    Detail = p.Detail,
                    Url = p.Url,
                    IsNew = p.IsNew,
                    CategoryId = p.CategoryId,
                    SortDescription = p.SortDescription,
                    Status = p.Status,
                    CreateDate = p.CreateDate,
                    RankId = p.RankId,
                    ViewCount = p.ViewCount,
                    AddressId = p.AddressId,
                    AddressDetail = p.AddressDetail,
                    Images = _context.SchoolImage.Where(x => x.SchoolId == id).ToList()
                }).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<SchoolUpdateRequest> Edit(int id)
        {
            try
            {
                School project = await _context.School.FindAsync(id);
                if (project == null) return null;
                SchoolUpdateRequest updateSchoolViewModel = new SchoolUpdateRequest()
                {
                    Id = project.Id,
                    Name = project.Name,
                    Image = project.Image,
                    CategoryId = project.CategoryId,
                    Description = project.Description,
                    Detail = project.Detail,
                    IsNew = project.IsNew,
                    Url = project.Url,
                    SortDescription = project.SortDescription,
                    Status = project.Status,
                    RankId = project.RankId,
                    ViewCount = project.ViewCount,
                    AddressId = project.AddressId,
                    AddressDetail = project.AddressDetail,
                    Images = _context.SchoolImage.Where(x => x.SchoolId == id).ToList()
                };

                return updateSchoolViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName;
        }

    }
}
