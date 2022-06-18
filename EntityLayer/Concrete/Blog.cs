using System;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
