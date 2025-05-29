using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    class Lecturer_crs//Lecturer - course class
    {

        private int crsid;//course id
        private int lecid;//lecturer id

        public Lecturer_crs()//deafault constructor for lecturer - course class
        {

        }
        public Lecturer_crs(int cid, int lid)//Parameterized constructor for Lecturer - course class with 2 parameters
        {
            this.crsid = cid;
            this.lecid = lid;
        }

        public int getcid()//getter for course id
        {
            return this.crsid;
        }
        public int getlid()//getter for lecturer id
        {
            return this.lecid;
        }

        public void setcid(int cid)//setter for course id
        {
            this.crsid = cid;
        }

        public void setlid(int lid)//setter for lecturer id
        {
            this.lecid = lid;
        }
    }
}
