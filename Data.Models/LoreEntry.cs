namespace Data.Models
{
    public class LoreEntry
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public User Author { get; set; } = null!;
    }
}
