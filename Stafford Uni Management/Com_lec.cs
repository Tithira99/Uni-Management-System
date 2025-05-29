using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class Com_lec
    {
        private int comid;//committee identification number
        private int lecid; //lecturer identification number 

        public Com_lec()//initialization of default constructor
        {

        }
        public Com_lec(int cid, int lid)//initialization of parameterized constructor
        {
            this.comid = cid;
            this.lecid = lid;
        }

        public int getcid()//getter for committeeid
        {
            return this.comid;
        }
        public int getlid() //getter for lecturerid
        {
            return this.lecid;
        }

        public void setcid(int cid) //setter for committee id
        {
            this.comid = cid;
        }

        public void setlid(int lid) //setter for lecturerid
        {
            this.lecid = lid;
        }
    }
}
