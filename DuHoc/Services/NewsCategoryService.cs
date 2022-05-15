using DuHoc.Models;
using DuHoc.ViewModels.NewsCategory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuHoc.Services
{
    public interface INewsCategoryService
    {
        Task<List<NewsCategoryViewModel>> GetAll();
        Task<List<NewsCategoryViewModel>> GetEdit(int id);
        Task<int> Create(NewsCategoryRequest request);
        Task<NewsCategoryViewModel> Detail(int id);
        Task<NewsCategoryRequest> Edit(int id);
        Task<int> Update(NewsCategoryRequest request);
        Task<int> Delete(int id);
    }
    public class NewsCategoryService : INewsCategoryService
    {
        private readonly DuHocContext _context;

        public NewsCategoryService(DuHocContext flowerContext)
        {
            _context = flowerContext;
        }

        public async Task<int> Create(NewsCategoryRequest request)
        {
            try
            {
                CommonCategory category = new CommonCategory()
                {
                    Name = request.Name,                  
                    Description = request.Description,   
                    ParentId=request.ParentId,
                    ShowHome = request.ShowHome,
                    Url = request.Url,
                    DisplayOrder = request.DisplayOrder,
                    Status = request.Status,
                    CreateDate = DateTime.Now
                };
                _context.CommonCategory.Add(category);
                int res = await _context.SaveChangesAsync();
                return res;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<int> Delete(int id)
        {
            try
            {
                CommonCategory category = await _context.CommonCategory.FindAsync(id);
                if (category == null) return -1;
                _context.CommonCategory.Remove(category);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<NewsCategoryViewModel> Detail(int id)
        {
            try
            {
                CommonCategory category = await _context.CommonCategory.FindAsync(id);
                NewsCategoryViewModel detailNewsCategoryViewModel = new NewsCategoryViewModel()
                {
                    Id = category.Id,
                    Name = category.Name,
                    ParentId=category.ParentId,
                    ShowHome = category.ShowHome,
                    Description = category.Description,
                    Url = category.Url,
                    DisplayOrder = category.DisplayOrder,
                    Status = category.Status
                };
                return detailNewsCategoryViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<NewsCategoryRequest> Edit(int id)
        {
            try
            {
                CommonCategory category = await _context.CommonCategory.FindAsync(id);
                if (category == null) return null;
                NewsCategoryRequest updateNewsCategorysViewModel = new NewsCategoryRequest()
                {
                    Id = category.Id,
                    Name = category.Name,
                    ParentId=category.ParentId,
                    ShowHome = category.ShowHome,
                    Description = category.Description, 
                    Url = category.Url,
                    DisplayOrder = category.DisplayOrder,
                    Status = category.Status
                };

                return updateNewsCategorysViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<NewsCategoryViewModel>> GetAll()
        {

            return await _context.CommonCategory.Select(p => new NewsCategoryViewModel()
            {

                Id = p.Id,
                Name = p.Name,               
                ParentId=p.ParentId,
                Description = p.Description,
                ShowHome = p.ShowHome,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate
            }).ToListAsync();
        }

        public async Task<List<NewsCategoryViewModel>> GetEdit(int id)
        {

            return await _context.CommonCategory.Where(x=>x.Id!=id).Select(p => new NewsCategoryViewModel()
            {

                Id = p.Id,
                Name = p.Name,
                ParentId = p.ParentId,
                Description = p.Description,
                ShowHome = p.ShowHome,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate
            }).ToListAsync();
        }



        public async Task<int> Update(NewsCategoryRequest request)
        {
            try
            {
                CommonCategory category = await _context.CommonCategory.FindAsync(request.Id);
                if (category == null) return -1;
                category.Name = request.Name;
                category.ParentId = request.ParentId;
                category.Description = request.Description;           
                category.Url = request.Url;
                category.DisplayOrder = request.DisplayOrder;
                category.Status = request.Status;
                category.ShowHome = request.ShowHome;
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
