using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PlayerCharacter
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, ForeignKey("Character")]
        public int CharacterId { get; set; }

        public User Owner { get; set; } = null!;

        public string CharacterSheet { get; set; } = null!;
    }
}
