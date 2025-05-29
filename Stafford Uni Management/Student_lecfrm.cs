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
    public partial class Student_lecfrm : Form
    {
        Student_lecDAO sldao = new Student_lecDAO();
        public Student_lecfrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student_lec slob = new Student_lec(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text));
                sldao.insertnewstudentlec(slob);
                MessageBox.Show("Recorded Successfully", "Lecturer - Student Registration");
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Lecturer - Student Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sldao.deletestudentlec(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text));
                MessageBox.Show("Deleted Successfully", "Lecturer - Student Registration");
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Lecturer - Student Registration");
            }
        }

        private void Student_lecfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tithiDataSet31.Lecturer' table. You can move, or remove it, as needed.
             //this.lecturerTableAdapter.Fill(this.tithiDataSet31.Lecturer);
            // TODO: This line of code loads data into the 'tithiDataSet30.Student' table. You can move, or remove it, as needed.
           // this.studentTableAdapter.Fill(this.tithiDataSet30.Student);
            // TODO: This line of code loads data into the 'tithiDataSet29.student_Lecturer' table. You can move, or remove it, as needed.
            this.student_LecturerTableAdapter.Fill(this.tithiDataSet29.student_Lecturer);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu ob = new MainMenu();
            ob.Show();
        }
    }
}
