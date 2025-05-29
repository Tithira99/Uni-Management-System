using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class Com_lecDAO//the database which is created with sql is implemented in this class.
    {
       
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql"; //static string written to the database
        SqlConnection m_con = new SqlConnection(con);//Connection string 

        public void insertnewcomlec(Com_lec clobj) //method which contains instructions to insert data to the table
        {
            try
            {
                string sql = "insert into Committee_lec(comid, lecid2)values(" + clobj.getcid() + "," + clobj.getlid() + ")"; //sql query used to insert data
                SqlCommand cmd = new SqlCommand(sql, m_con); //sql command to connect with database
                m_con.Open(); //openning the  pathway to database
                cmd.ExecuteNonQuery(); 

            }
            finally
            {
                m_con.Close(); //closing the  pathway to database
            }
        }

        public void deletecomlec(int cid, int lid) //method which includes instructions to delete records from the table 
        {
            try
            {
                string sql = "delete from committee_lec where comid = " + cid + " and lecid2 = " + lid + " "; //sql query used to delete records form the database
                SqlCommand cmd = new SqlCommand(sql, m_con); //sql command used to connect to the database
                m_con.Open(); //openning the pathway to database  
                cmd.ExecuteNonQuery(); 
            }
            finally
            {
                m_con.Close(); //closing the pathway to database
            }


        }





        
    }
}
