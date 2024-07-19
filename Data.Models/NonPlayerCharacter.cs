using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class NonPlayerCharacter 
    {
        [Key, ForeignKey("Character")]
        public int Id { get; set; }

        public Character Character { get; set; } = null!;

        [Required, ForeignKey("Faction")]
        public int FactionId;

        [Required, ForeignKey("Creator")]
        public int CreatorId { get; set; }
        public User Creator { get; set; } = null!;

        public Faction Faction { get; set; } = null!;

        public string StatBlock { get; set; } = "N/A";

    }
}
