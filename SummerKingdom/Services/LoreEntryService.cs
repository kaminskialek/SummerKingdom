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
        public LoreEntry Create(LoreEntry loreEntry)
        {
            return loreEntryRepository.Create(loreEntry);
        }

        public LoreEntry Delete(int id)
        {
            return loreEntryRepository.Delete(id);
        }

        public List<LoreEntry> GetAll()
        {
            return loreEntryRepository.GetAll();
        }

        public LoreEntry GetById(int id)
        {
            return loreEntryRepository.GetById(id);
        }

        public LoreEntry Update(LoreEntry loreEntry, int id)
        {
            return loreEntryRepository.Update(loreEntry, id);
        }
    }
}
