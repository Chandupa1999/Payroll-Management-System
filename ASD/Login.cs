using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASD
{
    //Class and Objects and inheritance
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Polymorphism
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "" || UPasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if(UnameTb.Text == "Admin" && UPasswordTb.Text == "Password")
            {
                Home Obj = new Home();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Admin or Password");
            }
        }
    }
}
