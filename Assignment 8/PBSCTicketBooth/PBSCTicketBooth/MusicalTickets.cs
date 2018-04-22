//Cole Hemp
//MusicalTickets.cs
//Ticket Class for Musicals

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSCTicketBooth
{
    class MusicalTickets : Tickets
    {
        string musicalName;
        string theaterLocation;

        public MusicalTickets()
            : base()
        {
            //Default Constructor
        }

        public MusicalTickets(string musicalName, string theaterLocation, int quantity, double cost, DateTime date, DateTime time)
            : base(quantity, cost, date, time)
        {
            this.musicalName = musicalName;
            this.theaterLocation = theaterLocation;
        }

        //Mutators and Accessors
        public string GetMusicalName() { return musicalName; }
        public void SetMusicalName(string musicalName) { this.musicalName = musicalName; }
        public string GetTheaterLocation() { return theaterLocation; }
        public void SetTheaterLocation(string theaterLocation) { this.theaterLocation = theaterLocation; }
    }
}
