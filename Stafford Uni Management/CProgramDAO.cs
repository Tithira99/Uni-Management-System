using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class CProgramDAO//Manager class for Program
    {

        CProgram prg1;//new program object
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";//database connection string
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewcprogram(CProgram prgobj)//Method for inserting a new record to the table in the database
        {
            try
            {
                string sql = "insert into program (programid, ptitle, levelno,duration, facid2)values(" + prgobj.getid() + ",'" + prgobj.gettitle() + "','" + prgobj.getlevel() + "','" + prgobj.getduration() + "', " + prgobj.getfid() + ")";//sql query to insert a new record to the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }

        public void deletecprogrambyid(int id)//Method to delete records from the database
        {
            try
            {
                string sql = "delete from program where programid = " + id + "";//sql query to  delete records from the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database


                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }


        }


        public void updatecprogram(CProgram prgobj)//method to update data from the datanbase
        {
            try
            {
                string sql = "update program set ptitle = ('" + prgobj.gettitle() + "'), levelno = ('" + prgobj.getlevel() + "'),duration = ('" + prgobj.getduration() + "'), facid2 = (" + prgobj.getfid() + ") where programid = (" + prgobj.getid() + ")";//sql query to update data from the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }


        public CProgram searchcprogrambyid(int id)//method to dearch records from the database
        {
            try
            {
                string sql = "select * from program where programid = (" + id + ")";//sql query to display searched record from the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the databse
                m_con.Open();//openning the pathway to the database
                SqlDataReader dreader = cmd.ExecuteReader();


                if (dreader.Read())
                {
                    prg1 = new CProgram((int)dreader[0], dreader[1].ToString(), dreader[2].ToString(), dreader[3].ToString(), (int)dreader[4]);///data which has been read is assign to an object prg1 of program class 
                }
                dreader.Close();//closing the data reader

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
            return prg1;//returning the object which contains values read according to the id from the tables.



        }

    }
}
