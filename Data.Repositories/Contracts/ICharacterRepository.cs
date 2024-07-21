using Data.Models;

namespace Data.Repositories.Contracts
{
    public interface ICharacterRepository
    {
        public NonPlayerCharacter GetNonPlayerCharacter(int id);

        public PlayerCharacter GetPlayerCharacter(int id);

        public List<NonPlayerCharacter> GetAllNonPlayerCharacters();

        public List<PlayerCharacter> GetAllPlayerCharacters();

        public NonPlayerCharacter CreateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter, User user);

        public NonPlayerCharacter UpdateNonPlayerCharacter(int id, Character character, NonPlayerCharacter nonPlayerCharacter);

        public PlayerCharacter CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter, User user);

        public PlayerCharacter UpdatePlayerCharacter(int id, Character character, PlayerCharacter playerCharacter);

        public Character Delete(int id);


    }
}
