using Data.Models;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {

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


        NonPlayerCharacter ICharacterRepository.CreateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter)
        {
            throw new NotImplementedException();
        }

        PlayerCharacter ICharacterRepository.CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter)
        {
            throw new NotImplementedException();
        }

        NonPlayerCharacter ICharacterRepository.UpdateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter)
        {
            throw new NotImplementedException();
        }

        PlayerCharacter ICharacterRepository.UpdatePlayerCharacter(Character character, PlayerCharacter playerCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
