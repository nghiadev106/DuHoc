using DuHoc.Services;
using DuHoc.ViewModels.Category;
using DuHoc.ViewModels.Questions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace DuHoc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionsController : Controller
    {
        private readonly IQuestionService _newsService;
        private readonly ICategoryService _categoryService;

        public QuestionsController(IQuestionService newsService, ICategoryService categoryService)
        {
            _newsService = newsService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var lstQuestions = await _newsService.GetAll();
            ViewBag.lstQuestions = lstQuestions;
            return View();
        }


        public async Task<SelectList> loadCategory()
        {
            var categories = await _categoryService.GetAll();
            categories.Insert(0, new CategoryViewModel { Id = -1, Name = "-- Chọn danh mục --" });
            SelectList categoryList = new SelectList(categories, "Id", "Name");
            ViewBag.categoryList = categoryList;
            return categoryList;
        }

        public async Task<IActionResult> Create()
        {
            await loadCategory();
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create(QuestionCreateRequest request)
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

            var result = await _newsService.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới câu hỏi thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm câu hỏi thất bại");
            TempData["error"] = "Thêm mới câu hỏi thất bại";
            return View(request);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var news = await _newsService.Edit(id);
            if (news == null)
            {
                TempData["warning"] = "Bài viết không tồn tại";
                return RedirectToAction("Index");
            }

            await loadCategory();
            return View(news);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit(QuestionUpdateRequest request)
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

            var result = await _newsService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật câu hỏi thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật câu hỏi thất bại");
                TempData["error"] = "Cập nhật câu hỏi thất bại";
                return View(request);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = await _newsService.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Bài viết không tồn tại";
                return RedirectToAction("Index");
            }
            var result = await _newsService.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa câu hỏi thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Xóa câu hỏi thất bại";
            return RedirectToAction("Index");
        }
    }
}
