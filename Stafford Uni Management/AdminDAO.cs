using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class AdminDAO//the database which is created with sql is implemented in this class.
    {
        Admin ad1;//object created from the Admin class
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";//the database path is assigned to a static string since it doesnt change afterwards
        SqlConnection m_con = new SqlConnection(con);//using inbuilt libaries, the static string is created into a path with can grant access to the database presented

        public void insertnewadmin(Admin aobj)
        {
            try
            {
                //set of instruction are executed accordingly to excute the sql code writen by accessing the path way and changing string into sql code
                string sql = "insert into Admin(adminid, adminname)values('" + aobj.getadid() + "','" + aobj.getadname() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {//closing the open pathway to the database since its purpose ending in this state
                m_con.Close();
            }
        }

        public void deleteadmin(string adid)
        {
            try
            {
                //set of instruction are executed accordingly to excute the sql code writen by accessing the path way and changing string into sql code
                string sql = "delete from Admin where adminid = '" + adid + "' ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //closing the open pathway to the database since its purpose ending in this state
                m_con.Close();
            }

        }

        public void updateadmin(Admin aobj)
        {
            try
            {
                //set of instruction are executed accordingly to excute the sql code writen by accessing the path way and changing string into sql code
                string sql = "Update admin set adminname = ('" + aobj.getadname() + "') where adminid = ('" + aobj.getadid() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //closing the opened pathway to the database since it's purpose enda in this state.
                m_con.Close();
            }
        }

        public Admin searchadminbyid(string adid)
        {
            try
            {
                //set of instruction are executed accordingly to excute the sql code writen by accessing the path way and changing string into sql code
                string sql = "select * from admin where  adminid = '" + adid + "'";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();

                if (dreader.Read())
                {
                    //Reading the data in the sql table , considering data as an array and getting it to an admin object
                    ad1 = new Admin(dreader[0].ToString(), dreader[1].ToString());
                }
                dreader.Close();


            }
            finally
            {
                //Closing the opened  path way to   database since it's purpose ends here
                m_con.Close();
            }
            return ad1;//returning the admin object which contains the values of data read from the database
        }

    }
}
