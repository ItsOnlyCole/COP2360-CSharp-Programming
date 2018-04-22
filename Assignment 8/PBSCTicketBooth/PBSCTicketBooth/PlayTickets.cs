//Cole Hemp
//PlayTickets.cs
//Ticket class for plays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSCTicketBooth
{
    class PlayTickets : Tickets
    {
        string playName;
        string theaterLocation;

        public PlayTickets()
            : base()
        {
            //default constructor
        }

        public PlayTickets(string playName, string theaterLocation, int quantity, double cost, DateTime date, DateTime time)
            : base(quantity, cost, date, time)
        {
            this.playName = playName;
            this.theaterLocation = theaterLocation;
        }

        //Mutators and Accessors
        public string GetPlayName() { return playName; }
        public void SetPlayName(string playName) { this.playName = playName; }
        public string GetTheaterLocation() { return theaterLocation; }
        public void SetTheaterLocation(string theaterLocation) { this.theaterLocation = theaterLocation; }
    }
}
