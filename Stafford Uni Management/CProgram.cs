
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class CProgram//Program Class
    {
        private int pid;//identifier for records in program class
        private string ptitle;//program title
        private string plevel;//Program level
        private string pduration;//program duration
        private int facid;//faculty id which is a foregn key references faculty table


        public CProgram()//defalt constructor for program class
        {

        }
        public CProgram(int id)//parameterized constructor for program class which contains one parameter
        {
            this.pid = id;
        }
        public CProgram(int id, string title, string level , string duration, int fid)//parameterized constructor for program class which contains 5 parameters
        {
            this.pid = id;
            this.ptitle = title;
            this.plevel = level;
            this.pduration = duration;
            this.facid = fid;
        }

        public int getid()//getter for program id
        {
            return this.pid;
        }

        public string gettitle()//getter for program title
        {
            return this.ptitle;
        }

        public string getlevel()
        {
            return this.plevel;
        }

        public string getduration()//getter for program duration
        {
            return this.pduration;
        }

        public int getfid()//getter for faculty id
        {
            return this.facid;
        }

        public void setid(int id)//setter for program id
        {
            this.pid = id;
        }

        public void settitle(string title)//setter for program title
        {
            this.ptitle = title;
        }

        public void setlevel(string level)//setter for program level
        {
            this.plevel = level;
        }

        public void setduration(string duration)//seter for program level
        {
            this.pduration = duration;
        }
        public void setfid(int fid)//setter for faculty id
        {
            this.facid = fid;
        }
    }
}
