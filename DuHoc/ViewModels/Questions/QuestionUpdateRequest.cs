using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace DuHoc.ViewModels.Questions
{
    public class QuestionUpdateRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên câu hỏi")]
        [StringLength(500, ErrorMessage = "tên câu hỏi không quá 500 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn danh mục")]
        public int? CategoryId { get; set; }
        public string Image { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả câu hỏi")]
        [StringLength(500, ErrorMessage = "mô tả câu hỏi không quá 500 ký tự")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập chi tiết câu hỏi")]
        public string Detail { get; set; }

        public bool? IsNew { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập URL")]
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn trạng thái")]
        public int? Status { get; set; }
        public bool IsNewInput
        {
            get => this.IsNew.GetValueOrDefault();
            set { this.IsNew = value; }
        }
        public IFormFile FileUpload { get; set; }
    }
}
