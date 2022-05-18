using DuHoc.Services;
using DuHoc.ViewModels.Slide;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DuHoc.Areas.Admin.Controllers
{
    public class SlideController : BaseController
    {
        private readonly ISlideService _service;

        public SlideController(ISlideService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var lstSlide = await _service.GetAll();
            ViewBag.lstSlide = lstSlide;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create(SlideCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result = await _service.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới Slide thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm Slide thất bại");
            TempData["error"] = "Thêm mới Slide thất bại";
            return View(request);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var news = await _service.Edit(id);
            if (news == null)
            {
                TempData["warning"] = "Slide không tồn tại";
                return RedirectToAction("Index");
            }

            return View(news);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit(SlideUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result = await _service.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật Slide thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật Slide thất bại");
                TempData["error"] = "Cập nhật Slide thất bại";
                return View(request);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = await _service.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Slide không tồn tại";
                return RedirectToAction("Index");
            }
            var result = await _service.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa Slide thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Xóa Slide thất bại";
            return RedirectToAction("Index");
        }
    }
}
