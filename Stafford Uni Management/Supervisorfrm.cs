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
    public partial class Supervisorfrm : Form
    {
        SupervisorDAO supdao = new SupervisorDAO();
        public Supervisorfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Supervisor supob = new Supervisor(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text));
                supdao.insertnewsupervisor(supob);
                MessageBox.Show("Recorded Successfully", "Supervisor Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Supervisor Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                supdao.deletesupervisorbyid(int.Parse(textBox1.Text));
                MessageBox.Show("Deleted Successfully", "Supervisor Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Supervisor Registration");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Supervisor supob = new Supervisor(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text));
                supdao.updatesupervisor(supob);
                MessageBox.Show("Updated Successfully", "Supervisor Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Supervisor Registration");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Supervisor supob = supdao.searchsupervisorbyid(int.Parse(textBox1.Text));
                textBox1.Text = supob.getid().ToString();
                textBox2.Text = supob.getname();
                textBox3.Text = supob.gettitle();
                textBox4.Text = supob.getofficeroom();
            }
            catch
            {
                MessageBox.Show("Error", "Student Registration");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu ob = new MainMenu();
            ob.Show();
        }
    }
}
