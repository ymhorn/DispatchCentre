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

            bool helpAvailable = false;
            foreach (EmergencyTeam team in Teams)
            {
                if (team.Available != true)
                {
                    continue;
                }
                if (team.Region != report.AreaOfCity)
                {
                    continue;
                }
                Console.WriteLine($"Team {team.Name} was sent out to" +
                    $"the {report.TypeofIncident} in {report.AreaOfCity} ");
                team.Available = false;
                helpAvailable = true;
                break;
            }
            if (!helpAvailable)
            {
                Console.WriteLine("No one available");
            }
        }


    }
}
