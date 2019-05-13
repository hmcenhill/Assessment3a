using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3a
{
    public class SpaceShuttle
    {
        public int Fuel { get; set; }
        public List<Crew> Team { get; set; }
        public SpaceShuttle()
        {
            Fuel = 0;
            Team = new List<Crew>();
            Team.Add(new Crew("John", "Captain"));
            Team.Add(new Crew("Diddy", "Chimp"));
            Team.Add(new Crew("Hannah", "Navigator"));
        }
        public bool Launch()
        {
            return Fuel > 5 && Team.Count == 3;
        }
    }
}
