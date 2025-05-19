using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCentre
{
    internal class Injuries : EmergencyTeam
    {
        public Injuries(string name, string region, bool available) : base(name, region, available)
        { }
    }
}
