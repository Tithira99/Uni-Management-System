using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class Course //Course class
    {
        private int cid;//identifier for records in course table
        private string cname;//name of the course which contains string type data
        private int prid;//program identification number which is a foreign key to the  course table


        public Course() //default constructor for course class
        {

        }

        public Course(int id) //parameterized constructor for course class with one parameter
        {
            this.cid = id;
        }

        public Course(int id, string name, int pid)//parameterized constructor for ourse class with 2 parameters
        {
            this.cid = id;
            this.cname = name;
            this.prid = pid;
        }

        public int getid()  //getter for course id
        {
            return this.cid;
        }

        public string getname() //getter for course name
        {
            return this.cname;
        }

        public int getpid() //getter for rogram id (Foreign Key)
        {
            return this.prid;
        }

        public void setid(int id)//setter for course id
        {
            this.cid = id;
        }

        public void setname(string name)//setter for course name
        {
            this.cname = name;
        }

        public void setpid(int pid) //setter for program id
        {
            this.prid = pid;
        }


    }
}
