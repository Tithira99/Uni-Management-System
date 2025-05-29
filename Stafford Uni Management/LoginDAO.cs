using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class LoginDAO//manager class for login registration
    {
        Login log1;//new login class object
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";//sql string for the database connectin
        SqlConnection m_con = new SqlConnection(con);//sql connection to the database

        public void insertnewlogin(Login lobj)//method to insert a new record to the table
        {
            try
            {
                string sql = "insert into Login(password, username, adid)values('" + lobj.getpswrd() + "','" + lobj.getusrnm() + "', '"+ lobj.getaid()+"')";//query to insert a new record to the table
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathwayto the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }

        public void deletelogin( string usrnm)//method to delete records from the database
        {
            try
            {
                string sql = "delete from Login where username = " + usrnm + " ";//sql query to delete a record from the table 
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathwayto the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }

        }

        public void updatelogin(Login lobj)///method to update records from the database
        {
            try
            {
                string sql = "Update login set password = ('" + lobj.getpswrd() + "'),adid = ('"+lobj.getaid()+"') where username = ('" + lobj.getusrnm() + "')";// method to update  records from the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathwayto the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }

        public Login searchloginbyusrname(string usrnm)//method to search records from the database
        {
            try
            {
                string sql = "select * from Login where  username = '" + usrnm + "'";//sql query to search records from the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to search records
                m_con.Open();// openning the pathwayto the database
                SqlDataReader dreader = cmd.ExecuteReader();

                if (dreader.Read())
                {
                    log1 = new Login(dreader[0].ToString(), dreader[1].ToString(), dreader[2].ToString());//reading data from the database and assigning them to an object from the related class
                }
                dreader.Close();//closing dreader


            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
            return log1;//returnning the data read as an login object
        }

      
    }
}
