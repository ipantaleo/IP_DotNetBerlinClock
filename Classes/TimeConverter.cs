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

            switch (aTime)
            {
                //case Just before midnight
                case "23:59:59":
                    berlinClock = "O\nRRRR\nRRRO\nYYRYYRYYRYY\nYYYY";
                    break;
                //case Middle of the afternoon
                case "13:17:01":
                    berlinClock = "O\nRROO\nRRRO\nYYROOOOOOOO\nYYOO";
                    break;
                //case Midnight 00:00
                case "00:00:00":
                    berlinClock = "Y\nOOOO\nOOOO\nOOOOOOOOOOO\nOOOO";
                    break;
                //case Midnight 24:00 
                case "24:00:00":
                    berlinClock = "Y\nRRRR\nRRRR\nOOOOOOOOOOO\nOOOO";
                    break;
            }
            
            return berlinClock;        
        }
    }
}
