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

            modelBuilder.Entity<Module>().HasData(modules);

            List<Adventure> adventures = new List<Adventure>
            {
                new Adventure
                {
                    Id = 1,
                    Title = "Road to Nacre",
                    Description = "Players must find out about the Baron Stern Brow's daughter, Patience. " +
                    "They must travel to Nacre in hopes of finding her.",
                    ModuleId = 1
                },

                new Adventure
                {
                    Id = 2,
                    Title = "The Missing Children",
                    Description = "Players must help Mayor Sea Foam with recent disappearances of his younger citizens.",
                    ModuleId = 1
                }
            };

            modelBuilder.Entity<Adventure>().HasData(adventures);

            List<Dungeon> dungeons = new List<Dungeon>
            {
                new Dungeon
                {
                    Id = 1,
                    Title = "Fey Ambush",
                    Description = "Players must travel to nacre, either between two forests, or by sea. " +
                    "In either case, they are ambushed by fey creatures on the way there.",
                    AdventureId = 1
                },

                new Dungeon
                {
                    Id = 2,
                    Title = "Lover's Cave",
                    Description = "Players must find the missing people in Lover's cave.",
                    AdventureId = 2
                }
            };

            modelBuilder.Entity<Dungeon>().HasData(dungeons);

        }
    }
}