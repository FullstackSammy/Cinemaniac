using System.Drawing;

namespace Cinemaniac.Models
{
    public class Post
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Slug { get; set; }
        public string Author { get; set; }
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
        public string Content { get; set; }
        public Image Image { get; set; }
        public string Excerpt { get; set; }
        public DateTime CreatedOn { get; set; }

        public Post()
        {
            
        }

    }
}
