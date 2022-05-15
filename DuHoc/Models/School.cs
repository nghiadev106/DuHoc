using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DuHoc.Models
{
    public partial class School
    {
        public School()
        {
            SchoolImage = new HashSet<SchoolImage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string SortDescription { get; set; }
        public string Description { get; set; }
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

        public virtual Address Address { get; set; }
        public virtual Category Category { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual ICollection<SchoolImage> SchoolImage { get; set; }
    }
}
