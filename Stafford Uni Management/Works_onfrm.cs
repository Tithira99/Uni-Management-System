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
    public partial class Works_onfrm : Form
    {
        Works_onDAO wdao = new Works_onDAO();
        public Works_onfrm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Works_on wob = wdao.searchworkson(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), (textBox1.Text), int.Parse(textBox2.Text));
                comboBox1.Text = wob.getsid().ToString();
                comboBox2.Text = wob.getcid().ToString();
                textBox1.Text = wob.getedate();
                textBox2.Text = wob.geteid().ToString();
                comboBox3.Text = wob.getgrade();
                comboBox4.Text = wob.getlid().ToString();
            }
            catch
            {
                MessageBox.Show("Error", "Examination Details");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                wdao.deleteworkson(int.Parse(comboBox1.Text),int.Parse(comboBox2.Text), (textBox1.Text), int.Parse(textBox2.Text));
                MessageBox.Show("Deleted Successfully", "Examination Details");
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Examination Details");
            }
        }
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Works_on wob = new Works_on(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), (textBox1.Text), int.Parse(textBox2.Text), (comboBox3.Text), int.Parse(comboBox4.Text));
                wdao.insertnewWorkson(wob);
                MessageBox.Show("Recorded Successfully", "Examination Details ");
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox3.Text = "" ;
                comboBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", " Examination Details");
            }
        }

        private void Works_onfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tithiDataSet37.Works_on' table. You can move, or remove it, as needed.
           // this.works_onTableAdapter.Fill(this.tithiDataSet37.Works_on);
            // TODO: This line of code loads data into the 'tithiDataSet36.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter1.Fill(this.tithiDataSet36.Lecturer);
            // TODO: This line of code loads data into the 'tithiDataSet35.Lecturer' table. You can move, or remove it, as needed.
           this.lecturerTableAdapter.Fill(this.tithiDataSet35.Lecturer);
            // TODO: This line of code loads data into the 'tithiDataSet34.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.tithiDataSet34.Course);
            // TODO: This line of code loads data into the 'tithiDataSet33.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.tithiDataSet33.Student);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Works_on wob = new Works_on(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), (textBox1.Text), int.Parse(textBox2.Text), (comboBox3.Text), int.Parse(comboBox4.Text));
                wdao.updateworkson(wob);
                MessageBox.Show("Updated Successfully", "Examination Details ");
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Examination Details");
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
