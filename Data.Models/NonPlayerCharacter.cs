using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class NonPlayerCharacter : IsDeletable
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, ForeignKey("Character")]
        public int CharacterId { get; set; }


        [Required, ForeignKey("Faction")]
        public int FactionId;

        public Faction Faction { get; set; } = null!;

        public string StatBlock { get; set; } = "N/A";

        public DateTime? DeletedOn { get; set; }
    }
}
