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
    public partial class Com_lecfrm : Form
    {

        Com_lecDAO cldao = new Com_lecDAO();//new object from the com_lecDAO class
        public Com_lecfrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//button includes the instructions  to insert data to the  com_lec table
        {
            try
            {
                Com_lec clob = new Com_lec(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text));
                cldao.insertnewcomlec(clob);
                MessageBox.Show("Recorded Successfully", "Lecturer - Committee Registration");
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Lecturer - Committee Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)//button includes instructions to delete data  according to the id  from the com_lec table
        {
            try
            {
                cldao.deletecomlec(int.Parse(comboBox1.Text),int.Parse(comboBox2.Text));
                MessageBox.Show("Deleted Successfully", "Lecturer - Committee Registration");
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Lecturer - Committee Registration");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void Com_lecfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tithiDataSet25.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.tithiDataSet25.Lecturer);
            // TODO: This line of code loads data into the 'tithiDataSet24.Committee_Lec' table. You can move, or remove it, as needed.
            this.committee_LecTableAdapter.Fill(this.tithiDataSet24.Committee_Lec);
            // TODO: This line of code loads data into the 'tithiDataSet23.Committee' table. You can move, or remove it, as needed.
            this.committeeTableAdapter.Fill(this.tithiDataSet23.Committee);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)//button includes instructions to hide the current form and show Main Menu
        {
            this.Hide();
            MainMenu ob = new MainMenu();
            ob.Show();
        }
    }
}
