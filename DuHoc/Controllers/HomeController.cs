using DuHoc.Models;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Contact()
        {
            return View();
        }
    }
}
