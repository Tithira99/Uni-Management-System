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
    
    public partial class Coursefrm : Form
    {
        CourseDAO cdao = new CourseDAO();
        public Coursefrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Course cob = new Course(int.Parse(textBox1.Text), (textBox2.Text), int.Parse((string)comboBox1.Text));
                cdao.updatecourse(cob);
                MessageBox.Show("Updated Successfully", "Course Registration");
            }
            catch
            {
                MessageBox.Show("Error", "Course Registration");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Course cob = cdao.searchcoursebyid(int.Parse(textBox1.Text));
                textBox1.Text = cob.getid().ToString();
                textBox2.Text = cob.getname();
                comboBox1.Text = cob.getpid().ToString();

            }
            catch
            {
                MessageBox.Show("Error", "Course Registration");
            }
        }

        private void button1_Click(object sender, EventArgs e)//button click to insert data to the table in the database
        {
            try
            {
                Course cob = new Course(int.Parse(textBox1.Text), (textBox2.Text), int.Parse((string)comboBox1.Text));
                cdao.insertnewcourse(cob);
                MessageBox.Show("Recorded Successfully", "Course Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Course Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)//button click to delete data from the database table
        {
            try
            {
                cdao.deletecoursebyid(int.Parse(textBox1.Text));
                MessageBox.Show("Deleted Successfully", "Course Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Course Registration");
            }
        }

        private void Coursefrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tithiDataSet20.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.tithiDataSet20.Course);
            // TODO: This line of code loads data into the 'tithiDataSet16.Program' table. You can move, or remove it, as needed.
            this.programTableAdapter.Fill(this.tithiDataSet16.Program);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu ob = new MainMenu();
            ob.Show();
        }
    }
}
