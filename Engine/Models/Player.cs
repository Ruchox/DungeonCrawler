using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int Gold { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        
        //public Player(string name, string characterClass, int hitPoints, int gold, int level, int experiencePoints)
        //{
        //    Name = name;
        //    CharacterClass = characterClass;
        //    HitPoints = hitPoints;
        //    Gold = gold;
        //    Level = level;
        //    ExperiencePoints = experiencePoints;
        //}
        
    }
}
