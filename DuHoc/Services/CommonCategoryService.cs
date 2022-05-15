using DuHoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuHoc.Services
{
    public interface ICommonCategoryService
    {
        Task<List<CommonCategory>> GetAll();
    }
    public class CommonCategoryService : ICommonCategoryService
    {
        private readonly DuHocContext _context;

        public CommonCategoryService(DuHocContext flowerContext)
        {
            _context = flowerContext;
        }

        public async Task<List<CommonCategory>> GetAll()
        {
            return await _context.CommonCategory.ToListAsync();
        }

    }
}
