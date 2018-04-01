using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Cole Hemp
//Form1.cs
//Contains all the events that can be activated in form1

namespace Assignment7_Calculator
{
    public partial class CalculatorForm : Form
    {
        private int value1;
        private int value2;
        private int results;
        private string error = "Values must be numeric and > 0.";


        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Clears all values on click
            Value1TextBox.Text = "";
            Value2TextBox.Text = "";
            Output.Text = "";
            value1 = 0;
            value2 = 0;
            results = 0;
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Value1TextBox.Text, out value1) == false|| int.TryParse(Value2TextBox.Text, out value2) == false)
            {
                Output.ForeColor = Color.Red;
                Output.Location = new Point(41, 323);
                Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Output.Text = error;
            }
            else if (value1 < 1 || value2 < 1)
            {
                Output.ForeColor = Color.Red;
                Output.Location = new Point(41, 323);
                Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Output.Text = error;
            }
            else
            {
                results = value1 + value2;
                Output.ForeColor = Color.Yellow;
                Output.BackColor = Color.Black;
                Output.Location = new Point(158, 323);
                Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Output.Text = Convert.ToString(results);
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Value1TextBox.Text, out value1) == false && value1 < 1 || int.TryParse(Value2TextBox.Text, out value2) == false && value2 < 1)
            {
                Output.ForeColor = Color.Red;
                Output.Location = new Point(41, 323);
                Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Output.Text = error;
            }
            else if (value1 < 1 || value2 < 1)
            {
                Output.ForeColor = Color.Red;
                Output.Location = new Point(41, 323);
                Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Output.Text = error;
            }
            else
            {
                results = value1 * value2;
                Output.ForeColor = Color.Yellow;
                Output.BackColor = Color.Black;
                Output.Location = new Point(158, 323);
                Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Output.Text = Convert.ToString(results);
            }
        }
    }
}
