using DuHoc.Models;
using DuHoc.Services;
using DuHoc.ViewModels.Category;
using DuHoc.ViewModels.School;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuHoc.Areas.Admin.Controllers
{
    public class SchoolController : BaseController
    {
        private readonly ISchoolService _service;
        private readonly ICategoryService _categoryService;
        private readonly IAddressService _addressService;
        private readonly IRankService _rankService;

        public SchoolController(ISchoolService service,
            ICategoryService categoryService,
            IAddressService addressService,
            IRankService rankService)
        {
            _service = service;
            _categoryService = categoryService;
            _addressService = addressService;
            _rankService = rankService;
        }
        public async Task<IActionResult> Index()
        {
            var lstSchool = await _service.GetAll();
            ViewBag.lstSchool = lstSchool;
            return View();
        }


        public async Task<SelectList> loadCategory()
        {
            List<CategoryViewModel> categories = await _categoryService.GetAll();
            categories.Insert(0, new CategoryViewModel { Id = -1, Name = "-- Chọn danh mục --" });
            SelectList categoryList = new SelectList(categories, "Id", "Name");

            List<Address> lstAddress = await _addressService.GetAll();
            SelectList addressList = new SelectList(lstAddress, "Id", "Name");

            List<Rank> ranks = await _rankService.GetAll();
            SelectList rankList = new SelectList(ranks, "Id", "Name");

            ViewBag.categoryList = categoryList;
            ViewBag.addressList = addressList;
            ViewBag.rankList = rankList;
            return categoryList;
        }


        public async Task<IActionResult> Create()
        {
            await loadCategory();
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create(SchoolCreateRequest request)
        {
            await loadCategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }


            if (request.CategoryId == -1)
            {
                ModelState.AddModelError("", "Bạn chưa chọn danh mục");
                TempData["warning"] = "Bạn chưa chọn danh mục";
                return View(request);
            }

            var result = await _service.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới trường học thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm trường học thất bại");
            TempData["error"] = "Thêm mới trường học thất bại";
            return View(request);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _service.Edit(id);
            if (product == null)
            {
                TempData["warning"] = "Trường học không tồn tại";
                return RedirectToAction("Index");
            }

            await loadCategory();
            return View(product);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit(SchoolUpdateRequest request)
        {
            await loadCategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";

                return View(request);
            }

            if (request.CategoryId == -1)
            {
                ModelState.AddModelError("", "Bạn chưa chọn danh mục");
                TempData["warning"] = "Bạn chưa chọn danh mục";
                return View(request);
            }

            var result = await _service.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật trường học thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật trường học thất bại");
                TempData["error"] = "Cập nhật trường học thất bại";
                return View(request);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = await _service.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Trường học không tồn tại";
                return RedirectToAction("Index");
            }
            var result = await _service.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa trường học thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Trường học có hóa đơn không thể xóa";
            return RedirectToAction("Index");
        }
    }
}
