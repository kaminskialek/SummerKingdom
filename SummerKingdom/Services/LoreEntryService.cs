using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class LoreEntryService : ILoreEntryService
    {
        private readonly ILoreEntryRepository loreEntryRepository;
        public LoreEntryService(ILoreEntryRepository loreEntryRepository)
        {
            this.loreEntryRepository = loreEntryRepository;
        }
        public LoreEntry Create(LoreEntry loreEntry, User user)
        {
            return loreEntryRepository.Create(loreEntry, user);
        }

        public LoreEntry Delete(int id, User user)
        {
            LoreEntry loreEntryToDelete = loreEntryRepository.GetById(id);
            if (user.UserType != UserType.Admin && loreEntryToDelete.Author != user)
            {
                throw new UnauthorizedOperationException("Only and admin or the author of a lore entry may delete it.");
            }
            return loreEntryRepository.Delete(loreEntryToDelete);
        }

        public List<LoreEntry> GetAll()
        {
            return loreEntryRepository.GetAll();
        }

        public LoreEntry GetById(int id)
        {
            return loreEntryRepository.GetById(id);
        }

        public LoreEntry Update(LoreEntry loreEntry, int id, User user)
        {
            LoreEntry updatedLoreEntry = loreEntryRepository.GetById(id);
            if (user.UserType != UserType.Admin && updatedLoreEntry.Author != user)
            {
                throw new UnauthorizedOperationException("Only and admin or the author of a lore entry may modify it.");
            }
            return loreEntryRepository.Update(loreEntry, updatedLoreEntry);
        }
    }
}
