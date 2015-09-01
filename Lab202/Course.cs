using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        private string name;
        private string courseID;
        private string lecturer;
        private int maxStudent;
        private int numStudent;

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
              
                    if (value.Length > 6 )
                    {
                        

                        Console.WriteLine(courseID + ": error try setting invalid CourseID!");
                    }
                    else
                    {
                        int x=0;
                        for (int i = 0; i < value.Length;i++ )
                {
                    if (Char.IsDigit(value[i]))
                        x = 0;
                    else
                        x = 1;
                }
                        if(x==0)
                        courseID = value;
                        else
                        Console.WriteLine(courseID + ": error try setting invalid CourseID!");
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
        public int NumStudents
        {
            get
            {
                return numStudent;
            }
            set
            {
                if (value > maxStudent)
                {
                    Console.WriteLine(courseID + " error try setting invalid No. Students!");
                }
                else
                {
                    numStudent = value;
                }
            }
        }
        public int MaxStudents
        {
            get
            {
                return maxStudent;
            }
            set
            {
                if (value < numStudent)
                {
                    Console.WriteLine(courseID + ": error try setting invalid Max No. Students!");
                }
                else
                {
                    maxStudent = value;
                }
            }
        }
        public Course()
        {
            lecturer = "staff";
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string name, string courseID)
        {
            this.name = name;
            this.courseID = courseID;
            lecturer = "staff";
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string name, string courseID, string lecturer)
        {
            this.name = name;
            this.courseID = courseID;
            this.lecturer = lecturer;
            numStudent = 0;
            maxStudent = 30;
        }
        public Course(string name, string courseID, string lecturer, int maxStudent)
        {
            this.name = name;
            this.courseID = courseID;
            this.lecturer = lecturer;
            this.maxStudent = maxStudent;
            numStudent = 0;
        }

        public override string ToString()
        {
            return "[Course : " + name + " (" + courseID + "), Lecturer=" + lecturer + ", has " + numStudent + " students, max=" + maxStudent + "]";
        }
    }
}
