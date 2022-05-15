using DuHoc.Models;
using DuHoc.ViewModels.Slide;
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
    public interface ISlideService
    {
        Task<List<SlideViewModel>> GetAll();

        Task<int> Create(SlideCreateRequest request);

        Task<SlideViewModel> Detail(int id);

        Task<SlideUpdateRequest> Edit(int id);

        Task<int> Update(SlideUpdateRequest request);

        Task<int> Delete(int id);
    }
    public class SlideService : ISlideService
    {
        private readonly DuHocContext _context;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "uploads";

        public SlideService(DuHocContext flowerContext, IStorageService storageService)
        {
            _context = flowerContext;
            _storageService = storageService;
        }

        public async Task<List<SlideViewModel>> GetAll()
        {

            return await _context.Slide.Select(p => new SlideViewModel()
            {
                Id = p.Id,
                Title=p.Title,
                Description = p.Description,
                Url = p.Url,
                Status = p.Status,
            }).ToListAsync();
        }

        public async Task<int> Create(SlideCreateRequest request)
        {
            try
            {
                Slide news = new Slide()
                {
                    Title=request.Title,
                    Description = request.Description,
                    Url = request.Url,
                    Status = request.Status,
                };
                if (request.FileUpload != null)
                {
                    news.Url = await SaveFile(request.FileUpload);
                }
                _context.Slide.Add(news);
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
                Slide news = await _context.Slide.FindAsync(id);
                if (news == null) return -1;
                if (news.Url != null)
                {
                    await _storageService.DeleteFileAsync(news.Url);
                }
                _context.Slide.Remove(news);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public async Task<SlideViewModel> Detail(int id)
        {
            try
            {
                return await _context.Slide.Where(x => x.Id == id).Select(p => new SlideViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Url = p.Url,
                    Description = p.Description,
                    Status = p.Status
                }).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<SlideUpdateRequest> Edit(int id)
        {
            try
            {
                Slide news = await _context.Slide.FindAsync(id);
                if (news == null) return null;
                SlideUpdateRequest updateSlideViewModel = new SlideUpdateRequest()
                {
                    Id = news.Id,
                    Title = news.Title,
                    Description = news.Description,
                    Url = news.Url,
                    Status = news.Status
                };

                return updateSlideViewModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<int> Update(SlideUpdateRequest request)
        {
            try
            {
                Slide news = await _context.Slide.FindAsync(request.Id);
                if (news == null) return -1;
                news.Title = request.Title;
                news.Description = request.Description;
                news.Status = request.Status;
                if (request.FileUpload != null)
                {
                    await _storageService.DeleteFileAsync(news.Url);
                    news.Url = await SaveFile(request.FileUpload);
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
