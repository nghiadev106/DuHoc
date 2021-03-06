using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuHoc.ViewModels.Slide
{
    public class SlideViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? Status { get; set; }
    }
}
