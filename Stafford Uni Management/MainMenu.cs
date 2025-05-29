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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//button to display lecturer form
        {
            this.Hide();
            Lecturerfrm ob = new Lecturerfrm();
            ob.Show();
        }

        private void button11_Click(object sender, EventArgs e)//button to display committee - lecturer form
        {
            this.Hide();
            Com_lecfrm ob = new Com_lecfrm();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)//button  to display faculty  form
        {
            this.Hide();
            Facultyfrm ob = new Facultyfrm();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)//button to display student form
        {
            this.Hide();
            Studentfrm ob = new Studentfrm();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)//button to display supervisor form 
        {
            this.Hide();
            Supervisorfrm ob = new Supervisorfrm();
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)//button to display program form
        {
            this.Hide();
            CProgramfrm ob = new CProgramfrm();
            ob.Show();
        }

        private void button6_Click(object sender, EventArgs e)//method to display course form
        {
            this.Hide();
            Coursefrm ob = new Coursefrm();
            ob.Show();
        }

        private void button7_Click(object sender, EventArgs e)//button to display committee form
        {
            this.Hide();
            Committeefrm ob = new Committeefrm();
            ob.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)//button to display student - lecturer form 
        {
            this.Hide();
            Student_lecfrm ob = new Student_lecfrm();
            ob.Show();
        }

        private void button9_Click(object sender, EventArgs e)//button to display the Lecturer -  course form
        {
            this.Hide();
            Lecturer_crsfrm ob = new Lecturer_crsfrm();
            ob.Show();
        }

        private void button12_Click(object sender, EventArgs e)//button to display works o  form(Examination details/Student - Course form)
        {
            this.Hide();
            Works_onfrm ob = new Works_onfrm();
            ob.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)//Exit button to close the program
        {
            /*this.Hide();
            Loginfrm ob = new Loginfrm();
            ob.Show();*/
            System.Windows.Forms.Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)//Button to display Login registration form
        {
            this.Hide();
            LoginRegfrm ob = new LoginRegfrm();
            ob.Show();
        }

        private void button14_Click(object sender, EventArgs e)//button to display admin registration form
        {
            this.Hide();
            Adminfrm ob = new Adminfrm();
            ob.Show();
        }
    }
}
