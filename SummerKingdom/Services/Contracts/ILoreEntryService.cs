using Data.Models;

namespace Services.Contracts
{
    public interface ILoreEntryService
    {
        public LoreEntry Create(LoreEntry loreEntry);

        public LoreEntry Update(LoreEntry loreEntry, int id);

        public LoreEntry Delete(int id);

        public LoreEntry GetById(int id);

        public List<LoreEntry> GetAll();
    }
}
