using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Student
    {
        private string studentFirstName;
        private string studentLastName;
        private int studentNumber;
        internal string major;

        //properties
        //Properties need to be capitalized while the variables it uses is lowercase (Camalcase)
        public string StudentFirstName { get; set; } = "Raymond";
        private int score1
        {
            get
            {
                return score1;
            }
            set
            {
                score1 = value;
            }
        }

        private int score2
        {
            get
            {
                return score2;
            }
            set
            {
                score2 = value;
            }
        }

        private int score3
        {
            get
            {
                return score3;
            }
            set
            {
                score3 = value;
            }
        }


        public Student()
        {

        }

        public Student(int sID)
        {

        }

        public void setStudentFirstName(string name)
        {
            studentFirstName = name;
        }

        public string getStudentFirstName()
        {
            return studentFirstName;
        }

        public void setMajor(string major)
        {
            this.major = major;
        }

        public string getMajor()
        {
            return major;
        }

        public override string ToString()
        {
            return studentFirstName + "\n"
                    +major;
        }
    }
}
