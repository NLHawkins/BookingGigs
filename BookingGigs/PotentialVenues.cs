using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingGigs
{
    class PotentialVenues
    {
        public string Name;
        public string Location;
        public int Capacity;
        public bool HasSound;
        public string Contact;
        public string OpenDates;
        public float Pay;
        public string NoiseLevelAllowed;


        public PotentialVenues
            (
            string _name,
            string _location,
            int _capacity,
            bool _hasSound,
            string _contact,
            string _openDates,
            float _pay,
            string _noiseLevelAllowed
            )
        {
            Name = _name;
            Location = _location;
            Capacity = _capacity;
            HasSound = _hasSound;
            Contact = _contact;
            OpenDates = _openDates;
            Pay = _pay;
            NoiseLevelAllowed = _noiseLevelAllowed;
        }



    }
}
