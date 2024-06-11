using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class NonPlayerCharacter
    {
        public int Id {  get; set; }

        public int CharacterId { get; set; }

        public Faction Faction { get; set; } = null!;

        public string StatBlock { get; set; } = "N/A";
    }
}
