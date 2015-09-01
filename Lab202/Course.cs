using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string name;
        private string courseID;
        private string lecturer;
        private int maxStudents;
        private int numStudents;

        public Course()
        {
            name = "Unnowk";
            courseID = "Unnowk";
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string _name, string _Courseid)
        {
            name = _name;
            courseID = _Courseid;
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string _name, string _Courseid, string _Lecturer)
        {
            name = _name;
            courseID = _Courseid;
            lecturer = _Lecturer;
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string _name, string _Courseid, string _Lecturer, int _Maxstudent)
        {
            name = _name;
            courseID = _Courseid;
            lecturer = _Lecturer;
            maxStudents = _Maxstudent;
            numStudents = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string CourseID
        {

            get
            {
                return courseID;
            }

            set
            {
                int snum;
                bool isNumeric = int.TryParse(value, out snum);

                if (value.Length == 6 && isNumeric)
                {
                    courseID = value;
                }

                else
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                }
            }
        }

        public string Lecturer
        {
            get
            {
                return lecturer;
            }

            set
            {
                lecturer = value;
            }
        }


        public int MaxStudents
        {
            get { return maxStudents; }
            set
            {
                if (value >= 0 && value <= 80 && value >= NumStudents)
                {
                    maxStudents = value;

                }
                else
                {

                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", CourseID);


                }

            }
        }
        public int NumStudents
        {
            get
            {
                return numStudents;
            }

            set
            {
                if (value <= maxStudents && value >= 0)
                {
                    numStudents = value;

                }
                else
                {
                    Console.WriteLine(courseID + ": error try setting invalid No. Students!");
                }

            }
        }
        public override string ToString()
        {
           

            return string.Format("[Course : {0} ({1}),Lecturer={2},has {3},students,max ={4}]", name, courseID, lecturer, numStudents, MaxStudents);


        }
    }

}
