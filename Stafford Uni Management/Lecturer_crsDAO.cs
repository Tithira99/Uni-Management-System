using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class Lecturer_crsDAO//Manager class for the Lecturer Table
    {

        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";//sql string for database connection
        SqlConnection m_con = new SqlConnection(con);//sql connection string to the database

        public void insertnewlectocrs(Lecturer_crs lcobj)// method forinserting records to lecturer - course class 
        {
            try
            {
                string sql = "insert into Lecturer_course(cid2, lecid)values(" + lcobj.getcid() + "," + lcobj.getlid() + ")";//sql query to insert a new record to the lecturer - course class
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command for database connection
                m_con.Open();//openning tha pathway to the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }

        public void deletelecincrs(int cid, int lid)
        {
            try
            {
                string sql = "delete from lecturer_course where cid2 = " + cid + " and lecid = " + lid + " ";//sql query to delete a record from the database table.
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command for database connection
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }

        }
    }
}
