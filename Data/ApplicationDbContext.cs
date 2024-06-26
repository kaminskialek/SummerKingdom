using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<Adventure> Adventures { get; set; } = null!;

        public DbSet<Character> Characters { get; set; } = null!;

        public DbSet<CompletedAdventure> CompletedAdventures { get; set; } = null!;

        public DbSet<Dungeon> Dungeons { get; set; } = null!;

        public DbSet<Faction> Factions { get; set; } = null!;

        public DbSet<LoreEntry> LoreEntries { get; set; } = null!;

        public DbSet<Module> Modules { get; set; } = null!;

        public DbSet<NonPlayerCharacter> NonPlayerCharacters { get; set; } = null!;

        public DbSet<PlayerCharacter> PlayerCharacters { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            List<User> users = new List<User>
            {

                new User
                {
                    Id = 1,
                    Email = "alexkalionski@gmail.com",
                    Password = "kaminski",
                    FirstName = "Alexei",
                    LastName = "Kalionski",
                    Username = "Shoni",
                    UserType = UserType.Admin
                },

                new User
                {
                    Id = 2,
                    Email = "k.al.sotirov@gmail.com",
                    Password = "azlanrustmane",
                    FirstName = "Kiril",
                    LastName = "Sotirov",
                    Username = "Azlan",
                    UserType = UserType.DM,
                },

                new User
                {
                    Id = 3,
                    Email = "stefan.neschev@gmai.com",
                    Password = "donnelkoza",
                    FirstName = "Stefan",
                    LastName = "Neshev",
                    Username = "Donnel",
                    UserType = UserType.Player,
                },

                 
            };

            modelBuilder.Entity<User>().HasData(users);

            List<Module> modules = new List<Module>
            {
                new Module 
                { 
                    Id = 1,
                    Title = "Salt, Moss and Anise",
                    Description = "This is the starting module in the series. It spans levels 1-5."
                },

                                new Module
                {
                    Id = 2,
                    Title = "A Wizard's Playthings",
                    Description = "This is the second module in the series. It spans levels 5-9."
                }
            };
        } 
    }
}