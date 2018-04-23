//Cole Hemp
//Form1.cs
//Class to handle events for Form1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBSCTicketBooth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //basketballMinusTicketButton_click
            //Event was made prior to rename
            if(Convert.ToInt16(basketballTicketsTextBox.Text) == 0)
            {
                //Does nothing and keeps the ticket count at 0
            }
            else
            {
                basketballTicketsTextBox.Text = Convert.ToString(Convert.ToInt16(basketballTicketsTextBox.Text) - 1);
                basketballTicketCostLabel.Text = Convert.ToString(Convert.ToDouble(basketballTicketCostLabel.Text) - 5.00);
            }
        }

        private void basketballPlusTicketsButton_Click(object sender, EventArgs e)
        {
            basketballTicketsTextBox.Text = Convert.ToString(Convert.ToInt16(basketballTicketsTextBox.Text) + 1);
            basketballTicketCostLabel.Text = Convert.ToString(Convert.ToDouble(basketballTicketCostLabel.Text) + 5.00);
        }

        private void musicalMinusTicketsButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(musicalTicketsTextBox.Text) == 0)
            {
                //Does nothing and keeps the ticket count at 0
            }
            else
            {
                musicalTicketsTextBox.Text = Convert.ToString(Convert.ToInt16(musicalTicketsTextBox.Text) - 1);
                musicalTicketCostLabel.Text = Convert.ToString(Convert.ToDouble(musicalTicketCostLabel.Text) - 8.00);
            }
        }

        private void musicalPlusTicketsButton_Click(object sender, EventArgs e)
        {
            musicalTicketsTextBox.Text = Convert.ToString(Convert.ToInt16(musicalTicketsTextBox.Text) + 1);
            musicalTicketCostLabel.Text = Convert.ToString(Convert.ToDouble(musicalTicketCostLabel.Text) + 8.00);
        }

        private void playMinusTicketsButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(playTicketsTextBox.Text) == 0)
            {
                //Does nothing and keeps the ticket count at 0
            }
            else
            {
                playTicketsTextBox.Text = Convert.ToString(Convert.ToInt16(playTicketsTextBox.Text) - 1);
                playTicketCostLabel.Text = Convert.ToString(Convert.ToDouble(playTicketCostLabel.Text) - 4.00);
            }
        }

        private void playPlusTicketsButton_Click(object sender, EventArgs e)
        {
            playTicketsTextBox.Text = Convert.ToString(Convert.ToInt16(playTicketsTextBox.Text) + 1);
            playTicketCostLabel.Text = Convert.ToString(Convert.ToDouble(playTicketCostLabel.Text) + 4.00);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            string recipt = "";
            double finalCost = 0;

            if(Convert.ToInt16(basketballTicketsTextBox.Text) == 0)
            {
                //Do Nothing
            }
            else
            {
                BasketballTickets bBallTickets = new BasketballTickets(basketballOpposingTeamLabel.Text, Convert.ToInt16(basketballTicketsTextBox.Text), Convert.ToDouble(basketballTicketCostLabel.Text), Convert.ToDateTime(basketballDateLabel.Text));
                recipt += Convert.ToString(bBallTickets.GetQuantity()) + " Ticket(s) for basketball game against " + bBallTickets.GetOpposingTeam() + ".\n\tGame starts at " + Convert.ToString(bBallTickets.GetDate()) +"\n\n";
                finalCost += bBallTickets.GetCost();
            }

            if(Convert.ToInt16(musicalTicketsTextBox.Text) == 0)
            {
                //Do Nothing
            }
            else
            {
                MusicalTickets musicalTickets = new MusicalTickets(musicalNameLabel.Text, musicalTheaterLabel.Text, Convert.ToInt16(musicalTicketsTextBox.Text), Convert.ToDouble(musicalTicketCostLabel.Text), Convert.ToDateTime(musicalDateLabel.Text));
                recipt += Convert.ToString(musicalTickets.GetQuantity()) + " Ticket(s) for " + musicalTickets.GetMusicalName() + " at " + musicalTickets.GetTheaterLocation() + " Theater.\n\tShow Starts " + Convert.ToString(musicalTickets.GetDate() + "\n\n");
                finalCost += musicalTickets.GetCost();
            }

            if(Convert.ToInt16(playTicketsTextBox.Text) == 0)
            {
                //Do Nothing
            }
            else
            {
                PlayTickets playTickets = new PlayTickets(playNameLabel.Text, playTheaterLabel.Text, Convert.ToInt16(playTicketsTextBox.Text), Convert.ToDouble(playTicketCostLabel.Text), Convert.ToDateTime(playDateLabel.Text));
                recipt += Convert.ToString(playTickets.GetQuantity() + " Ticket(s) for " + playTickets.GetPlayName() + " at " + playTickets.GetTheaterLocation() + " Theater.\n\tShow Starts " + Convert.ToString(playTickets.GetDate()) + "\n\n");
                finalCost += playTickets.GetCost();
            }

            MessageBox.Show(recipt + "Total Cost: $" + Convert.ToString(finalCost));
        }
    }
}
