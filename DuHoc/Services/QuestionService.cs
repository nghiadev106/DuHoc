using DuHoc.Models;
using DuHoc.ViewModels.Questions;
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
    public interface IQuestionService
    {
        Task<List<QuestionViewModel>> GetAll();
        Task<int> Create(QuestionCreateRequest request);
        Task<QuestionViewModel> Detail(int id);
        Task<QuestionUpdateRequest> Edit(int id);
        Task<int> Update(QuestionUpdateRequest request);
        Task<int> Delete(int id);
    }
    public class QuestionService : IQuestionService
    {
        private readonly DuHocContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "uploads";

        public QuestionService(DuHocContext flowerContext, IStorageService storageService)
        {
            _context = flowerContext;
            _storageService = storageService;
        }

        public async Task<List<QuestionViewModel>> GetAll()
        {

            return await _context.Question.Select(p => new QuestionViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Image = p.Image,
                CategotyName = p.Category.Name,
                Description = p.Description,
                Detail = p.Detail,
                IsNew = p.IsNew,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate
            }).ToListAsync();
        }

        public async Task<int> Create(QuestionCreateRequest request)
        {
            try
            {
                Question news = new Question()
                {
                    Name = request.Name,
                    Image = request.Image,
                    CategoryId = request.CategoryId,
                    Description = request.Description,
                    Detail = request.Detail,
                    IsNew = request.IsNew,
                    Url = request.Url,
                    DisplayOrder = request.DisplayOrder,
                    Status = request.Status,
                    CreateDate = DateTime.Now
                };
                if (request.FileUpload != null)
                {
                    news.Image = await SaveFile(request.FileUpload);
                }
                _context.Question.Add(news);
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
                Question news = await _context.Question.FindAsync(id);
                if (news == null) return -1;
                if (news.Image != null)
                {
                    await _storageService.DeleteFileAsync(news.Image);
                }
                _context.Question.Remove(news);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<QuestionViewModel> Detail(int id)
        {
            try
            {
                return await _context.Question.Where(x => x.Id == id).Select(p => new QuestionViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Image = p.Image,
                    CategotyName = p.Category.Name,
                    Description = p.Description,
                    Detail = p.Detail,
                    IsNew = p.IsNew
                }).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<QuestionUpdateRequest> Edit(int id)
        {
            try
            {
                Question news = await _context.Question.FindAsync(id);
                if (news == null) return null;
                QuestionUpdateRequest updateQuestionViewModel = new QuestionUpdateRequest()
                {
                    Id = news.Id,
                    Name = news.Name,
                    Image = news.Image,
                    CategoryId = news.CategoryId,
                    Description = news.Description,
                    Detail = news.Detail,
                    IsNew = news.IsNew,
                    Url = news.Url,
                    DisplayOrder = news.DisplayOrder,
                    Status = news.Status
                };

                return updateQuestionViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<int> Update(QuestionUpdateRequest request)
        {
            try
            {
                Question news = await _context.Question.FindAsync(request.Id);
                if (news == null) return -1;
                news.Name = request.Name;
                news.CategoryId = request.CategoryId;
                news.Description = request.Description;
                news.Detail = request.Detail;
                news.IsNew = request.IsNew;
                news.Url = request.Url;
                news.DisplayOrder = request.DisplayOrder;
                news.Status = request.Status;
                news.EditDate = DateTime.Now;
                if (request.FileUpload != null)
                {
                    await _storageService.DeleteFileAsync(news.Image);
                    news.Image = await SaveFile(request.FileUpload);
                }
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
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
