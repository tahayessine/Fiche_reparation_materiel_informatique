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
    public partial class Costumer : Form
    {
        public Costumer()
        {
            InitializeComponent();
        }

        private void Costumer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'projeetDataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.projeetDataSet.client);
            try
            {
                string connectionstring = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionstring))
                {
                    try
                    {
                        cn.Open();

                        if (cn.State != ConnectionState.Open)
                            MessageBox.Show("Connection failed");
                        else
                            MessageBox.Show("Connection successful");

                        string query = "SELECT * FROM client";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            DGVCostumer.DataSource = dataTable;
                            // Bind the DataTable to the DataGridView

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database query error: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}");
            }
        }

        private void Btn_add_costumer_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionstring))
                {
                    cn.Open();

                    // Collect information from the form controls
                    int ID_client;
                    if (!int.TryParse(textBox1.Text, out ID_client))
                    {
                        MessageBox.Show("Please enter a valid client ID (numeric value).");
                        return;
                    }

                    string First_Name = textBox2.Text;
                    string Last_Name = TextBox5.Text;

                    int Phone_Number;
                    if (!int.TryParse(textBox3.Text, out Phone_Number))
                    {
                        MessageBox.Show("Please enter a valid phone number (numeric value).");
                        return;
                    }

                    string Email = textBox4.Text;
                    // Add email validation if needed

                    char Gender = 'M';
                    if (Gender == 'M')
                    {
                        textBox6.Text = "Masculin";
                    }
                    else if(Gender=='F')
                    {
                        textBox6.Text = "Feminin";
                    }

                    // Insert data into the SQL Server table
                    string insertQuery = "INSERT INTO client (ID_client, First_Name, Last_Name, Phone_Number, Email, Gender) VALUES (@ID_client, @First_Name, @Last_Name,@Phone_Number, @Email, @Gender)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@ID_client", ID_client);
                        cmd.Parameters.AddWithValue("@First_Name", First_Name);
                        cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                        cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Client added successfully!");
                    // Refresh the DataGridView after adding a new client
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Piece Piece = new Piece();
            Piece.Show();
            this.Hide();
        }

        private void Btn_update_costumer_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer l'ID du client sélectionné dans le DataGridView
                int ID_client;
                if (!int.TryParse(textBox1.Text, out ID_client))
                {
                    MessageBox.Show("Please select a client to update.");
                    return;
                }

                // Collecter les nouvelles informations du client à partir des contrôles du formulaire
                string First_Name = textBox2.Text;
                string Last_Name = TextBox5.Text;

                int Phone_Number;
                if (!int.TryParse(textBox3.Text, out Phone_Number))
                {
                    MessageBox.Show("Please enter a valid phone number (numeric value).");
                    return;
                }

                string Email = textBox4.Text;
                char Gender = 'M'; // Si vous avez un contrôle pour sélectionner le genre, vous devez le récupérer ici

                // Connexion à la base de données
                string connectionString = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    // Exécuter la requête SQL UPDATE pour mettre à jour les données du client
                    string updateQuery = "UPDATE client SET First_Name = @First_Name, Last_Name = @Last_Name, Phone_Number = @Phone_Number, Email = @Email, Gender = @Gender WHERE ID_client = @ID_client";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@ID_client", ID_client);
                        cmd.Parameters.AddWithValue("@First_Name", First_Name);
                        cmd.Parameters.AddWithValue("@Last_Name", Last_Name);
                        cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client information updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Client not found. Update failed.");
                        }
                    }

                    // Rafraîchir le DataGridView après la mise à jour des informations du client
                    Costumer_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_delete_costumer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCostumer.SelectedRows.Count > 0)
                {
                    int ID_client = Convert.ToInt32(DGVCostumer.SelectedRows[0].Cells["ID_client"].Value);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string connectionString = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
                        using (SqlConnection cn = new SqlConnection(connectionString))
                        {
                            cn.Open();

                            string deleteQuery = "DELETE FROM client WHERE ID_client = @ID_client";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, cn))
                            {
                                cmd.Parameters.AddWithValue("@ID_client", ID_client);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Client deleted successfully!");
                                }
                                else
                                {
                                    MessageBox.Show("Client not found. Deletion failed.");
                                }
                            }

                            Costumer_Load(sender, e); // Actualiser le DataGridView après la suppression
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a client to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepairForm repairF = new RepairForm();
            repairF.Show();
            this.Hide();
        }

        private void HOME_btn_Click(object sender, EventArgs e)
        {
            MainForm mainF = new MainForm();
            mainF.Show();
            this.Hide();
        }

        private void btn_search_equipement_Click(object sender, EventArgs e)
        {
            try
            {
                int searchID; // Variable pour stocker l'ID du client recherché
                if (!int.TryParse(textBox7.Text.Trim(), out searchID))
                {
                    MessageBox.Show("Please enter a valid client ID (numeric value).");
                    return;
                }

                bool clientFound = false; // Variable pour indiquer si le client a été trouvé
                int rowIndex = -1; // Variable pour stocker l'index de la ligne correspondante

                // Vérifier si le DataGridView contient des lignes
                if (DGVCostumer.Rows.Count > 0)
                {
                    // Parcourir les lignes du DataGridView
                    for (int i = 0; i < DGVCostumer.Rows.Count; i++)
                    {
                        // Récupérer la valeur de la cellule dans la colonne "ID_client" pour la ligne actuelle
                        int cellValue = Convert.ToInt32(DGVCostumer.Rows[i].Cells["ID_client"].Value);

                        // Vérifier si la valeur de la cellule correspond à l'ID du client recherché
                        if (cellValue == searchID)
                        {
                            clientFound = true; // Le client a été trouvé
                            rowIndex = i; // Stocker l'index de la ligne correspondante
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data available in DataGridView.");
                    return;
                }

                // Afficher un message indiquant si le client existe ou non
                if (clientFound)
                {
                    MessageBox.Show("Client with ID " + searchID + " exists.");

                    // Sélectionner la ligne correspondante dans le DataGridView
                    DGVCostumer.ClearSelection();
                    DGVCostumer.Rows[rowIndex].Selected = true;
                    DGVCostumer.FirstDisplayedScrollingRowIndex = rowIndex;
                }
                else
                {
                    MessageBox.Show("Client with ID " + searchID + " does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
