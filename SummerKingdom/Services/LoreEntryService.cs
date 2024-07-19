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
            throw new NotImplementedException();
        }

        public LoreEntry Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<LoreEntry> GetAll()
        {
            throw new NotImplementedException();
        }

        public LoreEntry GetById(int id)
        {
            throw new NotImplementedException();
        }

        public LoreEntry Update(LoreEntry loreEntry, int id)
        {
            throw new NotImplementedException();
        }
    }
}
