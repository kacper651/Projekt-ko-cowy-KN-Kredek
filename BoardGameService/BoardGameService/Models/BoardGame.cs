namespace BoardGameService.Models
{
    public class BoardGame
    {
        public BoardGame(int id, string name, float rating, string description, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Rating = rating;
            this.Description = description;
            this.Image = image;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Rating { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
