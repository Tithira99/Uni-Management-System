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
    public partial class Lecturerfrm : Form
    {


        LecturerDAO ldao = new LecturerDAO();
        public Lecturerfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Button to insert a new record to the table
        {
            try
            {
                Lecturer lob = new Lecturer(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text),int.Parse((string)comboBox1.Text));
                ldao.insertnewlecturer(lob);
                MessageBox.Show("Recorded Successfully", "Lecturer Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Lecturer Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)//button to delete a record from the table according to the ID
        {
            try
            {
                ldao.deletelecturerbyid(int.Parse(textBox1.Text));
                MessageBox.Show("Deleted Successfully", "Lecturer Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Lecturer Registration");
            }
        }

        private void button3_Click(object sender, EventArgs e)//Button to update a record from the table
        {
            try
            {
                Lecturer lob = new Lecturer(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text),int.Parse ((string)comboBox1.Text));
                ldao.updatelecturer(lob);
                MessageBox.Show("Updated Successfully", "Lecturer Registration ");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Lecturer Registration");
            }
        }

        private void button4_Click(object sender, EventArgs e)//button to search a record from the database
        {
            try
            {
                Lecturer lob = ldao.searchlecturerbyid(int.Parse(textBox1.Text));
                textBox1.Text = lob.getid().ToString();
                textBox2.Text = lob.getname();
                textBox3.Text = lob.gettitle();
                textBox4.Text = lob.getoffice();
                comboBox1.Text = lob.getspid().ToString();
            }
            catch
            {
                MessageBox.Show("Error", "Lecturer Registration");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void Lecturerfrm_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'tithiDataSet6.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.tithiDataSet6.Lecturer);
            // TODO: This line of code loads data into the 'tithiDataSet5.Supervisor' table. You can move, or remove it, as needed.
            this.supervisorTableAdapter1.Fill(this.tithiDataSet5.Supervisor);
            // TODO: This line of code loads data into the 'tithiDataSet4.Supervisor' table. You can move, or remove it, as needed.
            this.supervisorTableAdapter.Fill(this.tithiDataSet4.Supervisor);
            // TODO: This line of code loads data into the 'tithiDataSet3.Supervisor' table. You can move, or remove it, as needed.
            // this.supervisorTableAdapter.Fill(this.tithiDataSet3.Supervisor);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.supervisorTableAdapter.FillBy(this.tithiDataSet3.Supervisor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.supervisorTableAdapter.FillBy1(this.tithiDataSet3.Supervisor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.supervisorTableAdapter.FillBy2(this.tithiDataSet3.Supervisor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.supervisorTableAdapter1.FillBy(this.tithiDataSet5.Supervisor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.supervisorTableAdapter.FillBy(this.tithiDataSet4.Supervisor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
