using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface ILoreEntryRepository
    {
        public LoreEntry Create (LoreEntry loreEntry);

        public LoreEntry Update (LoreEntry loreEntry, int id);

        public LoreEntry Delete (int id);

        public LoreEntry GetById (int id);

        public List<LoreEntry> GetAll ();
    }
}
