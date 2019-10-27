using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        // Returns a new World object whenever called.
        internal World CreateWorld()
        {
            World newWorld = new World();
            return new World();
        }
    }
}
