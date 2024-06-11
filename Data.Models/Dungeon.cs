using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Dungeon
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public string Map { get; set; } = "N/A"!;

        public List<string> Encounters { get; set; } = new List<string>();
    }
}
