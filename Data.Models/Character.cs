﻿namespace Data.Models
{
    public class Character
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string Description { get; set; } = null!;

        public List<string> Traits { get; set; } = new List<string>();

        public List<string> Ideals { get; set; } = new List<string>();

        public List<string> Bonds { get; set; } = new List<string>();

        public List<string> Flaws { get; set; } = new List<string>();

        public List<Adventure> Adventures { get; set; } = new List<Adventure>();

        public bool isPlayerCharacter { get; set; }

        public string StatBlock { get; set; } = "N/A";
    }
}
