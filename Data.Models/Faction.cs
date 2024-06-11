namespace Data.Models
{
    public class Faction
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public List<NonPlayerCharacter> Members { get; set; } = new List<NonPlayerCharacter>();

        public List<Faction> Allies { get; set; } = new List<Faction>();

        public List<Faction> Opponents { get; set; } = new List<Faction>();
    }
}
