using DuHoc.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuHoc.ViewModels.School
{
    public class SchoolUpdateRequest
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Detail { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public int? AddressId { get; set; }
        public string AddressDetail { get; set; }
        public int? ViewCount { get; set; }
        public int? RankId { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [StringLength(500, ErrorMessage = "Tên sản phẩm không quá 500 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn danh mục")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả ngắn")]
        [StringLength(500, ErrorMessage = "Mô tả ngắn không quá 500 ký tự")]
        public string SortDescription { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập URL")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn trạng thái")]
        public int? Status { get; set; }
        public bool IsNewInput
        {
            get => this.IsNew.GetValueOrDefault();
            set { this.IsNew = value; }
        }
        public IFormFile File { get; set; }
        public List<IFormFile> Files { get; set; }
        public List<SchoolImage> Images { get; set; }
    }
}
