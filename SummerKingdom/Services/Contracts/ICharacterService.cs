using Data.Models;

namespace Services.Contracts
{
    public interface ICharacterService
    {
        public NonPlayerCharacter GetNonPlayerCharacter(int id);

        public PlayerCharacter GetPlayerCharacter(int id);

        public List<NonPlayerCharacter> GetAllNonPlayerCharacters();

        public List<PlayerCharacter> GetAllPlayerCharacters();

        public NonPlayerCharacter CreateNonPlayerCharacter(Character character, NonPlayerCharacter nonPlayerCharacter);

        public NonPlayerCharacter UpdateNonPlayerCharacter(int id, Character character, NonPlayerCharacter nonPlayerCharacter);

        public PlayerCharacter CreatePlayerCharacter(Character character, PlayerCharacter playerCharacter);

        public PlayerCharacter UpdatePlayerCharacter(int id, Character character, PlayerCharacter playerCharacter);

        public Character Delete(int id);
    }
}
