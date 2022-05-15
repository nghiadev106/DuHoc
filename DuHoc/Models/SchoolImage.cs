using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DuHoc.Models
{
    public partial class SchoolImage
    {
        public int Id { get; set; }
        public int? SchoolId { get; set; }
        public string Path { get; set; }

        public virtual School School { get; set; }
    }
}
