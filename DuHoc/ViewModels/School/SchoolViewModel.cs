using DuHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuHoc.ViewModels.School
{
    public class SchoolViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string SortDescription { get; set; }
        public string Detail { get; set; }
        public bool? IsNew { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public string Url { get; set; }
        public int? Status { get; set; }
        public int? AddressId { get; set; }
        public string AddressDetail { get; set; }
        public int? ViewCount { get; set; }
        public int? RankId { get; set; }
        public List<SchoolImage> Images { get; set; }
    }
}
