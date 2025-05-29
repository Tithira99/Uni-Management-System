using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class Faculty//Faculty Class
    {
        private int facid;//identifier for the faculty records
        private string facname;//Faculty name
        private string facdean;//Dean of the faculty
        private string facbuilding;//Faculty Building 

        public Faculty()//Default constructor for faculty
        {

        }

        public Faculty(int id)//parameterized constructor for faculty with one parameter
        {
            this.facid = id;
        }

        public Faculty(int id, string name, string dean, string building)//parameterized constructor for faculty which contains 4 parameters
        {
            this.facid = id;
            this.facname = name;
            this.facdean = dean;
            this.facbuilding = building;
        }

        public int getid()//getter for the faculty id
        {
            return this.facid;
        }

        public string  getname()//getter for the faculty name
        {
            return this.facname;
        }

        public string getdean()//getter for the name of the dean
        {
            return this.facdean;
        }

        public string getbuilding()//getter for the faculty building
        {
            return this.facbuilding;

        }

        public void setid(int id)//setter for the faculty id
        {
            this.facid = id;
        }
        public void setname(string name)//setter for the faculty name
        {
            this.facname = name;
        }

        public void setdean(string name)//setter for the dean
        {
            this.facname = name;
        }

        public void setbuilding(string building)//setter for the faculty building
        {
            this.facbuilding = building;
        }


    }
}
