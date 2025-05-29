using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class SupervisorDAO
    {
       Supervisor sup1;
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewsupervisor(Supervisor supobj)
        {
            try
            {
                string sql = "insert into supervisor(supervisorID, supervisorName,stitle,sofficeroom)values(" + supobj.getid() + ",'" + supobj.getname() + "', '" + supobj.gettitle() + "',                                                             '" + supobj.getofficeroom() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();
            }
        }

        public void deletesupervisorbyid(int id)
        {
            try
            {
                string sql = "delete from supervisor where supervisorid = " + id + "";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }


        }


        public void updatesupervisor(Supervisor supobj)
        {
            try
            {
                string sql = "update supervisor set supervisorname = ('" + supobj.getname() + "'), stitle= ('" + supobj.gettitle() + "'),sofficeroom = ('" + supobj.getofficeroom() + "')where supervisorid = ('" + supobj.getid() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }


        public Supervisor searchsupervisorbyid(int id)
        {
            try
            {
                string sql = "select * from supervisor where supervisorid = (" + id + ")";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();


                if (dreader.Read())
                {
                    sup1 = new Supervisor((int)dreader[0], dreader[1].ToString(), dreader[2].ToString(), dreader[3].ToString());
                }
                dreader.Close();

            }
            finally
            {
                m_con.Close();
            }
            return sup1;
        }

    }
}
