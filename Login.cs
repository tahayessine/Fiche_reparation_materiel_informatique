using Microsoft.Win32;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionstring);
            cn.Open();
            if (cn.State != ConnectionState.Open)
                MessageBox.Show("connection  echoué");
            else
                MessageBox.Show("connection  réssui");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            regForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (Login_username.Text == "user" && login_password.Text == "0000")
                {

                    MessageBox.Show("Bienvenue", "Accès autorisé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm Main_F = new MainForm();
                    Main_F.Show();
                    this.Hide();

                }
                else

                    MessageBox.Show("Login ou mot de passe incorrect", "Accès non autorisé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_username_TextChanged(object sender, EventArgs e)
        {
            Login_username.Focus();
        }
    }
}
