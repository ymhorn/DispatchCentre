using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCentre
{
    internal class DispatchCentre
    {
        public EmergencyTeam[] Teams;
        public DispatchCentre(EmergencyTeam[] teams)
        {
            this.Teams = teams;
        }

        public void Report(EmergencyReport report)
        {

            foreach (EmergencyTeam team in Teams)
            {
                if (team.Region != report.AreaOfCity)
                {
                    continue;
                }
                if (team.CanHelp())
                {
                    team.Report();
                    team.Available = false;
                }
            }
        }


    }
}
