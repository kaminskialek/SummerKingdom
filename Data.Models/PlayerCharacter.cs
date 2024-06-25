using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class PlayerCharacter : IsDeletable
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, ForeignKey("Character")]
        public int CharacterId { get; set; }

        public User Owner { get; set; } = null!;

        public string CharacterSheet { get; set; } = null!;

        public DateTime? DeletedOn { get; set; }
    }
}
