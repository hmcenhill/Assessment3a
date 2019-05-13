using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3a
{
    public class Crew
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public Crew(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
