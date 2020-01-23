using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_1
{
    public abstract class Band : IComparable<Band>
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

              
        //Sorting
        public int CompareTo(Band other)
        {
            int returnValue = this.BandName.CompareTo(other.BandName); //Compare Prefered Position

         

            return returnValue; //Return the value
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
          /*Methods*/
        public override string ToString()
        {

            return $"{BandName} RockBand";
        }

    }
    public class PopBand : Band 
    {
        public PopBand(string bandName, int yearFormed, string members)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;

        }
             /*Methods*/
        public override string ToString()
        {

            return $"{BandName} PopBand";
        }
      }
      public class IndieBand : Band 
    {
        public IndieBand(string bandName, int yearFormed, string members)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;

        }
             /*Methods*/
        public override string ToString()
        {

            return $"{BandName} IndieBand";
        }
   
    }
    
  

      
}
