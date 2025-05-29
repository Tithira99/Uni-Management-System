using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class LecturerDAO
    {
        
        Lecturer lec1;//new object from lecturer class
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";//sql string for database connection
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewlecturer(Lecturer lobj)//method to insert records
        {
            try
            {
                string sql = "insert into lecturer (lid, lName,ltitle,lofficeroom, supid)values(" + lobj.getid() + ",'" + lobj.getname() + "', '" + lobj.gettitle() + "', '" + lobj.getoffice() + "', "+ lobj.getspid()+")";
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command for database connection
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }

        public void deletelecturerbyid(int id)//Method to delete records
        {
            try
            {
                string sql = "delete from lecturer where lid = " + id + "";//sql qury to delete records
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to delete records from the table in database
                m_con.Open();//openning the pathway to to the daabase
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }


        }


        public void updatelecturer(Lecturer lobj)//method to update records from the database
        {
            try
            {
                string sql = "update lecturer set lname = ('" + lobj.getname() + "'), ltitle = ('" + lobj.gettitle() + "'),lofficeroom = ('" + lobj.getoffice() + "'), supid = ("+ lobj.getspid()+") where lid = (" + lobj.getid() + ")";//sql query to update records
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to update records of the database table
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the databse
            }
        }


        public Lecturer searchlecturerbyid(int id)//method to search records from the database according to the recordID
        {
            try
            {
                string sql = "select * from Lecturer where lid = (" + id + ")";//sql query to search records from the daabase table
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to search record from the databse
                m_con.Open();//openning the pathway to the database
                SqlDataReader dreader = cmd.ExecuteReader();//new data reader object


                if (dreader.Read())
                {
                    lec1 = new Lecturer((int)dreader[0], dreader[1].ToString(), dreader[2].ToString(), dreader[3].ToString(),(int)dreader[4]);//data that have been read by the data reader is assigned to a lecturer object
                }
                dreader.Close();//closing the data reader

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
            return lec1;//returning the lecturer object with the values read by the data reader



        }

       
        
    }
}
