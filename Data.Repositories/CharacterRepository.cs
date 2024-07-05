using Data.Models;
using Data.Repositories.Contracts;

namespace Data.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        public NonPlayerCharacter CreateNonPlayerCharacter(NonPlayerCharacter nonPlayerCharacter)
        {
            throw new NotImplementedException();
        }

        public PlayerCharacter CreatePlayerCharacter(PlayerCharacter playerCharacter)
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

        public NonPlayerCharacter UpdateNonPlayerCharacter(NonPlayerCharacter nonPlayerCharacter)
        {
            throw new NotImplementedException();
        }

        public PlayerCharacter UpdatePlayerCharacter(PlayerCharacter playerCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
