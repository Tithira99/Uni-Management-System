using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class Works_on
    {
        private int stdntid;
        private int crsid;
        private string exdate;
        private int exid;
        private string sgrade;
        private int lecid;


        public Works_on()
        {

        }

        public Works_on(int sid, int cid, string edate,int eid )
        {
            this.stdntid = sid;
            this.crsid = cid;
            this.exdate = edate;
            this.exid = eid;
        }

        public Works_on(int sid, int cid, string edate, int eid, string grade, int lid)
        {
            this.stdntid = sid;
            this.crsid = cid;
            this.exdate = edate;
            this.exid = eid;
            this.sgrade = grade;
            this.lecid = lid;
        }

        public int getsid()
        {
            return this.stdntid;
        }

        public int getcid()
        {
            return this.crsid;
        }

        public string getedate()
        {
            return this.exdate;
        }

        public int geteid()
        {
            return this.exid;
        }

        public string getgrade()
        {
            return this.sgrade;
        }

        public int getlid()
        {
            return this.lecid;
        }

        public void setsid(int sid)
        {
            this.stdntid = sid;
        }

        public void setcid(int cid)
        {
            this.crsid = cid;
        }

        public void setedate(string edate)
        {
            this.exdate = edate;
        }

        public void seteid(int eid)
        {
            this.exid = eid;
        }

        public void setgrade(string grade)
        {
            this.sgrade = grade;
        }

        public void setlid(int lid)
        {
            this.lecid = lid;
        }
    }

    
}
