﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DuHoc.Models
{
    public partial class CommonCategory
    {
        public CommonCategory()
        {
            News = new HashSet<News>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ShowHome { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
