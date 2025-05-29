using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class Lecturer//Lecturer class 
    {
        private int lid;//Identifier for a lecturer record
        private string lname;//Lecturer name
        private string ltitle;//Lecturer title 
        private string loffice;//Lecturer office
        private int supid;//Supervisor id which is a foreign key references supervisor table


        public Lecturer()//Default constructor for lecturer
        {

        }
        public Lecturer(int id)//parameterized constructor for Lecturer with one parameter
        {
            this.lid = id;
        }
        public Lecturer(int id, string name, string title, string office, int spid)//parameterized constructor for Lecturer with 5 parameters
        {
            this.lid = id;
            this.lname = name;
            this.ltitle = title;
            this.loffice = office;
            this.supid = spid;
        }

        public int getid()//getter for the lecturer id
        {
            return this.lid;
        }

        public string getname()//getter for the lecturer name
        {
            return this.lname;
        }

        public string gettitle()//getter for the lecturer title 
        {
            return this.ltitle;
        }

        public string getoffice()//getter for the lecturer ofiice
        {
            return this.loffice;
        }

        public int getspid()//getter for the supervisor id
        {
            return this.supid;
        }

        public void setid(int id)//setter for the Lecturer id
        {
            this.lid = id;
        }

        public void setname(string name)//setter for the Lecturer Name 
        {
            this.lname = name;
        }

        public void settitle(string title)//setter for the lecturer title
        {
            this.ltitle = title;
        }

        public void setoffice(string office)//setter for the lecturer office
        {
            this.loffice = office;
        }
        public void setspid(int spid)//stter for the supervisor id 
        {
            this.supid = spid;
        }


    }
}
