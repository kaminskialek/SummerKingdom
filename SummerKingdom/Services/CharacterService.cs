using Common.Exceptions;
using Data.Models;
using Data.Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository characterRepository;
        public CharacterService(ICharacterRepository characterRepository)
        {
            this.characterRepository = characterRepository;
        }
        public NonPlayerCharacter CreateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter, User user)
        {
            return characterRepository.CreateNonPlayerCharacter(character, nonPlayerCharacter, user);
        }

        public PlayerCharacter CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter, User user)
        {
            //if (user.UserType != UserType.Player)
            //{
            //    throw new UnauthorizedOperationException("Only a player may create his or her player character.");
            //}
            return characterRepository.CreatePlayerCharacter(character, playerCharacter, user);   
        }

        public Character Delete(int id, User user)
        {
            if(user.UserType != UserType.Admin && !user.CreatedNonPlayerCharacters.Any(c => c.Id == id)
                && !user.Characters.Any(c => c.Id == id))
            {
                throw new UnauthorizedAccessException("Only an admin or the character's creator may delete it.");
            }
            return characterRepository.Delete(id);
        }

        public List<NonPlayerCharacter> GetAllNonPlayerCharacters()
        {
            return characterRepository.GetAllNonPlayerCharacters();
        }

        public List<PlayerCharacter> GetAllPlayerCharacters()
        {
            return characterRepository.GetAllPlayerCharacters();
        }

        public NonPlayerCharacter GetNonPlayerCharacter(int id, User user)
        {
            return characterRepository.GetNonPlayerCharacter(id);
        }

        public PlayerCharacter GetPlayerCharacter(int id, User user)
        {
            return characterRepository.GetPlayerCharacter(id);
        }

        public NonPlayerCharacter UpdateNonPlayerCharacter
            (int id, Character character, NonPlayerCharacter nonPlayerCharacter, User user)
        {
            if (user.UserType != UserType.Admin && !user.CreatedNonPlayerCharacters.Any(c => c.Id == id))
            {
                throw new UnauthorizedAccessException("Only an admin or the NPC's creator may modify it.");
            }
            return characterRepository.UpdateNonPlayerCharacter(id, character, nonPlayerCharacter);
        }

        public PlayerCharacter UpdatePlayerCharacter
            (int id, Character character, PlayerCharacter playerCharacter, User user)
        {
            if (user.UserType != UserType.Admin && !user.CreatedNonPlayerCharacters.Any(c => c.Id == id)
                && !user.Characters.Any(c => c.Id == id))
            {
                throw new UnauthorizedAccessException("Only an admin or the character's owner may modify it.");
            }
            return characterRepository.UpdatePlayerCharacter(id, character, playerCharacter);
        }
    }
}
