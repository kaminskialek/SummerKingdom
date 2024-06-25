using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Character : IsDeletable
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public int Age { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        public List<string> Traits { get; set; } = new List<string>();

        public List<string> Ideals { get; set; } = new List<string>();

        public List<string> Bonds { get; set; } = new List<string>();

        public List<string> Flaws { get; set; } = new List<string>();

        public DateTime? DeletedOn { get; set; }
    }
}
