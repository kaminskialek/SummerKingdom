using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class LoreEntry : IsDeletable
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Content { get; set; } = null!;

        [Required, ForeignKey("User")]
        public int AuthorId { get; set; }

        public User Author { get; set; } = null!;

        public DateTime? DeletedOn { get; set; }
    }
}
