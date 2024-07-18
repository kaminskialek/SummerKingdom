using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Dungeon : IDeletable
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required, ForeignKey("Adventure")]
        public int AdventureId;

        public Adventure Adventure { get; set; } = null!;

        public string Map { get; set; } = "N/A"!;

        public List<string> Encounters { get; set; } = new List<string>();

        public DateTime? DeletedOn { get; set; }
    }
}
