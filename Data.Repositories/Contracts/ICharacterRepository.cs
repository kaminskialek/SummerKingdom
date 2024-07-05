using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Contracts
{
    public interface ICharacterRepository
    {
        public NonPlayerCharacter GetNonPlayerCharacter(int id);

        public PlayerCharacter GetPlayerCharacter(int id);

        public List<NonPlayerCharacter> GetAllNonPlayerCharacters();

        public List<PlayerCharacter> GetAllPlayerCharacters();

        public NonPlayerCharacter CreateNonPlayerCharacter(NonPlayerCharacter nonPlayerCharacter);

        public NonPlayerCharacter UpdateNonPlayerCharacter(NonPlayerCharacter nonPlayerCharacter);

        public PlayerCharacter CreatePlayerCharacter (PlayerCharacter playerCharacter);

        public PlayerCharacter UpdatePlayerCharacter(PlayerCharacter playerCharacter);

        public Character Delete(int id);



       
    }
}
