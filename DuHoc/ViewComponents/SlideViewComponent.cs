using DuHoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteBanHang.ViewComponents
{
    [ViewComponent(Name = "Slide")]
    public class SlideViewComponent : ViewComponent
    {
        private readonly DuHocContext _context;

        public SlideViewComponent(DuHocContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slides = await _context.Slide.Where(x=>x.Status==1).ToListAsync();
            return View("Index", slides);
        }

    }
}
