using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DuHoc.Models
{
    public partial class Rank
    {
        public Rank()
        {
            School = new HashSet<School>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<School> School { get; set; }
    }
}
