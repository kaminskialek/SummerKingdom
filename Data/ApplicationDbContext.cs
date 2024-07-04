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

            modelBuilder.Entity<PlayerCharacter>()
                    .HasOne(pc => pc.Character)
                    .WithOne(c => c.PlayerCharacter)
                    .HasForeignKey<PlayerCharacter>(pc => pc.Id);

            modelBuilder.Entity<NonPlayerCharacter>()
                    .HasOne(npc => npc.Character)
                    .WithOne(c => c.NonPlayerCharacter)
                    .HasForeignKey<NonPlayerCharacter>(npc => npc.Id);

            modelBuilder.Entity<CompletedAdventure>()
                    .HasKey(ca => new { ca.UserId, ca.AdventureId });

            modelBuilder.Entity<CompletedAdventure>()
                    .HasOne(ca => ca.User)
                    .WithMany(u => u.CompletedAdventures)
                    .HasForeignKey(ca => ca.UserId);

            modelBuilder.Entity<CompletedAdventure>()
                    .HasOne(ca => ca.Adventure)
                    .WithMany(a => a.CompletedBy)
                    .HasForeignKey(ca => ca.AdventureId);

            modelBuilder.Entity<Character>()
                    .Ignore(c => c.Traits)
                    .Ignore(c => c.Ideals)
                    .Ignore(c => c.Bonds)
                    .Ignore(c => c.Flaws);

            modelBuilder.Entity<Dungeon>().Ignore(d => d.Encounters);

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

            List<Faction> factions = new List<Faction>
            {
                new Faction
                {
                    Id = 1,
                    Name = "Blue Tower",
                    Description = "This is Xazhadir the Diviner's seat of power."
                },

                new Faction
                {
                    Id= 2,
                    Name = "Nacre",
                    Description = "Nacre is a small fishing town where the first module takes place."
                }
            };

            modelBuilder.Entity<Faction>().HasData(factions);

            List<LoreEntry> loreEntries = new List<LoreEntry>
            {
                new LoreEntry
                {
                    Id = 1,
                    Title = "Rhyme of Creation",
                    Content = "Rhyme of Creation\r\n" +
                    "First comes always Everglow\r\n" +
                    "Hidden pulse from deep and low\r\n" +
                    "Second comes Foundation Stone\r\n" +
                    "This one to be left alone!\r\n" +
                    "Wolfrose lively, Wolfrose calm\r\n" +
                    "Shifts and turns in pouch or palm\r\n" +
                    "Many covet Summercrown\r\n" +
                    "Wisdom’s gift of high renown \r\n" +
                    "Living Rainbow – fancy’s roam,\r\n" +
                    "Fickle as the ocean’s foam\r\n" +
                    "Sin of the Eternal Book\r\n" +
                    "Seek it if you dare to look\r\n" +
                    "Last of Ages sees the Bow\r\n" +
                    "May it ever Truepath show\r\n"
                },

                new LoreEntry
                {
                    Id= 2,
                    Title = "Salt, Moss and Anise",
                    Content = "This is the story of three sisters who all desired eternal life."
                }
            };

            modelBuilder.Entity<LoreEntry>().HasData(loreEntries);

            List<Character> characters = new List<Character>
            {
                new Character
                {
                    Id = 1,
                    Name = "Xazhadir",
                    Description = "Xazhadir is the arch-mage who occupies the blue tower. " +
                    "He is the primary quest giver of the second module."
                },

                new Character
                {
                    Id= 2,
                    Name = "Azlan",
                    Description = "Azlan is a leonin from Desolation. " +
                    "He has embarked on a quest seeking to improve the living conditions in his tribe. "
                },

                new Character
                {
                    Id = 3,
                    Name = "Mayor Sea Foam",
                    Description = "Sea Foam is the hot-tempered, but caring and honourable mayor of Nacre."
                },

                new Character
                {
                    Id= 4,
                    Name = "Blank Canvas",
                    Description = "Blank Canvas is a half-elf paladin, who has sworn an oath to protect nature, its beauty and its bounty."
                }
            };

            modelBuilder.Entity<Character>().HasData(characters);

            List<NonPlayerCharacter> nonPlayerCharacters = new List<NonPlayerCharacter>
            {
                new NonPlayerCharacter
                {
                    Id = 1,
                    FactionId = 1,
                },

                new NonPlayerCharacter
                {
                    Id= 3,
                    FactionId = 2,
                }
            };

            modelBuilder.Entity<NonPlayerCharacter>().HasData(nonPlayerCharacters);

            List<PlayerCharacter> playerCharacters = new List<PlayerCharacter>
            {
                new PlayerCharacter
                {
                    Id = 2,
                    OwnerId = 2,
                },

                new PlayerCharacter
                {
                    Id= 4,
                    OwnerId = 3,
                }
            };

            modelBuilder.Entity<PlayerCharacter>().HasData(playerCharacters);

            List<CompletedAdventure> completedAdventures = new List<CompletedAdventure>
            {
                new CompletedAdventure
                {
                    UserId = 2,
                    AdventureId = 1
                },

                new CompletedAdventure
                {
                    UserId = 3,
                    AdventureId = 1
                }
            };

            modelBuilder.Entity<CompletedAdventure>().HasData(completedAdventures);

        }
    }
}