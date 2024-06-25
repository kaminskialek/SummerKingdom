namespace Data.Models
{
    public class CompletedAdventure
    {
        public int UserId { get; set; }

        public User User { get; set; } = null!;

        public int AdventureId { get; set; }

        public Adventure Adventure { get; set; } = null!;
    }
}
