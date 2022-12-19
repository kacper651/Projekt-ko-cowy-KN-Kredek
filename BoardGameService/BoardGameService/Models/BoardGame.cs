namespace BoardGameService.Models
{
    public class BoardGame
    {
        public BoardGame(int id, string name, int age, float rating, List<string> categories, string description, float gameTime, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Rating = rating;
            this.Categories = categories;
            this.Description = description;
            this.GameTime = gameTime;
            this.Image = image;
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rating { get; set; }
        public List<string> Categories { get; set; }
        public string Description { get; set; }
        public float GameTime { get; set; }
        public string Image { get; set; }

    }
}
