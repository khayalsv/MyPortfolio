using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Skills 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Name1 { get; set; }
        public int Ability1 { get; set; }
        public string Name2 { get; set; }
        public int Ability2 { get; set; }
        public string Name3 { get; set; }
        public int Ability3 { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

    }
}
