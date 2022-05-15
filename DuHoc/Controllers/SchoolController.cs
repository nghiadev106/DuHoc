using DuHoc.Models;
using DuHoc.Services;
using DuHoc.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DuHoc.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolService _service;
        private readonly DuHocContext _context;

        public SchoolController(ISchoolService service, DuHocContext context)
        {
            _service = service;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            var detail = await _service.Detail(id);
            detail.ViewCount = detail.ViewCount + 1;
            _context.SaveChanges();
            return View(detail);
        }

        public IActionResult Category(int id, int page = 1)
        {
            ViewBag.category = _context.Category.Where(x => x.Id == id).SingleOrDefault();
            //ViewBag.schools=_context.School.Where(x => x.CategoryId == id).ToList();
            int pageSize = 1;
            int totalRow = 0;
            var schools = _context.School.Where(x => x.CategoryId == id).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            totalRow = _context.School.Where(x => x.CategoryId == id).ToList().Count();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<School>()
            {
                Items = schools,
                MaxPage = 5,
                Page = page,
                CategoryId=id,
                TotalCount = totalRow,
                TotalPages = totalPage
            };

            return View(paginationSet);
        }

        public IActionResult Search(string keyword, int page = 1)
        {
            int pageSize = 1;
            int totalRow = 0;
            string queryString = string.Format("SELECT * FROM School WHERE dbo.fuConvertToUnsign1(Name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", keyword);
            var schools =  _context.School.FromSqlRaw(queryString).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            totalRow = _context.School.FromSqlRaw(queryString).ToList().Count();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<School>()
            {
                Items = schools,
                MaxPage = 5,
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalPage,
                Keyword=keyword
            };

            ViewBag.keyword = keyword;
            return View(paginationSet);
        }
    }
}
