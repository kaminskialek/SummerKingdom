﻿using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Adventure : IsDeletable
    {
        [Required, Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public int ModuleId { get; set; }

        public Module Module { get; set; } = null!;

        public string Description { get; set; } = null!;

        public List<NonPlayerCharacter> Characters { get; set; } = new List<NonPlayerCharacter>();

        public List<Dungeon> Dungeons { get; set; } = new List<Dungeon>();

        public List<CompletedAdventure> CompletedBy { get; set; } = new List<CompletedAdventure>();
        public DateTime? DeletedOn { get; set; }
    }
}
