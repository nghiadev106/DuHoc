using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DuHoc.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Phone { get; set; }
        public string Email { get; set; }
    }
}
