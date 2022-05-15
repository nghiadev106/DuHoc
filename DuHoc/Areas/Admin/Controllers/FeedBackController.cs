using Microsoft.AspNetCore.Mvc;

namespace DuHoc.Areas.Admin.Controllers
{
    public class FeedBackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
