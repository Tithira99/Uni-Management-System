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
    public partial class Adminfrm : Form
    {
        AdminDAO adao = new AdminDAO();//new object is created from the adminDAO
        public Adminfrm()
        {
            InitializeComponent();
        }

        private void Adminfrm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//"Back button" which includes the instructions to hide the current form and display main menu
        {
            this.Hide();
            MainMenu ob = new MainMenu();//
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)//"Insert button" which includes instructions to insert   a new record  to the admin table as an admin object containing provided values from the interface  to the database 
        {
            try
            {
                Admin aob = new Admin((textBox1.Text), (textBox2.Text));
                adao.insertnewadmin(aob);
                MessageBox.Show("Recorded Successfully", "Admin Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                
            }
            catch
            {
                MessageBox.Show("Error", "Admin Registration");

            }
        }

        private void button2_Click(object sender, EventArgs e)//"Delete button" which includes instructions to Delete   a new record  from  the admin table according to the id value inserted in the textBox1
        {

        
            try
            {
                adao.deleteadmin((textBox1.Text));
                MessageBox.Show("Deleted Successfully", "Admin Registration");
                textBox1.Text = "";
                textBox2.Text = "";

            }
            
            catch
            {
                MessageBox.Show("Error", "Admin Registration");
            }

        }

        private void button3_Click(object sender, EventArgs e)//Update button which includes the instructions to udate records of the admin table according to the values entered.
        {
            try
            {
                Admin aob = new Admin((textBox1.Text), (textBox2.Text));
                adao.updateadmin(aob);
                MessageBox.Show("Updated Successfully", "Admin Registration");

                textBox1.Text = "";
                textBox2.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Admin Registration");

            }
        }

        private void button4_Click(object sender, EventArgs e)//search button which include instructions to search data according to the id value inserted in the textbox1 button
        {
            Admin aob = adao.searchadminbyid((textBox1.Text));
            textBox1.Text = aob.getadid();
            textBox2.Text = aob.getadname();

        }
    }
}
