using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Module : IDeletable
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required, ForeignKey("User")]
        public int CreatorId { get; set; }
        public User Creator { get; set; } = null!;

        public List<Adventure> Adventures { get; set; } = new List<Adventure>();

        public DateTime? DeletedOn { get; set; }

    }
}
