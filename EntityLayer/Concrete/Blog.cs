using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
