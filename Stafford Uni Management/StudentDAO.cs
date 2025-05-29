using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Stafford_Uni_Management
{
    class StudentDAO
    {
        Student std1;//object from the student class
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";//sql connection string for the Database Tithi
        SqlConnection m_con = new SqlConnection(con);//sql connection
        
        public void insertnewstudent(Student sobj)//method to insert new records to the student table in the database
        {
            try
            {
                string sql = "insert into Student(StudentID, StudentName,DateofBirth,YearEnrolled)values(" + sobj.getid() + ",'" + sobj.getname() + "', '" + sobj.getdob() + "', '" + sobj.getyenrolled() + "')";//sql insert query for the student table in the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to database
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();
            }
        }

        public void deletestudentbyid(int id)//method used to delete records from student table
        {
            try
            {
                string sql = "delete from student where studentid = " + id + "";//sql query used to delete records from student table 
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to make the connection with database
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }

           
        }


        public void updatestudent(Student sobj)//method used to update student records in the student table of the database
        {
            try
            {
                string sql = "update student set studentname = ('" + sobj.getname() + "'), dateofbirth = ('" + sobj.getdob() + "'),yearenrolled = ('" + sobj.getyenrolled() + "') where studentid = ('"+sobj.getid()+"')";//sql query part used to update student records in the student table of database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command used to connect to the database
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }


        public Student searchstudentbyid(int id)//Method used to used records of the table student which in the database Tithi
        {
            try
            {
                string sql = "select * from student where studentid = (" + id + ")";//sql query part which is used to search records of the student table of database Tithi
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command used to connect to the database
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();


                if(dreader.Read())
                {
                    std1/*Student object*/ = new Student((int)dreader[0], dreader[1].ToString(), dreader[2].ToString(), dreader[3].ToString());//data in the student table of the database is read as an array
                }
                dreader.Close();

            }
            finally
            {
                m_con.Close();
            }
            return std1;//returning the student object
        }


    }
}
