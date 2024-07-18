using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class User : IDeletable
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Username { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public UserType UserType { get; set; }  

        public List<LoreEntry> LoreEntries { get; set; } = new List<LoreEntry>();

        public List<PlayerCharacter> Characters { get; set; } = new List<PlayerCharacter>();

        public List<CompletedAdventure> CompletedAdventures { get; set; } = new List<CompletedAdventure>();

        public DateTime? DeletedOn { get; set; }
    }
}
