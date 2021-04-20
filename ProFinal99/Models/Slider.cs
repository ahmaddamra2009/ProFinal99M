using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProFinal99.Models
{
    public class Slider
    {
        public int SliderId { get; set; }
        public string SliderTitle { get; set; }
        public string SliderSubTitle { get; set; }
        public string Venu { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public string SliderDesc { get; set; }
        public string SliderImage { get; set; }
        public bool IsPublished { get; set; }

    }
}
