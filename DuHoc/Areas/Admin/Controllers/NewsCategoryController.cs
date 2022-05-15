using DuHoc.Services;
using DuHoc.ViewModels.NewsCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuHoc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsCategoryController : Controller
    {
        private readonly INewsCategoryService _categoryService;

        public NewsCategoryController(INewsCategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var lstCategories = await _categoryService.GetAll();
            ViewBag.lstCategories = lstCategories;
            return View();
        }

        public async Task<SelectList> loadNewsCategory()
        {
            List<NewsCategoryViewModel> categories = await _categoryService.GetAll();
            categories.Insert(0, new NewsCategoryViewModel { Id = -1, Name = "-- Chọn danh mục cha --" });
            SelectList categoryList = new SelectList(categories, "Id", "Name");
            ViewBag.categoryList = categoryList;
            return categoryList;
        }

        public async Task<IActionResult> Create()
        {
            await loadNewsCategory();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewsCategoryRequest request)
        {
            await loadNewsCategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            if (request.ParentId == -1)
            {
                request.ParentId = null;
            }

            var result = await _categoryService.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới danh mục thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm danh mục thất bại");
            TempData["error"] = "Thêm mới danh mục thất bại";
            return View(request);
        }

        public async Task<SelectList> loadNewsCategoryEdit(int id)
        {
            List<NewsCategoryViewModel> categories = await _categoryService.GetEdit(id);
            categories.Insert(0, new NewsCategoryViewModel { Id = -1, Name = "-- Chọn danh mục cha --" });
            SelectList categoryList = new SelectList(categories, "Id", "Name");
            ViewBag.categoryList = categoryList;
            return categoryList;
        }

        public async Task<IActionResult> Edit(int id)
        {
            await loadNewsCategoryEdit(id);
            var category = await _categoryService.Edit(id);
            if (category == null)
            {
                TempData["warning"] = "Danh mục không tồn tại";
                return RedirectToAction("Index");
            }

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NewsCategoryRequest request)
        {
            await loadNewsCategoryEdit(request.Id);
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            if (request.ParentId == -1)
            {
                request.ParentId = null;
            }

            var result = await _categoryService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật danh mục thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật danh mục thất bại");
                TempData["error"] = "Cập nhật danh mục thất bại";
                return View(request);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = await _categoryService.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Danh mục không tồn tại";
                return RedirectToAction("Index");
            }

            var result = await _categoryService.Delete(id);
            if (result != 1)
            {
                TempData["warning"] = "Danh mục chứa ko thể xóa";
                ModelState.AddModelError("", "Danh mục chứa ko thể xóa");
                return RedirectToAction("Index");
            }
            TempData["success"] = "Xóa danh mục thành công";
            return RedirectToAction("Index");
        }
    }
}
