namespace Data.Models
{
    public class Dungeon
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Map { get; set; } = null!;

        public List<string> Encounters { get; set; } = new List<string>();
    }
}
