using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopAddEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 3; number < 91; number += 11)
            {
                Console.WriteLine(number);
            }
            System.Console.ReadKey();
        }
    }
}
