using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class CourseDAO //Manager class for Course 
    {
        Course c1;//Creating a course object c1
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";///Connection string to the database
        SqlConnection m_con = new SqlConnection(con); //database connection

        public void insertnewcourse(Course cobj)//method to insert records to the database table
        {
            try
            {
                string sql = "insert into cours (courseID, courseName,pid)values(" + cobj.getid() + ",'" + cobj.getname() + "', '" + cobj.getpid() + "')"; //sql query to insert data to the table
                SqlCommand cmd = new SqlCommand(sql, m_con); //sql command to connect to the database

                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }

        public void deletecoursebyid(int id) //Method to delete records from the database table
        {
            try
            {
                string sql = "delete from Course where courseid = " + id + "";//sql query to delete records from the table
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//Closing the pathway to database
            }


        }


        public void updatecourse(Course cobj)//method to update data from the database table 
        {
            try
            {
                string sql = "update course set coursename = ('" + cobj.getname() + "'), pid = (" + cobj.getpid() + ") where courseid = (" + cobj.getid() + ")";//sql query to delete data from the database table
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }


        public Course searchcoursebyid(int id)// method to search records from the database
        {
            try
            {
                string sql = "select * from course where courseid = (" + id + ")";//sql query to display all records according to the given id
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database
                SqlDataReader dreader = cmd.ExecuteReader();//making a datareader object


                if (dreader.Read())
                {
                    c1 = new Course((int)dreader[0], dreader[1].ToString(), (int)dreader[2]);//data which has been read is assign to an object og course class "c1" 


                }
                dreader.Close();//Closing datareader object dreader

            }
            finally
            {
                m_con.Close();//Closing the pathway to the database
            }
            return c1;//returning the course object "c1"  which contains the data values of the record read.
        }

    }
}
