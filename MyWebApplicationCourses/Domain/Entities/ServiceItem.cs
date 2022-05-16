using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApplicationCourses.Domain.Entities
{
    public class ServiceItem:EntityBase
    {
        [Required(ErrorMessage = "Fill in the name")]
        [Display(Name = "Title")]
        public override string Title { get; set; }

        [Display(Name = "Subtitle")]
        public override string Subtitle { get; set; }

        [Display(Name = "Text")]
        public override string Text { get; set; }
    }
}
