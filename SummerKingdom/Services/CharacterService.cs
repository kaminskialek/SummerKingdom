using Data.Models;
using Services.Contracts;

namespace Services
{
    public class CharacterService : ICharacterService
    {
        public NonPlayerCharacter CreateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter)
        {
            throw new NotImplementedException();
        }

        public PlayerCharacter CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter)
        {
            throw new NotImplementedException();
        }

        public Character Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<NonPlayerCharacter> GetAllNonPlayerCharacters()
        {
            throw new NotImplementedException();
        }

        public List<PlayerCharacter> GetAllPlayerCharacters()
        {
            throw new NotImplementedException();
        }

        public NonPlayerCharacter GetNonPlayerCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public PlayerCharacter GetPlayerCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public NonPlayerCharacter UpdateNonPlayerCharacter(int id, Character character, NonPlayerCharacter nonPlayerCharacter)
        {
            throw new NotImplementedException();
        }

        public PlayerCharacter UpdatePlayerCharacter(int id, Character character, PlayerCharacter playerCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
