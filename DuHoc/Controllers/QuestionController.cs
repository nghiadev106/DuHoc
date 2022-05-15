using DuHoc.Models;
using DuHoc.Services;
using DuHoc.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DuHoc.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService _service;
        private readonly DuHocContext _context;

        public QuestionController(IQuestionService service, DuHocContext context)
        {
            _service = service;
            _context = context;
        }

        public IActionResult Category(int id, int page = 1)
        {
            ViewBag.category = _context.Category.Where(x => x.Id == id).SingleOrDefault();
            ViewBag.news = _context.News.Take(5).ToList();
            int pageSize = 1;
            int totalRow = 0;
            var questions = _context.Question.Where(x => x.CategoryId == id).Skip((page - 1) * pageSize).Take(pageSize).ToList();
            totalRow = _context.Question.Where(x => x.CategoryId == id).ToList().Count();
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var paginationSet = new PaginationSet<Question>()
            {
                Items = questions,
                MaxPage = 5,
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalPage
            };

            return View(paginationSet);
        }

        public IActionResult Detail(int id)
        {
            var detail = _context.Question.Where(x => x.Id == id).SingleOrDefault();
            var related = _context.Question.Where(x => x.CategoryId == detail.CategoryId && x.Id != id && x.Status == 1).OrderBy(x => x.DisplayOrder).Take(12).ToList();
            ViewBag.related = related;
            return View(detail);
        }
    }
}
