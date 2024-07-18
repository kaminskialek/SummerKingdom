using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationDbContext characterContext;

        private const string characterNotFoundErrorMessage = "{0} with id {1} cannot be found.";

        public CharacterRepository(ApplicationDbContext context)
        {
            this.characterContext = context;
        }

        public Character Delete(int id)
        {
            Character characterToDelete = GetCharacterById(id);

            characterToDelete.DeletedOn = DateTime.Now;

            characterContext.SaveChanges();

            return characterToDelete;
        }

        public List<NonPlayerCharacter> GetAllNonPlayerCharacters()
        {
            List<NonPlayerCharacter> NPCs = characterContext.NonPlayerCharacters
                .Include(npc => npc.Character)
                .Include(npc => npc.Faction)
                .ToList();

            return NPCs;
        }

        public List<PlayerCharacter> GetAllPlayerCharacters()
        {
            List<PlayerCharacter> PCs = characterContext.PlayerCharacters
                .Include(npc => npc.Character)
                .Include(npc => npc.Owner)
                .ToList();

            return PCs;
        }

        public Character GetCharacterById(int id)
        {
            Character character = characterContext.Characters
                .FirstOrDefault(c => c.Id == id) ??
                throw new EntityNotFoundException(string.Format(characterNotFoundErrorMessage, "Character", id));

            return character;
        }
        public NonPlayerCharacter GetNonPlayerCharacter(int id)
        {
            NonPlayerCharacter NPC = characterContext.NonPlayerCharacters
                .Include (npc => npc.Character)
                .Include(npc => npc.Faction)
                .FirstOrDefault(c => c.Id == id) ??
                throw new EntityNotFoundException(string.Format(characterNotFoundErrorMessage, "Non-player character", id));

            return NPC;
        }

        public PlayerCharacter GetPlayerCharacter(int id)
        {
            PlayerCharacter PC = characterContext.PlayerCharacters
                .Include(pc => pc.Character)
                .Include(pc => pc.Owner)
                .FirstOrDefault(c => c.Id == id) ??
                throw new EntityNotFoundException(string.Format(characterNotFoundErrorMessage, "Player character", id));

            return PC;
        }


        public NonPlayerCharacter CreateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter)
        {
            characterContext.Characters.Add(character);

            nonPlayerCharacter.Id = character.Id;
            
            characterContext.NonPlayerCharacters.Add(nonPlayerCharacter);

            character.NonPlayerCharacter = nonPlayerCharacter;

            characterContext.SaveChanges();

            return nonPlayerCharacter;

        }

        public PlayerCharacter CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter)
        {
            characterContext.Characters.Add(character);

            playerCharacter.Id = character.Id;

            characterContext.PlayerCharacters.Add(playerCharacter);

            character.PlayerCharacter = playerCharacter;

            characterContext.SaveChanges();

            return playerCharacter;
        }

        public NonPlayerCharacter UpdateNonPlayerCharacter(int id, Character character, NonPlayerCharacter nonPlayerCharacter)
        {
            NonPlayerCharacter updatedCharacter = GetNonPlayerCharacter(id);

            updatedCharacter.Character.Name = character.Name;
            updatedCharacter.Character.Age = character.Age;
            updatedCharacter.Character.Description = character.Description;
            updatedCharacter.Character.Ideals = character.Ideals;
            updatedCharacter.Character.Bonds = character.Bonds;
            updatedCharacter.Character.Traits = character.Traits;
            updatedCharacter.Character.Flaws = character.Flaws;

            updatedCharacter.Faction = nonPlayerCharacter.Faction;
            updatedCharacter.StatBlock = nonPlayerCharacter.StatBlock;

            characterContext.SaveChanges();

            return updatedCharacter;
        }

        public PlayerCharacter UpdatePlayerCharacter(int id, Character character, PlayerCharacter playerCharacter)
        {
            PlayerCharacter updatedCharacter = GetPlayerCharacter(id);

            updatedCharacter.Character.Name = character.Name;
            updatedCharacter.Character.Age = character.Age;
            updatedCharacter.Character.Description = character.Description;
            updatedCharacter.Character.Ideals = character.Ideals;
            updatedCharacter.Character.Bonds = character.Bonds;
            updatedCharacter.Character.Traits = character.Traits;
            updatedCharacter.Character.Flaws = character.Flaws;

            updatedCharacter.CharacterSheet = playerCharacter.CharacterSheet;

            characterContext.SaveChanges();

            return updatedCharacter;
        }
    }
}
