using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD levy = new CD { Artist = "Nightwish", Name = "Endless Forms Most Beatiful" };

            Biisi biisi1 = new Biisi { Song = "Shudder Before the Beautiful", Length = "6:29" };
            Biisi biisi2 = new Biisi { Song = "Weak Fantasy", Length = "5:23" };
            Biisi biisi3 = new Biisi { Song = "Elan", Length = "4:45" };
            Biisi biisi4 = new Biisi { Song = "Yours Is an Empty Hope", Length = "5:34" };
            Biisi biisi5 = new Biisi { Song = "Our Decades in the Sun", Length = "6:37" };
            Biisi biisi6 = new Biisi { Song = "My Walden", Length = "4:38" };
            Biisi biisi7 = new Biisi { Song = "Endless Forms Most Beautiful", Length = "5:07" };
            Biisi biisi8 = new Biisi { Song = "Edema Ruh", Length = "5:15" };
            Biisi biisi9 = new Biisi { Song = "Alpenglow", Length = "4:45" };
            Biisi biisi10 = new Biisi { Song = "The Eyes of Sharbat Gula", Length = "6:03" };
            Biisi biisi11 = new Biisi { Song = "The Greatest Show on Earth", Length = "24:00" };

            CD songs = new CD();

            songs.AddBiisi(biisi1);
            songs.AddBiisi(biisi2);
            songs.AddBiisi(biisi3);
            songs.AddBiisi(biisi4);
            songs.AddBiisi(biisi5);
            songs.AddBiisi(biisi6);
            songs.AddBiisi(biisi7);
            songs.AddBiisi(biisi8);
            songs.AddBiisi(biisi9);
            songs.AddBiisi(biisi10);
            songs.AddBiisi(biisi11);

            songs.PrintData();


        }
    }
}
