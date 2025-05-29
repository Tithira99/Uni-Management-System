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
    public partial class Facultyfrm : Form
    {
        FacultyDAO facdao = new FacultyDAO();
        public Facultyfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Button for inserting new records for the table
        {
            try
            {
               Faculty fob = new Faculty(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text));
                facdao.insertnewfaculty(fob);
                MessageBox.Show("Recorded Successfully", "Faculty Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            catch 
            {
                MessageBox.Show("Error", "Faculty Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)//BUtton for deleting records from the database table
        {
            try
            {
                facdao.deletefacultybyid(int.Parse(textBox1.Text));
                MessageBox.Show("Deleted Successfully", "Faculty Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Faculty Registration");
            }
        }

        private void button3_Click(object sender, EventArgs e)//Button for updating records from the database
        {
            try
            {
                Faculty fob = new Faculty(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text));
                facdao.updatefaculty(fob);
                MessageBox.Show("Updated Successfully", "Faculty Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Faculty Registration");
            }
        }

        private void button4_Click(object sender, EventArgs e)//method for searching records form the database
        {
            try
            {
                Faculty fob = facdao.searchfacultybyid(int.Parse(textBox1.Text));
                textBox1.Text = fob.getid().ToString();
                textBox2.Text = fob.getname();
                textBox3.Text = fob.getdean();
                textBox4.Text = fob.getbuilding();
            }
            catch
            {
                MessageBox.Show("Error", "Faculty Registration");
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
