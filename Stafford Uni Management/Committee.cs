using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class Committee
    {
        private int comid;
        private string comname;
        private int facid;


        public Committee()
        {

        }

        public Committee(int id)
        {
            this.comid = id;
        }

        public Committee(int id, string name, int fid)
        {
            this.comid = id;
            this.comname = name;
            this.facid = fid;
        }

        public int getid()
        {
            return this.comid;
        }

        public string getname()
        {
            return this.comname;
        }

        public int getfid()
        {
            return this.facid;
        }

        public void setid(int id)
        {
            this.comid = id;
        }

        public void setname(string name)
        {
            this.comname = name;
        }

        public void setfid(int fid)
        {
            this.facid = fid;
        }

        
    }
}
