using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class DungeonRepository : IDungeonRepository
    {

        private readonly ApplicationDbContext dungeonContext;

        private const string dungeonNotFoundErrorMessage = "Dungeon with id {0} cannot be found.";

        public DungeonRepository(ApplicationDbContext dungeonContext) 
        {
            this.dungeonContext = dungeonContext;
        }
        public Dungeon Create(Dungeon dungeon, Adventure adventure)
        {
            dungeonContext.Dungeons.Add(dungeon);

            adventure.Dungeons.Add(dungeon);

            dungeonContext.SaveChanges();

            return dungeon;
        }

        public Dungeon Delete(Dungeon dungeonToDelete)
        {

            dungeonToDelete.DeletedOn = DateTime.Now;

            dungeonContext.SaveChanges();

            return dungeonToDelete;
        }

        public List<Dungeon> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dungeon GetById(int id)
        {
            Dungeon dungeon = dungeonContext.Dungeons
                .Include(d => d.Adventure)
                .ThenInclude(a => a.Module)
                .ThenInclude(m => m.Creator)
                .FirstOrDefault(d => d.Id == id && d.DeletedOn.HasValue == false)
                ?? throw new EntityNotFoundException(string.Format(dungeonNotFoundErrorMessage, id));

            return dungeon;
        }

        public Dungeon Update(Dungeon dungeon, Dungeon updatedDungeon)
        {

            updatedDungeon.Title = dungeon.Title;
            updatedDungeon.Encounters = dungeon.Encounters;
            updatedDungeon.Map = dungeon.Map;
            updatedDungeon.Description = dungeon.Description;

            dungeonContext.SaveChanges();

            return updatedDungeon;
        }
    }
}
