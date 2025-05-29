using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class CommitteDAO//the database which is created in sql is connected and handled here

    {
        Committee com1;//new object of committee class 
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";//SqlAuthenticationInitializer connection string
        SqlConnection m_con = new SqlConnection(con);//sql command to connect to the database

        public void insertnewcommittee(Committee comobj)//method used to insert new committee to the committee table in database
        {
            try
            {
                string sql = "insert into committee (committeeID, committeeName,fac_id)values(" + comobj.getid() + ",'" + comobj.getname() + "', '" + comobj.getfid() + "')";//sql query to insert new committee
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to database
                m_con.Open();// openning the pathway tot the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//closing the pathway of database
            }
        }

        public void deletecommitteebyid(int id)//method used to delete committee table records according to it's id
        {
            try
            {
                string sql = "delete from Committee where comid = " + id + "";//sql query used to delete a committee record from committee table according to it's id 
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command used to connectto the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }


        }


        public void updatecommittee(Committee comobj)//method used to update records from the committee table of database
        {
            try
            {
                string sql = "update coommittee set committeename = ('" + comobj.getname() + "'), fac_id = (" + comobj.getfid() + ") where committeeid = (" + comobj.getid() + ")";//sql command for updating records of committe table of the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command used to connect to the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway  to the database
            }
        }


        public Committee searchcommitteebyid(int id)//method used to search committee records from the committee table of database
        {
            try
            {
                string sql = "select * from committee where committeeid = (" + id + ")";//sql query to select 
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//open the pathway to the database
                SqlDataReader dreader = cmd.ExecuteReader();



                if (dreader.Read())
                {
                    com1 = new Committee((int)dreader[0], dreader[1].ToString(), (int)dreader[2]);//data in the committee table is read as an array according to the id given
                }
                dreader.Close();

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
            return com1;//return a committee object which contains searched data
        }


    }
}
