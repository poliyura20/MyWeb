using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApplicationCourses.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "Subtitle")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Text")]
        public virtual string Text { get; set; }

        [Display(Name = "Title Image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO Meta Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO Meta Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO Meta Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
