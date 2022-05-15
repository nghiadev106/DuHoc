using DuHoc.Models;
using DuHoc.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DuHoc.Controllers
{
    public class NewController : Controller
    {
        private readonly DuHocContext _context;

        public NewController(DuHocContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            var detail =  _context.News.Where(x => x.Id == id).SingleOrDefault();
            var related = _context.News.Where(x => x.CategoryId == detail.CategoryId && x.Id != id && x.Status == 1).OrderBy(x => x.DisplayOrder).Take(12).ToList();
            ViewBag.related = related;
            return View(detail);
        }

        public IActionResult Category(int id,int page=1)
        {
            ViewBag.category = _context.CommonCategory.Where(x => x.Id == id).SingleOrDefault();
            ViewBag.questions = _context.Question.Take(5).ToList();
            int pageSize = 1;
            int totalRow = 0;
            var questions = _context.News.Where(x => x.CategoryId == id).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            totalRow = _context.News.Where(x => x.CategoryId == id).ToList().Count();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<News>()
            {
                Items = questions,
                MaxPage = 5,
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalPage
            };

            return View(paginationSet);
        }
    }
}
