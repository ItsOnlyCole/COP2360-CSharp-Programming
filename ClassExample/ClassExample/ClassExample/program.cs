using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class program
    {
        static void Main(string[] args)
        {
            //This is a test to prove if you need the namespace before a constructor which it doesn't
            int testID = 1234;
            Student testStudent = new Student();

            //testStudent.StudentFirstName = "Cole";
            testStudent.setMajor("Software Engineering");

            System.Console.WriteLine(testStudent.StudentFirstName);
            System.Console.Write(testStudent.major);
            System.Console.Write("\n\n\n" + testStudent.ToString());

            System.Console.ReadKey();
        }
    }
}
