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

        public DbSet<User> Users { get; set; }

        public DbSet<Adventure> Adventures { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<CompletedAdventure> CompletedAdventures { get; set; }

        public DbSet<Dungeon> Dungeons { get; set; }

        public DbSet<Faction> Factions { get; set; }

        public DbSet<LoreEntry> LoreEntries { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<NonPlayerCharacter> NonPlayerCharacters { get; set; }

        public DbSet<PlayerCharacter> PlayerCharacters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}