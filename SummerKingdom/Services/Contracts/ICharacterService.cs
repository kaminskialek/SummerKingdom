using Data.Models;

namespace Services.Contracts
{
    public interface ICharacterService
    {
        public NonPlayerCharacter GetNonPlayerCharacter(int id, User user);

        public PlayerCharacter GetPlayerCharacter(int id, User user);

        public List<NonPlayerCharacter> GetAllNonPlayerCharacters();

        public List<PlayerCharacter> GetAllPlayerCharacters();

        public NonPlayerCharacter CreateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter, User user);

        public NonPlayerCharacter UpdateNonPlayerCharacter(int id, Character character, NonPlayerCharacter nonPlayerCharacter, User user);

        public PlayerCharacter CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter, User user);

        public PlayerCharacter UpdatePlayerCharacter(int id, Character character, PlayerCharacter playerCharacter, User user);

        public Character Delete(int id, User user);
    }
}
