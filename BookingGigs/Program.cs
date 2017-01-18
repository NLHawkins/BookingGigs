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
                new List<Styles>() { Styles.Rock, Styles.Funk, Styles.Soul },
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.FullBand },
                new List<Seasons>() { Seasons.Summer, Seasons.Winter },
                "Slabtown, SC"/*, false*/);

            MyBands crowehawk = new MyBands("CroweHawk", 2, "@cradbrowe",
                new List<Styles>() { Styles.Rock, Styles.Acoustic, Styles.SingSong },
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.Acoustic },
                new List<Seasons>() { Seasons.Summer, Seasons.Spring },
                "Greenville, SC", false);

            MyBands nitrograss = new MyBands("Nitrograss!", 4, "@chuckwood",
                1000, new List<Styles>() { Styles.Bluegrass, Styles.Acoustic, Styles.Pop },
                new List<NoiseLevel>() { NoiseLevel.FullBand, NoiseLevel.Acoustic },
                new List<Seasons>() { Seasons.Summer, Seasons.Spring, Seasons.Fall, Seasons.Winter },
                "Highlands, NC", false);

            PotentialVenues handlebar = new PotentialVenues("The Handlebar", "Greenville,SC", 300, true,
                "@handlebar", new List<Seasons>() { Seasons.Spring, Seasons.Fall }, 600, 900,
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.FullBand }, false);

            PotentialVenues smileys = new PotentialVenues("Smiley's Listening Room", "Greenville,SC", 60, false,
                "@smileybooking", new List<Seasons>() { Seasons.Winter, Seasons.Spring }, 300, 500,
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.Acoustic }, false);

            PotentialVenues peaceCenter = new PotentialVenues("The Peace Center", "Greenville,SC", 300, true,
                "@peacecenterbooking", new List<Seasons>() { Seasons.Summer, Seasons.Fall }, 1500, 2400,
                new List<NoiseLevel>() { NoiseLevel.Brokedown, NoiseLevel.FullBand, NoiseLevel.Acoustic }, false);


            var dateMatch = new List<Seasons>();
            //var noiseMatch = new List<NoiseLevel>();
            bool willingToBook;
            int memberPay;
            while (soulfeathers.Booked == false)
            {
                Console.WriteLine($"Get a booking for {soulfeathers}");
                Console.WriteLine($"Your band has {soulfeathers.BandSize} members");
                Console.WriteLine("How much $ does each member need to make?");
                memberPay = int.Parse(Console.ReadLine());
                soulfeathers.AskingPay = memberPay * (soulfeathers.BandSize);
                var noiseMatch = new List<NoiseLevel>(smileys.NoiseLevelAllowed.Intersect(soulfeathers.NoiseLevel));
                if (smileys.NoiseLevelAllowed.Any(NoiseLevel => soulfeathers.NoiseLevel.Contains(NoiseLevel)))
                {
                    Console.WriteLine($"{soulfeathers.BandName} should fit in well at {smileys.Name}.");
                    Console.WriteLine($"{soulfeathers.BandName} should play at a {noiseMatch} level)");
                }

                if (soulfeathers.AskingPay >= smileys.initialPay)
                {
                    
                    Console.WriteLine($"{smileys.Name} can pay that.");
                }
                else
                {
                    Console.WriteLine($"Thats more than {smileys.Name} offered");
                    Console.WriteLine($"Send {smileys.Contact} at {smileys.Name} your minimum fee");
                    Console.WriteLine($"What is {soulfeathers.BandName} bottom dollar");
                    soulfeathers.MinimumPay = int.Parse(Console.ReadLine());
                    if (soulfeathers.MinimumPay > smileys.Pay)
                    {
                        Console.WriteLine($"Your band is too good for this {smileys.Name} joint");
                    }
                    else
                    {
                        Console.WriteLine($"Lets see how loud {soulfeathers.BandName} are");
                    }
                }
                var matchDates = soulfeathers.AvailableDates.Intersect(smileys.OpenDates);
                var dateMatches = new List<Seasons>(matchDates);
                var earliestDate = smileys.OpenDates.First(soulfeathers.AvailableDates.Contains));
                if (smileys.OpenDates.any(soulfeathers.AvailableDates.Contains))
                {
                    Console.WriteLine($"Let's book sometime in {matchDates}");

                }
                else
                {
                    Console.WriteLine($"Contact us again, we have open dates in {smileys.OpenDates}");
                }
            

                





            }
        }
    }
}
