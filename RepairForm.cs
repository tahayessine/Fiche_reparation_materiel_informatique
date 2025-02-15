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
    public partial class RepairForm : Form
    {
        public RepairForm()
        {
            InitializeComponent();
            Equipement_Load();
            Panne_Load();
            Piece_Load();
        }
        private string connectionstring = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Equipement_Load()
        {


            // Chargement des clients depuis la base de données dans la ComboBox
            string query = "SELECT Num_Ser FROM Equipements";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);


                comboBox1.DisplayMember = "Num_Ser";// Afficher le num du client dans la ComboBox
                comboBox1.ValueMember = "Num_Ser"; // Utiliser le Num_Ser comme valeur associée
                comboBox1.DataSource = table; // Définir la source de données de la ComboBox
            }


        }
        private void Panne_Load()
        {
            string query = "SELECT ID_Panne ,Des_Panne FROM Panne";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);


                comboBox2.DisplayMember = "Des_Panne";// Afficher le  Des_Panne dans la ComboBox
                comboBox2.ValueMember = "ID_Panne"; // Utiliser le ID_Panne comme valeur associée
                comboBox2.DataSource = table; // Définir la source de données de la ComboBox
            }
        }
        private void Piece_Load()
        {
            string query = "SELECT Id_piece,Name_P  FROM Piece";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);


                comboBox3.DisplayMember = "Name_P";// Afficher le  Des_Panne dans la ComboBox
                comboBox3.ValueMember = "Id_piece"; // Utiliser le ID_Panne comme valeur associée
                comboBox3.DataSource = table; // Définir la source de données de la ComboBox
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Piece P = new Piece();
            P.Show();
            this.Close();
        }

        private void Costumer_btn_Click(object sender, EventArgs e)
        {
            Costumer C = new Costumer();
            C.Show();
            this.Close();
        }

        private void HOME_btn_Click(object sender, EventArgs e)
        {
            MainForm Equipement = new MainForm();
            Equipement.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Close();
        }

        private void RepairForm_Load(object sender, EventArgs e)
        {

            try
            {
                // Charger les données dans la DataTable à partir de la base de données
                string connectionString = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    if (cn.State != ConnectionState.Open)
                        MessageBox.Show("Connection failed");

                    string query = "select id_piece ,Name_P,Unite_Price";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DGV.Rows.Add(dr[0], dr[1], dr[1]);
                        dr.Close();
                        cmd.Dispose();
                        cn.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    // Collect information from the form controls
                    int Id_piece;
                    if (!int.TryParse(textBox1.Text, out Id_piece))
                    {
                        MessageBox.Show("Please enter a valid piece ID (numeric value).");
                        return;
                    }

                    string Name_P = textBox2.Text;

                    float Unite_Price;
                    if (!float.TryParse(textBox3.Text, out Unite_Price))
                    {
                        MessageBox.Show("Please enter a valid unit price (numeric value).");
                        return;
                    }

                    // Insert data into the SQL Server table
                    string insertQuery = "INSERT INTO Piece (Id_piece, Name_P, Unite_Price) VALUES (@Id_piece, @Name_P, @Unite_Price)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id_piece", Id_piece);
                        cmd.Parameters.AddWithValue("@Name_P", Name_P);
                        cmd.Parameters.AddWithValue("@Unite_Price", Unite_Price);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Piece added successfully!");
                    // Refresh the DataGridView after adding a
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
