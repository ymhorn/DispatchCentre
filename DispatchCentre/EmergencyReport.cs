using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCentre
{
    internal class EmergencyReport
    {
        public string TypeofIncident;
        public string AreaOfCity;
        public string Seriousness;
        public string LengthOfIssue;
        public string Description;

        public EmergencyReport(string typeofIncident, string areaOfCity, string seriousness, string lengthOfIssue, string description) 
        {
            this.TypeofIncident = typeofIncident;
            this.AreaOfCity = areaOfCity;
            this.Seriousness = seriousness;
            this.LengthOfIssue = lengthOfIssue;
            this.Description = description;
        }

        public string Report()
        {
            return $"Ther is a {TypeofIncident} in {AreaOfCity}," +
                $"it is {Seriousness} and expected to last {LengthOfIssue}." +
                $"The description given was: {Description}";
        }
    }
}
