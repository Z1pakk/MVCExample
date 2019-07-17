using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ти дебіл. Вкажи щось.")]
        public string Name { get; set; }

        public string Title { get; set; }

        public int PageCount { get; set; }

        public string Author { get; set; }

        public float Price { get; set; }

        public DateTime DateOfWrite { get; set; }

        public string Description { get; set; }

        public List<string> Filter { get; set; }

        [Display(Name="Чи продається")]
        
        public bool isDisabled { get; set; }
    }
}