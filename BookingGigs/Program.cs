using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingGigs
{


    class Program
    {
        static void Main(string[] args)
        {
            MyBands soulfeathers = new MyBands("The Soulfeathers", 7, "@drwatso",
                1000, new List<Styles>() { Styles.Rock, Styles.Funk, Styles.Soul },
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.FullBand },
                new List<Seasons>() { Seasons.Summer, Seasons.Winter }, "Slabtown, SC",false);

            MyBands crowehawk = new MyBands("CroweHawk", 2, "@cradbrowe",
                400, new List<Styles>() { Styles.Rock, Styles.Acoustic, Styles.SingSong },
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.Acoustic },
                new List<Seasons>() { Seasons.Summer, Seasons.Spring }, "Greenville, SC",false);

            MyBands nitrograss = new MyBands("Nitrograss!", 4, "@chuckwood",
                800, new List<Styles>() { Styles.Bluegrass, Styles.Acoustic, Styles.Pop },
                new List<NoiseLevel>() { NoiseLevel.FullBand, NoiseLevel.Acoustic },
                new List<Seasons>() { Seasons.Summer, Seasons.Spring, Seasons.Fall, Seasons.Winter }, "Highlands, NC",false);
        }
    }
}
