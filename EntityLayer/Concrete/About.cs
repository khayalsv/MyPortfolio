using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class About 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int TotalProject { get; set; }
        public int Experience { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
