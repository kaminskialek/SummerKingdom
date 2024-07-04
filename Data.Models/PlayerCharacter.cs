using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class PlayerCharacter : IsDeletable
    {
        [Key, ForeignKey("Character")]
        public int Id { get; set; }

        public Character Character { get; set; } = null!;

        [Required, ForeignKey("User")]
        public int OwnerId { get; set; }

        public User Owner { get; set; } = null!;

        public string CharacterSheet { get; set; } = "N/A";

        public DateTime? DeletedOn { get; set; }
    }
}
