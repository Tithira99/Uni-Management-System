using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stafford_Uni_Management
{
    public partial class LoginRegfrm : Form
    {
        LoginDAO logdao = new LoginDAO();
        public LoginRegfrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                logdao.deletelogin(textBox1.Text);
                MessageBox.Show("Deleted LoginSuccessfully", "Stafford University Management System");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Stafford University Management System");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu ob = new MainMenu();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)//button to insert a new login record
        {
            try
            {
                Login logob = new Login((textBox2.Text), (textBox1.Text), (comboBox1.Text));
                logdao.insertnewlogin(logob);
                MessageBox.Show("New Login Inserted Successfully", "Stafford University Management System");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";


            }
            catch
            {
                MessageBox.Show("Error", "Stafford University Management System");
            }
        }

        private void button3_Click(object sender, EventArgs e)//button to update login details 
        {
            try
            {
                Login logob = new Login((textBox2.Text), (textBox1.Text), (comboBox1.Text));
                logdao.updatelogin(logob);
                MessageBox.Show("Updated Login Successfully", "Stafford University Management System");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Stafford University Management System");
            }
        }

        private void button4_Click(object sender, EventArgs e)//button to search login records
        {
            try
            {
                Login logob = logdao.searchloginbyusrname((textBox1.Text));
                textBox1.Text = logob.getusrnm();
                textBox2.Text = logob.getpswrd();
                comboBox1.Text = logob.getaid();
            }

            catch
            {
                MessageBox.Show("Error", "Stafford University Management System");
            }


        }

        private void LoginRegfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tithiDataSet44.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter2.Fill(this.tithiDataSet44.Login);
            // TODO: This line of code loads data into the 'tithiDataSet43.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter1.Fill(this.tithiDataSet43.Admin);
            // TODO: This line of code loads data into the 'tithiDataSet42.Login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter1.Fill(this.tithiDataSet42.Login);
            // TODO: This line of code loads data into the 'tithiDataSet40.Admin' table. You can move, or remove it, as needed.
            //this.adminTableAdapter.Fill(this.tithiDataSet40.Admin);
            // TODO: This line of code loads data into the 'tithiDataSet39.Login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter.Fill(this.tithiDataSet39.Login);
            // TODO: This line of code loads data into the 'tithiDataSet38.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.tithiDataSet38.Student);

        }
    }
}
