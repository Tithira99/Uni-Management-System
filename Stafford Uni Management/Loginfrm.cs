using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stafford_Uni_Management
{
    public partial class Loginfrm : Form
    {
        LoginDAO lgndao = new LoginDAO();
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=Tithi;User ID=Tithi;Password=tithira@sql";
        SqlConnection m_con = new SqlConnection(con);

        public Loginfrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Button Click for Login
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from login where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", m_con);/*Sql Query 
                to count Number of records available according to the text input(it can be 1 or 0 only)*/
                DataTable dt = new DataTable();//Creating a virtual table
                sda.Fill(dt);//filling selected value from the sql query to the virtual table dt
                if (dt.Rows[0][0].ToString() == "1")//Control Structure: checking whether there is a record tallying with the input data.
                {
                    this.Hide();
                    

                    MainMenu ob = new MainMenu();//Creating new object from main menu
                    ob.Show();//Display the main menu
                    MessageBox.Show("Login Successful", "Stafford University Management System");
                    
                }
                else
                {
                    MessageBox.Show("Invalid Access", "Stafford University Management System");//Display error message
                }
            }
            catch
            {
                m_con.Close();
            }
            /*Reference - https://www.c-sharpcorner.com/UploadFile/9582c9/login-form-with-sql-in-C-Sharp/ - (Online website)*/









        }
    }
}
