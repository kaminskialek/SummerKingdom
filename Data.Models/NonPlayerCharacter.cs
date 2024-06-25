using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class NonPlayerCharacter : IsDeletable
    {
        [Required, Key]
        public int Id {  get; set; }

        [Required, ForeignKey("Character")]
        public int CharacterId { get; set; }

        public Faction Faction { get; set; } = null!;

        public string StatBlock { get; set; } = "N/A";

        public DateTime? DeletedOn { get; set; }
    }
}
