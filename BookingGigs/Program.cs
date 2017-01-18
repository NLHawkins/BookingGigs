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
                //new List<Seasons>() { Seasons.Summer, Seasons.Winter },
                "Slabtown, SC",false);

            MyBands crowehawk = new MyBands("CroweHawk", 2, "@cradbrowe",
                400, new List<Styles>() { Styles.Rock, Styles.Acoustic, Styles.SingSong },
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.Acoustic },
                //new List<Seasons>() { Seasons.Summer, Seasons.Spring },
                "Greenville, SC",false);

            MyBands nitrograss = new MyBands("Nitrograss!", 4, "@chuckwood",
                800, new List<Styles>() { Styles.Bluegrass, Styles.Acoustic, Styles.Pop },
                new List<NoiseLevel>() { NoiseLevel.FullBand, NoiseLevel.Acoustic },
                //new List<Seasons>() { Seasons.Summer, Seasons.Spring, Seasons.Fall, Seasons.Winter },
                "Highlands, NC",false);

            PotentialVenues handlebar = new PotentialVenues("The Handlebar", "Greenville,SC", 300, true,
                "@handlebar", new List<Seasons>() { Seasons.Spring, Seasons.Fall },600, 900,
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.FullBand },false);

            PotentialVenues smileys = new PotentialVenues("Smiley's Listening Room", "Greenville,SC", 60, false,
                "@smileybooking", new List<Seasons>() { Seasons.Winter, Seasons.Spring },300, 500,
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.Acoustic }, false);

            PotentialVenues peaceCenter = new PotentialVenues("The Peace Center", "Greenville,SC", 300, true,
                "@peacecenterbooking", new List<Seasons>() { Seasons.Summer, Seasons.Fall },1500, 2400,
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.FullBand, NoiseLevel.Acoustic }, false);



            //List<Styles
            int memberPay;
            while(soulfeathers.Booked == false)
            {
                Console.WriteLine($"Get a booking for {soulfeathers}");
                Console.WriteLine($"Your band has {soulfeathers.BandSize} members");
                Console.WriteLine("How much $ does each member need to make?");
                memberPay = int.Parse(Console.ReadLine());
                soulfeathers.MinimumPay = memberPay * (soulfeathers.BandSize);
                if (soulfeathers.AskingPay >= smileys.initialPay)
                {
                    Console.WriteLine($"{smileys.Name} may work");
                    Console.WriteLine($"Is the Noise Level of your Band: Acoustic, BrokeDown, or Full Band?");
                   
                    
                }
                else
                {
                    Console.WriteLine($"{smileys.Name} cannot pay that much");
                    Console.WriteLine($"Are {soulfeathers.BandName} willing to play for {smileys.Pay}?");
                }

                
                 

            }
        }
    }
}
