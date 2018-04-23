//Cole Hemp
//Tickets.cs
//Parent, Abstract class for other ticket classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBSCTicketBooth
{
    public abstract class Tickets
    {
        private int quantity;
        private double cost;
        private string[] seatNumber;
        private DateTime date;
        private DateTime time;

        public Tickets()
        {
            //Defualt Constructor
        }

        public Tickets(int quantity, double cost, DateTime date)
        {
            this.quantity = quantity;
            this.cost = cost;
            seatNumber = new string[quantity];
            seatNumber = FillSeats(seatNumber);
            this.date = date;
        }

        //Mutators and Accessors
        public int GetQuantity() { return quantity; }
        public void SetQuantity(int quantity) { this.quantity = quantity; }
        public double GetCost() { return cost; }
        public void setCost(double cost) { this.cost = cost; }
        public DateTime GetDate() { return date; }
        public void SetDate(DateTime date) { this.date = date; }
        public string[] GetSeatNumber() { return seatNumber; }
        //Sets SeatNumber(s) with custom seat(s)
        public void SetSeatNumber(string[] seatNumber) { this.seatNumber = seatNumber; }
        //AutoGenerates SeatNumber(s)
        public void SetSeatNumber(int quantity)
        {
            seatNumber = new string[quantity];
            seatNumber = FillSeats(seatNumber);
        }



        private string[] FillSeats(string[] seatNumber)
        {
            for (int i = 0; i < seatNumber.Length; i++)
            {
                seatNumber[i] = GenerateSeatNumber();
                for (int j = 0; j < i; j++)
                {
                    if (i == 0)
                    {
                        //Do Nothing
                    }
                    //Checks if SeatNumber[i] doesn't conflict with other Seats
                    else if (seatNumber[i] == seatNumber[j])
                    {
                        seatNumber[i] = GenerateSeatNumber();
                        while (seatNumber[i] == seatNumber[0])
                        {
                            seatNumber[i] = GenerateSeatNumber();
                        }
                        j = 0;
                    }
                }
            }
            return seatNumber;
        }

        private string GenerateSeatNumber()
        {
            string seatNumber;
            char rowLetter;
            string rowNumber;

            Random random = new Random();

            rowLetter = Convert.ToChar(random.Next(1, 26));
            rowNumber = Convert.ToString(random.Next(1, 101));

            seatNumber = rowLetter + rowNumber;

            return seatNumber;
        }

       
    }
}
