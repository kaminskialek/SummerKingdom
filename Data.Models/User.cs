namespace Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Username { get; set; } = null!; 
        
        public string Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public UserType UserType { get; set; }  

        public List<LoreEntry> LoreEntries { get; set; } = new List<LoreEntry>();

        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
