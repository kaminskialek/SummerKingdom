using Data.Models;

namespace Services.Contracts
{
    public interface ILoreEntryService
    {
        public LoreEntry Create(LoreEntry loreEntry, User user);

        public LoreEntry Update(LoreEntry loreEntry, int id, User user);

        public LoreEntry Delete(int id, User user);

        public LoreEntry GetById(int id);

        public List<LoreEntry> GetAll();
    }
}
