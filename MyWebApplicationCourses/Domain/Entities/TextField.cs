﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApplicationCourses.Domain.Entities
{
    public class TextField:EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Title")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Text")]
        public override string Text { get; set; } = "Content is filled by the administrator";
    }
}
