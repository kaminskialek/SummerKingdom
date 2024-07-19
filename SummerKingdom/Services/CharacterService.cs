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
            return characterRepository.CreateNonPlayerCharacter(character, nonPlayerCharacter);
        }

        public PlayerCharacter CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter, User user)
        {
            return characterRepository.CreatePlayerCharacter(character, playerCharacter);   
        }

        public Character Delete(int id, User user)
        {
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
            return characterRepository.UpdateNonPlayerCharacter(id, character, nonPlayerCharacter);
        }

        public PlayerCharacter UpdatePlayerCharacter
            (int id, Character character, PlayerCharacter playerCharacter, User user)
        {
            return characterRepository.UpdatePlayerCharacter(id, character, playerCharacter);
        }
    }
}
