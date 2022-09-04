using System.ComponentModel.DataAnnotations.Schema;


namespace AutoRent.Models
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string FeaturedImage { get; set; }
    }
}