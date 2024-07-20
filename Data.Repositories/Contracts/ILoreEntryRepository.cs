using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface ILoreEntryRepository
    {
        public LoreEntry Create (LoreEntry loreEntry, User user);

        public LoreEntry Update (LoreEntry loreEntry, LoreEntry updatedLoreEntry);

        public LoreEntry Delete (LoreEntry loreEntryToDelete);

        public LoreEntry GetById (int id);

        public List<LoreEntry> GetAll ();
    }
}
