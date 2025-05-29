using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stafford_Uni_Management
{
    public class Supervisor
    {

        private int supid;
        private string supname;
        private string suptitle;
        private string supofficeroom;

        public Supervisor()
        {

        }

        public Supervisor(int id)
        {
            this.supid = id;
        }

        public Supervisor(int id, string name, string dob, string officeroom)
        {
            this.supid = id;
            this.supname = name;
            this.suptitle = dob;
            this.supofficeroom = officeroom;
        }

        public int getid()
        {
            return this.supid;
        }

        public string getname()
        {
            return this.supname;
        }

        public string gettitle()
        {
            return this.suptitle;
        }

        public string getofficeroom()
        {
            return this.supofficeroom;
        }

        public void setid(int id)
        {
            this.supid = id;
        }

        public void setname(string name)
        {
            this.supname = name;
        }

        public void settitle(string title)
        {
            this.suptitle = title;
        }

        public void setofficeroom(string officeroom)
        {
            this.supofficeroom = officeroom;
        }
    }
}
