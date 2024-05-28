namespace Data.Models
{
    public class Adventure
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public List<Faction> Factions { get; set; } = new List<Faction>();

        public List<Character> Characters { get; set; } = new List<Character>();

        public List<Dungeon> Dungeons { get; set; } = new List<Dungeon>();

        public List<User> StartedBy { get; set; } = new List<User>();

        public List<User> CompletedBy { get; set; } = new List<User>();
    }
}
