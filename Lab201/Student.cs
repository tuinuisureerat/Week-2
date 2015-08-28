using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    { 
        public string Namestudent;
        public String StudentID;
        private int _YearOfBirth;
        public bool isActive;

        public int Yearofbirth
        {
            get
            {
                return _YearOfBirth;
            }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    Yearofbirth = value;

                }
                else
                {
                    Console.WriteLine("{0} error try setting invalid year-of-birth value!",StudentID);
                }

            }
               

          }


        public Student()
        {
            Namestudent = "";
            StudentID = "";
            _YearOfBirth = 0;
            isActive = false;
        }

        public Student(string name,string id)
        {
            Namestudent = name;
            StudentID = id;
            _YearOfBirth=1995;
            isActive=true;

        }

        public Student(string name, string id,int bfo)
        {
            Namestudent = name;
            StudentID = id;
            _YearOfBirth = bfo;
            isActive =true;
        }

        public Student(string name, string id, int bfo, bool ui)
        {
            Namestudent =name;
            StudentID =id;
            _YearOfBirth = bfo;
            isActive =true;

        }

        public int getAge()
        {
            return  DateTime.Now.Year - _YearOfBirth;
        }

       


        public override string ToString()
        {
            string a;
            if (isActive == true)
            {
                a = "is active ";

            }
            else
            {

                a = "is NOT active student";

            }
           

            return string.Format("[Student: {0} ({1}), age={2}, {3},{4}]", Namestudent, StudentID, getAge(), _YearOfBirth, a);
          
        }








    }
}
