using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public string Btn { get; set; }
        public string BtnText { get; set; }

    }
}
