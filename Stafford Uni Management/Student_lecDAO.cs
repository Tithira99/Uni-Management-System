using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    class Student_lecDAO
    {

        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewstudentlec(Student_lec slobj)
        {
            try
            {
                string sql = "insert into Student_lecturer(sid2, lid2)values(" + slobj.getsid() + "," + slobj.getlid() + ")";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();
            }
        }

        public void deletestudentlec(int sid, int lid)
        {
            try
            {
                string sql = "delete from student_lecturer where sid2 = " + sid + " and lid2 = " + lid + " ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }

        }

    }
}
