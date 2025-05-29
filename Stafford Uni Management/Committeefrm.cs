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
    public partial class Committeefrm : Form
    {
        CommitteDAO comdao = new CommitteDAO();
        public Committeefrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//this button inc;ude instructions to insert new committee to the relevant table
        {
            try
            {
                Committee comob = new Committee(int.Parse(textBox1.Text), (textBox2.Text), int.Parse((string)comboBox1.Text));
                comdao.insertnewcommittee(comob);
                MessageBox.Show("Recorded Successfully", "Student Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Student Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)//this button include instructions to delete a record from table
        {
            try
            {
                comdao.deletecommitteebyid(int.Parse(textBox1.Text));
                MessageBox.Show("Deleted Successfully", "Committee Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Committee Registration");
            }
        }

        private void button3_Click(object sender, EventArgs e)//this button includes instructions to update records of the table in the database
        {

            try
            {
                Committee comob = new Committee(int.Parse(textBox1.Text), (textBox2.Text), int.Parse((string)comboBox1.Text));
                comdao.updatecommittee(comob);
                MessageBox.Show("Updated Successfully", "Committee  Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Committee Registration");
            }
        }

        private void button4_Click(object sender, EventArgs e)//this button includes instructions to search records from the database table.
        {
            try
            {
                Committee comob = comdao.searchcommitteebyid(int.Parse(textBox1.Text));
                textBox1.Text = comob.getid().ToString();
                textBox2.Text = comob.getname();
                comboBox1.Text = comob.getfid().ToString();
                
            }
            catch
            {
                MessageBox.Show("Error", "Committee Registration");
            }
        }

        private void Committeefrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tithiDataSet10.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this.tithiDataSet10.Faculty);
            // TODO: This line of code loads data into the 'tithiDataSet9.Committee' table. You can move, or remove it, as needed.
            this.committeeTableAdapter.Fill(this.tithiDataSet9.Committee);

        }

        private void Baack_Click(object sender, EventArgs e)
        {
            MainMenu ob = new MainMenu();
            ob.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu ob = new MainMenu();
            ob.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
