//Cole Hemp
//BasketballTickets.cs
//Ticket Class for home basketball games

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSCTicketBooth
{
    class BasketballTickets : Tickets
    {
        private string opposingTeam;

        public BasketballTickets()
            : base()
        {
            //Default Constructor
        }

        public BasketballTickets(string opposingTeam, int quantity, double cost, DateTime date, DateTime time)
            : base(quantity, cost, date, time)
        {
            this.opposingTeam = opposingTeam;
        }

        //Mutators and Accessors
        public string GetOpposingTeam() { return opposingTeam; }
        public void SetOpposingTeam(string opposingTeam) { this.opposingTeam = opposingTeam; }
    }
}
