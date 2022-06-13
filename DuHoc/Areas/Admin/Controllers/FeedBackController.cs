using DuHoc.Email;
using DuHoc.Models;
using DuHoc.Services;
using DuHoc.ViewModels.FeedBack;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DuHoc.Areas.Admin.Controllers
{
    public class FeedBackController : BaseController
    {
        private readonly IFeedbackService _service;
        private ISendMailService _sendMailservice;

        public FeedBackController(IFeedbackService service, ISendMailService sendMailservice)
        {
            _service = service;
            _sendMailservice = sendMailservice;
        }
        public async Task<IActionResult> Index()
        {
            var fbs =await  _service.GetAll();
            ViewBag.fbs = fbs;
            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            var res =await _service.Detail(id);
            return View(res);
        }

        public async Task<IActionResult> Confirm(FeedBackUpdateRequest fb)
        {

            var result =await _service.Update(fb.Id);


            MailContent content = new MailContent
            {
                To = fb.Email,
                Subject = "Phản hồi từ VJ",
                Body = fb.Reply
            };

            await _sendMailservice.SendMail(content);

            if (result == 1)
            {
                TempData["success"] = "Xác nhận thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Xác nhận thất bại";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var model = await _service.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Phản hồi không tồn tại";
                return RedirectToAction("Index");
            }
            var result = await _service.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Xóa thất bại";
            return RedirectToAction("Index");
        }

    }
}
