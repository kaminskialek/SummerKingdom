using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Module : IsDeletable
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public List<Adventure> Adventures { get; set; } = new List<Adventure>();

        public DateTime? DeletedOn { get; set; }

    }
}
