﻿using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    public class LoreEntryRepository : ILoreEntryRepository
    {
        private readonly ApplicationDbContext loreEntryContext;

        private const string loreEntryNotFoundErrorMessage = "Lore entry with id {0} cannot be found.";

        public LoreEntryRepository(ApplicationDbContext context) 
        {
            this.loreEntryContext = context;
        }
        public LoreEntry Create(LoreEntry loreEntry, User user)
        {
            loreEntry.Author = user;

            loreEntryContext.LoreEntries.Add(loreEntry);

            loreEntryContext.SaveChanges();

            return loreEntry;
        }

        public LoreEntry Delete(LoreEntry loreEntryToDelete)
        {

            loreEntryToDelete.DeletedOn = DateTime.Now;

            loreEntryContext.SaveChanges();

            return loreEntryToDelete;
        }

        public List<LoreEntry> GetAll()
        {
            throw new NotImplementedException();
        }

        public LoreEntry GetById(int id)
        {
            LoreEntry loreEntry = loreEntryContext.LoreEntries
            .FirstOrDefault(l => l.Id == id && l.DeletedOn.HasValue == false) ??
            throw new EntityNotFoundException(string.Format(loreEntryNotFoundErrorMessage, id));

            return loreEntry;
        }

        public LoreEntry Update(LoreEntry loreEntry, LoreEntry updatedLoreEntry)
        {

            updatedLoreEntry.Title = loreEntry.Title;
            updatedLoreEntry.Content = loreEntry.Content;

            loreEntryContext.SaveChanges();

            return updatedLoreEntry;
        }
    }
}
