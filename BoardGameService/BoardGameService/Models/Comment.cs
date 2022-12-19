using System.ComponentModel.DataAnnotations;

namespace BoardGameService.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        [Required]
        public string Author { get; set; }
        public DateTime Created { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int BoardGameId { get; set; }
        public BoardGame BoardGame { get; set; }
    }
}
