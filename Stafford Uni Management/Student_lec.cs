using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public  class Student_lec
    {
        private int stdid;
        private int lecid;

        public Student_lec()
        {

        }
        public Student_lec(int sid, int lid)
        {
            this.stdid = sid;
            this.lecid = lid;
        }

        public int getsid()
        {
            return this.stdid;
        }
        public int getlid()
        {
            return this.lecid;
        }

        public void setsid(int sid)
        {
            this.stdid = sid;
        }

        public void setlid(int lid)
        {
            this.lecid = lid;
        }
    }
}
