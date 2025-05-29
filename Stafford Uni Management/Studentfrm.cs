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

    
    public partial class Studentfrm : Form
    {

        StudentDAO sdao = new StudentDAO();//StudentDAO object
        public Studentfrm()
        {
            InitializeComponent();
        }

        private void button1_Click/* "insert button" - used to add new record of a student */(object sender, EventArgs e)
        {
            try
            {
                Student sob = new Student(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text));//passing values in text boxes as a student object
                sdao.insertnewstudent(sob);//passing student object to the insert student method in StudentDAO
                MessageBox.Show("Recorded Successfully", "Student Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                
            }
            catch
            {
                MessageBox.Show("Insert Error", "Student Registration");
            }

        }

        private void button2_Click/* "delete button" -  used to delete records from the student table in the database */(object sender, EventArgs e)
        {
            try
            {
                sdao.deletestudentbyid(int.Parse(textBox1.Text));//passing the value in textBox1 to the delete method in the StudentDAO
                MessageBox.Show("Deleted Successfully", "Student Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Student Registration");
            }
        }

        private void button3_Click/*Update Button" - used to update data from the student table*/(object sender, EventArgs e)
        {
            
            
            try
            {
                Student sob = new Student(int.Parse(textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text));//making student object from the inserted data
                sdao.updatestudent(sob);//passing student object to the update method
                MessageBox.Show("Updated Successfully", "Student Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Update Error", "Student Registration");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Studentfrm_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click/*"Search Buttton"- used to search records of the student table*/(object sender, EventArgs e)
        {
            try
            {
                Student sob/*student object*/ = sdao.searchstudentbyid(int.Parse(textBox1.Text)/*Studentid*/);//passing value in textBox1 to the searchstudentby id method
                textBox1.Text = sob.getid().ToString();
                textBox2.Text/*studentid*/ = sob.getname();
                textBox3.Text/*studentName*/ = sob.getdob();
                textBox4.Text/*date of birth*/ = sob.getyenrolled();
                MessageBox.Show("Search Successful", "Student Registration");
            }
            catch
            {
                MessageBox.Show("Search TError", "Student Registration");
            }

        }

        private void button5_Click/*"Back Button" - hide student form and displays the Main Menu*/(object sender, EventArgs e)
        {
            this.Hide();//Hide the Student interface
            MainMenu ob/*Main menu object*/ = new MainMenu();
            ob.Show();//Display the Main Menu
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
