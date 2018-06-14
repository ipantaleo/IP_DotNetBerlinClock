using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            string berlinClock = "";
            string[] listTime = aTime.Split(':');
            int hours = int.Parse(listTime[0]);
            int minutes = int.Parse(listTime[1]);
            int seconds = int.Parse(listTime[2]);

            berlinClock = seconds % 2 == 0 ? "Y\n" : "O\n";

            //block 5 hours
            int divisionHour = hours / 5;
            berlinClock += ActivateLed(divisionHour, "R");
            berlinClock += ActivateLed(4 - (divisionHour), "O") + "\n";

            //block 1 hours
            int restDivHour = hours % 5;
            berlinClock += ActivateLed(restDivHour, "R");
            berlinClock += ActivateLed(4 - (restDivHour), "O") + "\n";


            //block 5 minutes
            int divisionMinute = minutes / 5;
            berlinClock += ActivateLed(divisionMinute, "Y", true);
            berlinClock += ActivateLed(11 - (divisionMinute), "O") + "\n";


            //block 1 minutes
            int restDivMinute = minutes % 5;
            berlinClock += ActivateLed(restDivMinute, "Y");
            berlinClock += ActivateLed(4 - (restDivMinute), "O");


            return berlinClock;
        }

        private string ActivateLed(int ntime, string color, bool? fiveMinutsBox = false)
        {
            string ledResult = "";
            for (int i = 1; i <= ntime; i++)
            {
                if (fiveMinutsBox.Value && i % 3 == 0)
                {
                    ledResult += "R";
                }
                else
                {
                    ledResult += color;
                }
            }

            return ledResult;
        }
    }
}
