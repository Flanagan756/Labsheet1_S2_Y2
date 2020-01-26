using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_1
{
    class Album
    {
   

        //Properties
        public string AlbumName { get; set; }
        public int Released { get; set; }
        public int Sales { get; set; }

        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(1990, 2020);
        }

        //Constructor
        public Album(string albumName, int sales)
        {
            AlbumName = albumName;

            Released = RandomNumber();

            Sales = sales;

        }

        public override string ToString()
        {

            return $"{AlbumName} Relased: {Released} Sales: {Sales}";
        }

    }
}
