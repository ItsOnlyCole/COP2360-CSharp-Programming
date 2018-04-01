using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMessageBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string result = " \tNumber \tNumber^2\n";

            while(counter < 10)
            {
                counter++;
                //Use of += to build string for MessageBox
                result += " \t" + counter + " \t" + Math.Pow(counter, 2) + "\n";
            }
            MessageBox.Show(result, "1 through 10 and their squares");
        }
    }
}
