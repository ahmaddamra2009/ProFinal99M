using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProFinal99.Models
{
    public class Menu
    {
        [Key]
        public Guid MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
    }
}
