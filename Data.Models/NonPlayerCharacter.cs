using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class NonPlayerCharacter : IsDeletable
    {
        [Key, ForeignKey("Character")]
        public int Id { get; set; }

        public Character Character { get; set; } = null!;

        [Required, ForeignKey("Faction")]
        public int FactionId;

        public Faction Faction { get; set; } = null!;

        public string StatBlock { get; set; } = "N/A";

        public DateTime? DeletedOn { get; set; }
    }
}
