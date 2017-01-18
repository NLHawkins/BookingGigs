using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingGigs
{
    enum NoiseLevel
    {
        Acoustic, Brokedown, FullBand
    }

    enum Styles
    {
        Rock, Bluegrass, Acoustic, Funk, SingSong, Pop, Soul
    }

    enum Seasons
    {
        Spring, Summer, Winter, Fall
    }
    
    enum Bookings
    {
        Booked, Open
    }

    class MyBands
    {


        public int BandSize;
        public string BandName;
        public string BandContact;
        public int AskingPay;
        public int MinimumPay;
        public List<Styles> Styles;
        public List<NoiseLevel> NoiseLevel;
        public List<Seasons> AvailableDates;
        public string CurrentLocale;
        public bool Booked;


        public MyBands
            (
            string _name,
            int _bandsize,
            string _bandContact,
            //int _askingPay,
            //int _minpay,
            List<Styles> _Styles,
            List<NoiseLevel> _NoiseLevel,
            List<Seasons> _AvailableDates,
            string _CurrentLocale,
            bool _booked,            
            )
        {
            BandName = _name;
            BandSize = _bandsize;
            BandContact = _bandContact;
            //AskingPay = _askingPay;
            //MinimumPay = _minpay;
            Styles = _Styles;
            NoiseLevel = _NoiseLevel;
            AvailableDates = _AvailableDates;
            CurrentLocale = _CurrentLocale;
            Booked = _booked;

        }

        


    }
}
