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
        public NonPlayerCharacter CreateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter)
        {
            return characterRepository.CreateNonPlayerCharacter(character, nonPlayerCharacter);
        }

        public PlayerCharacter CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter)
        {
            return characterRepository.CreatePlayerCharacter(character, playerCharacter);   
        }

        public Character Delete(int id)
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

        public NonPlayerCharacter GetNonPlayerCharacter(int id)
        {
            return characterRepository.GetNonPlayerCharacter(id);
        }

        public PlayerCharacter GetPlayerCharacter(int id)
        {
            return characterRepository.GetPlayerCharacter(id);
        }

        public NonPlayerCharacter UpdateNonPlayerCharacter(int id, Character character, NonPlayerCharacter nonPlayerCharacter)
        {
            return characterRepository.UpdateNonPlayerCharacter(id, character, nonPlayerCharacter);
        }

        public PlayerCharacter UpdatePlayerCharacter(int id, Character character, PlayerCharacter playerCharacter)
        {
            return characterRepository.UpdatePlayerCharacter(id, character, playerCharacter);
        }
    }
}
