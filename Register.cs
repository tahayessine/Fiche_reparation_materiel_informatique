using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proojet
{
    public partial class Register : Form
    {
        SqlConnection cn =
           new SqlConnection(@"Data Source=LAPTOP-5H14RHSK\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_usename.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {




            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = Signup_showpass.Checked ? '\0' : '*';
        }

        private void Signup_loginBtn_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }
    }
}
