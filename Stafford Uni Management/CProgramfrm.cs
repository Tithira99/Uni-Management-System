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
    public partial class CProgramfrm : Form
    {
        CProgramDAO prgdao = new CProgramDAO();//new Program dao class object is created
        public CProgramfrm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)//button which contains instructions to search data from the table according to the id entered
        {
            try
            {
                CProgram prgob = prgdao.searchcprogrambyid(int.Parse(textBox1.Text));
                textBox1.Text = prgob.getid().ToString();
                textBox2.Text = prgob.gettitle();
                textBox3.Text = prgob.getlevel();
                textBox4.Text = prgob.getduration();
                comboBox1.Text = prgob.getfid().ToString();
            }

            catch
            {
                MessageBox.Show("Error", "Program Registration");
            }
        }

        private void button1_Click(object sender, EventArgs e)//Button which contains instructions to insert data to the tables
        {
            try
            {
                CProgram prgob = new CProgram(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text), int.Parse((string)comboBox1.Text));
                prgdao.insertnewcprogram(prgob);
                MessageBox.Show("Recorded Successfully", "Program Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Program Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)//Button which contains instructions to delete records from the tables
        {
            try
            {
                prgdao.deletecprogrambyid(int.Parse(textBox1.Text));
                MessageBox.Show("Deleted Successfully", "Program Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Program Registration");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)//button which contains instructions to update records from the database table
        {
            try
            {
                CProgram prgob = new CProgram(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text), int.Parse((string)comboBox1.Text));
                prgdao.updatecprogram(prgob);
                MessageBox.Show("Updated Successfully", "Program Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Program Registration");
            }
        }

        private void CProgramfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tithiDataSet22.Program' table. You can move, or remove it, as needed.
            this.programTableAdapter1.Fill(this.tithiDataSet22.Program);
            // TODO: This line of code loads data into the 'tithiDataSet21.Faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter1.Fill(this.tithiDataSet21.Faculty);
            // TODO: This line of code loads data into the 'tithiDataSet15.Faculty' table. You can move, or remove it, as needed.
           // this.programTableAdapter.Fill(this.tithiDataSet14.Program);
            // TODO: This line of code loads data into the 'tithiDataSet14.Program' table. You can move, or remove it, as needed.
            //this.facultyTableAdapter.Fill(this.tithiDataSet15.Faculty);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu ob = new MainMenu();
            ob.Show();
        }
    }
}
