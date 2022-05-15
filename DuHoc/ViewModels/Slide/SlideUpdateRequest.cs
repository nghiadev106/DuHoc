using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuHoc.ViewModels.Slide
{
    public class SlideUpdateRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tiêu đề")]
        [StringLength(500, ErrorMessage = "tiêu đề không quá 500 ký tự")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? Status { get; set; }
        public IFormFile FileUpload { get; set; }
    }
}
