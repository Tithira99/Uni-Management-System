using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class Student//Student class
    {
        private int sid;//Student id
        private string sname;//Student name
        private string sdob;//student date of borth
        private string syenrolled;//student's year enrolled

        public Student()//default constructor for student class
        {

        }

        public Student(int id)//parameterized constructor with one parameter
        {
            this.sid = id;
        }

        public Student(int id, string name, string dob, string yenrolled)//student constructor with 4 parameters
        {
            this.sid = id;
            this.sname = name;
            this.sdob = dob;
            this.syenrolled = yenrolled;
        }

        public int getid()//getter for the student id
        {
            return this.sid;
        }

        public string getname()//getter for the student name
        {
            return this.sname;
        }

        public string getdob()//getter for the student's date of birth
        {
            return this.sdob;
        }

        public string getyenrolled()//getter for the student's year enrolled 
        {
            return this.syenrolled;
        }

        public void setid(int id)//setter for the student id 
        {
            this.sid = id;
        }


        public void setname(string name)//setter for the student name
        {
            this.sname = name;
        }

        public void setdob(string dob)//getter for the student's date of birth
        {
            this.sdob = dob;
        }

        public void setyenrolled(string yenrolled)//getter for the student's year enrolled 
        {
            this.syenrolled = yenrolled;
        }

    }
}
