using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class Works_onDAO
    {

        Works_on w1;
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewWorkson(Works_on wobj)
        {
            try
            {
                string sql = "insert into works_on (stdntid, crsid,examdate,Examinationid, grade,lectrid)values(" + wobj.getsid() + "," + wobj.getcid() + ", '" + wobj.getedate() + "', " + wobj.geteid() + ", '" + wobj.getgrade() + "', "+ wobj.getlid()+")";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();
            }
        }

        public void deleteworkson(int sid, int cid, string edate, int eid)
        {
            try
            {
                string sql = "delete from works_on where stdntid = " + sid + " and crsid = "+ cid+" and examdate = '"+edate+"' and examinationid = "+eid+"";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }


        }


        public void updateworkson(Works_on wobj)
        {
            try
            {
                string sql = "update works_on set grade = ('" + wobj.getgrade() + "'), lectrid = (" + wobj.getlid() + ") where stdntid = (" + wobj.getsid() + ") and crsid = (" + wobj.getcid() + ")  and   examdate = ('" + wobj.getedate() + "') and examinationid = ("+wobj.geteid()+")";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }


        public Works_on searchworkson(int sid, int cid, string edate, int eid )
        {
            try
            {
                string sql = "select * from works_on where stdntid = (" + sid + ") and crsid = ("+cid+") and examdate = ('"+edate+"') and examinationid = ("+eid+")";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                SqlDataReader dreader = cmd.ExecuteReader();


                if (dreader.Read())
                {
                    w1 = new Works_on((int)dreader[0], (int)dreader[1], dreader[2].ToString(), (int)dreader[3], dreader[4].ToString(), (int)dreader[5]);
                }
                dreader.Close();

            }
            finally
            {
                m_con.Close();
            }
            return w1;



        }
    }
}
