using DuHoc.Models;
using DuHoc.ViewModels.Dashboard;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuHoc.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly DuHocContext _context;

        public DashboardController(DuHocContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var counts = new DashboardViewModel
            {
                School = _context.School.ToList().Count(),
                News = _context.News.ToList().Count(),
                Category = _context.Category.ToList().Count(),
                NewsCategory = _context.CommonCategory.ToList().Count(),
                Question = _context.Question.ToList().Count(),
                FeedBack = _context.Feedback.Where(x=>x.Status==0).ToList().Count()
            };
            //ViewBag.ListProject = _context.Projects.Where(x => x.IsHot == true && x.IsNew == true && x.Status == 1).ToList();
            ViewBag.counts = counts;
            return View();
        }
    }
}
