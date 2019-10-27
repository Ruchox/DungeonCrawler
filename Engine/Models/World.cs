using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _location = new List<Location>();

        internal void AddLocation(int floorNumber)
        {
            Location loc = new Location();
            loc.FloorNumber = floorNumber;

            _location.Add(loc);
        }
    }
}
