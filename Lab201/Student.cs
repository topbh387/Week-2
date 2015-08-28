using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {

        private string name;
        private string student_id;
        private int year_of_birth;
        private bool status;
        private int _age=0;
        public Student()
        {
            name = "John Doe";
            year_of_birth = 1995;
            status = false;
            student_id = "Unknown";
        }
        public Student(string name, string student_id)
        {

            this.name = name;
            this.student_id = student_id;

            year_of_birth = 1995;
            status = true;
        }
        public Student(string name, string student_id, int year_of_birth)
        {

            this.name = name;
            this.student_id = student_id;
            this.year_of_birth = year_of_birth;
            status = true;
        }
        public Student(string name, string student_id, int year_of_birth, bool status)
        {

            this.name = name;
            this.student_id = student_id;
            this.year_of_birth = year_of_birth;
            this.status = status;
        }
        public string Name
        {
            get 
        { return name; }
            set
            {
                name = value;
            }
        }
        public int YearOfBirth
        {
            get { 
            
           
            
                return year_of_birth;
            }
            set
            {
                int x = year_of_birth;
                year_of_birth = value;
                if (year_of_birth >= 1950 && year_of_birth <= 2000)
                {
                    year_of_birth = value;
                }
                else
                {

                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", this.student_id);

                    year_of_birth = x;
                }
            }
        }
        public bool isActive
        {
            get { 
                
        
                return status; }
            set
            {
                status = true;
            }
        }
        public int Age
        {

            get
            {
                int todayyears = DateTime.Now.Year;
                _age = todayyears - YearOfBirth;


                return _age;
            }
/*            set
            {
                int todayyears = DateTime.Now.Year;
                _age = todayyears - YearOfBirth;
                _age = value;

            }*/
        }
        public override string ToString()
        {
            //  Student: s2(57002), age = 21, is active student
            string x;
            if (status == true)
                x = "is";
            else
            {
                x = "is NOT";
            }
            return "Student : " + Name + "(" + student_id + ")" + ", Age = " + Age + ",  " + x + " active Stdent";
        }
    }
}
