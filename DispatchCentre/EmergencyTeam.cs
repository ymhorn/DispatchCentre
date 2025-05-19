using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCentre
{
    internal class EmergencyTeam
    {
        public string Name;
        public string Region;
        public bool Available;

        public EmergencyTeam(string name, string region, bool available)
        {
            this.Name = name;
            this.Region = region;
            this.Available = available;
        }
    }
}
