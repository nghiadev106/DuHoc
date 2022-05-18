using DuHoc.Models;
using DuHoc.ViewModels.FeedBack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DuHoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly DuHocContext _context;

        public HomeController(DuHocContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.newsKorea = _context.News.Where(x => x.CategoryId == 1002).Take(3).ToList();
            var newsHot = _context.News.Where(x => x.CategoryId == 1003).SingleOrDefault();
            ViewBag.newsHot = newsHot;
            ViewBag.newsJapan = _context.News.Where(x => x.CategoryId == 1003 && x.Id!=newsHot.Id).Take(3).ToList();
            ViewBag.newsVJ = _context.News.Where(x => x.CategoryId == 1).Take(3).ToList();
            ViewBag.schoolJapan = _context.School.Where(x => x.CategoryId == 2).Take(3).ToList();
            ViewBag.schoolKorea = _context.School.Where(x => x.CategoryId == 1002).Take(3).ToList();
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(FeedBackRequest request)
        {
            if (ModelState.IsValid)
            {
                Feedback model = new Feedback()
                {
                    Name = request.Name,
                    Message = request.Message,
                    CreateDate = DateTime.Now,
                    Status = 0,
                    Address = request.Address,
                    Phone = request.Phone,
                    Email = request.Email
                };

                _context.Feedback.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(request);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
