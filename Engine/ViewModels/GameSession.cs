using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();

            CurrentPlayer.Name = "Balls";
            CurrentPlayer.Gold = 3000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();

            CurrentLocation.FloorNumber = 0;

            WorldFactory factory = new WorldFactory();
            // Creates a new instance of the world.
            CurrentWorld = factory.CreateWorld();
        }
    }
}
