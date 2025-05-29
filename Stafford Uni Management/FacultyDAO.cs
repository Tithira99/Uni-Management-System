using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class FacultyDAO//Manager class for the Faculty table
    {

        Faculty fac1;
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewfaculty(Faculty fobj)//Method to insert data to the faculty table
        {
            try
            {
                string sql = "insert into Faculty(facultyID, facultyName,dean, building)values(" + fobj.getid() + ",'" + fobj.getname() + "', '" + fobj.getdean() + "', '" + fobj.getbuilding() + "')";//sql query to insert data to the faculty table
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//Openning the pathway to the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//Closing the pathway to the database
            }
        }

        public void deletefacultybyid(int id)//method to delete records from the database
        {
            try
            {
                string sql = "delete from faculty where facultyid = " + id + "";//sql query to delete records from the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//Openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//Closing the pathway to the database
            }


        }


        public void updatefaculty(Faculty fobj)//Method to update data from the database
        {
            try
            {
                string sql = "update Faculty set facultyname = ('" + fobj.getname() + "'), dean = ('" + fobj.getdean() + "'),building = ('" + fobj.getbuilding() + "')where facultyid = ('" + fobj.getid() + "')";//sql query to update data from the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }


        public Faculty searchfacultybyid(int id)//Method to search records from the database according to the id
        {
            try
            {
                string sql = "select * from faculty where facultyid = (" + id + ")";//sql qury to search data fro m the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the  database.
                m_con.Open();//Openning the pathway to the database
                SqlDataReader dreader = cmd.ExecuteReader();//creaeting a data reader object


                if (dreader.Read())
                {
                    fac1 = new Faculty((int)dreader[0], dreader[1].ToString(), dreader[2].ToString(), dreader[3].ToString());//aasigning the the data read from the database table to a facullty object
                }
                dreader.Close();//closing the data reader 

            }
            finally
            {
                m_con.Close();//Closing the pathway to the database
            }
            return fac1;//returning the faculty object which contains values read from the database table.
        }

    }
}
