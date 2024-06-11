using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class PlayerCharacter
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public User Owner { get; set; } = null!;

        public string CharacterSheet { get; set; } = null!;
    }
}
