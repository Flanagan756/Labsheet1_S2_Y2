using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_1
{
    public abstract class Band
    {
        /*Propeties*/
        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string  Members { get; set; }

        /*Constructor*/

        public Band()
        {

        }

        public Band (string bandName, int yearFormed, string members)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;

        }
    
    }

    public class RockBand : Band
    {
        public RockBand(string bandName, int yearFormed, string members)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;

        }
    }

      
}
