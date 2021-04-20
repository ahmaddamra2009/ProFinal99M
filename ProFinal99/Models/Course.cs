using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProFinal99.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDesc { get; set; }
        public string SubDesc { get; set; }
        public DateTime SDate { get; set; }
        public TimeSpan STime { get; set; }
        public decimal Price { get; set; }
        public string Venu { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
