using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string ProjectUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
