using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CompletedAdventure
    {
        public int UserId { get; set; }

        public User User { get; set; } = null!;

        public int AdventureId { get; set; }

        public Adventure Adventure { get; set; } = null!;
    }
}
