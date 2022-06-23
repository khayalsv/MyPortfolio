using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Details
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } //logo

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
