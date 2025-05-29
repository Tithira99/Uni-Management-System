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
    public partial class Lecturer_crsfrm : Form
    {
        Lecturer_crsDAO lcdao = new Lecturer_crsDAO();//new object from the DAO class
        public Lecturer_crsfrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//button for deleting records from the database
        {
            try
            {
                lcdao.deletelecincrs(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text));
                MessageBox.Show("Deleted Successfully", "Lecturer - Course Registration");
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Lecturer - Course Registration");
            }
        }

        private void button1_Click(object sender, EventArgs e)//button for inserting records to the database
        {
            try
            {
                Lecturer_crs lcob = new Lecturer_crs(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text));
                lcdao.insertnewlectocrs(lcob);
                MessageBox.Show("Recorded Successfully", "Lecturer - Course Registration");
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Lecturer - Course Registration");
            }
        }

        private void Lecturer_crsfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tithiDataSet28.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.tithiDataSet28.Lecturer);
            // TODO: This line of code loads data into the 'tithiDataSet27.Lecturer_course' table. You can move, or remove it, as needed.
            this.lecturer_courseTableAdapter.Fill(this.tithiDataSet27.Lecturer_course);
            // TODO: This line of code loads data into the 'tithiDataSet26.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.tithiDataSet26.Course);

        }

        private void button3_Click(object sender, EventArgs e)//Back button
        {
            this.Hide();
            MainMenu ob = new MainMenu();
            ob.Show();
        }
    }
}
