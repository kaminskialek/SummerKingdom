using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Faction : IDeletable
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public List<NonPlayerCharacter> Members { get; set; } = new List<NonPlayerCharacter>();

        public List<Faction> Allies { get; set; } = new List<Faction>();

        public List<Faction> Opponents { get; set; } = new List<Faction>();

        public DateTime? DeletedOn { get; set; }
    }
}
