using System.ComponentModel.DataAnnotations;

namespace DuHoc.ViewModels.NewsCategory
{
    public class NewsCategoryRequest
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên danh mục")]
        [StringLength(500, ErrorMessage = "tên danh mục không quá 500 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả danh mục")]
        [StringLength(500, ErrorMessage = "mô tả danh mục không quá 500 ký tự")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập URL")]
        [StringLength(500, ErrorMessage = "URL không quá 500 ký tự")]
        public string Url { get; set; }

        public int? DisplayOrder { get; set; }

        public bool ShowHomeInput
        {
            get => this.ShowHome.GetValueOrDefault();
            set { this.ShowHome = value; }
        }
        public bool? ShowHome { get; set; }
        public int? Status { get; set; }
    }
}
