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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proojet
{
    public partial class Piece : Form
    {
        public Piece()
        {
            InitializeComponent();
        }

        private void Piece_Load(object sender, EventArgs e)
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
                    else
                        MessageBox.Show("Connection successful");

                    // Créer un adaptateur de données
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Piece", cn);

                    // Créer une nouvelle DataTable
                    DataTable dataTable = new DataTable();

                    // Remplir la DataTable à partir du résultat de la requête SQL
                    adapter.Fill(dataTable);

                    // Lier la DataTable au DataGridView
                    DGVPiece.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Btn_add_costumer_Click(object sender, EventArgs e)
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
                    // Refresh the DataGridView after adding a new piece
                    Piece_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_update_costumer_Click(object sender, EventArgs e)
        {
            try
            {
                // Mettre à jour les données dans la base de données
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

                    // Update data in the SQL Server table
                    string updateQuery = "UPDATE Piece SET Name_P = @Name_P, Unite_Price = @Unite_Price WHERE Id_piece = @Id_piece";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@Id_piece", Id_piece);
                        cmd.Parameters.AddWithValue("@Name_P", Name_P);
                        cmd.Parameters.AddWithValue("@Unite_Price", Unite_Price);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Display a success message
                            MessageBox.Show("Piece updated successfully!");
                        }
                        else
                        {
                            // Display a message if no rows were affected (record not found)
                            MessageBox.Show("Piece not found. Update failed.");
                        }
                    }

                    // Refresh the DataGridView after updating a piece
                    Piece_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVPiece_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_delete_costumer_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si une ligne est sélectionnée dans le DataGridView
                if (DGVPiece.SelectedRows.Count > 0)
                {
                    // Récupérer l'ID de la pièce à supprimer
                    int Id_piece = Convert.ToInt32(DGVPiece.SelectedRows[0].Cells["Id_piece"].Value);

                    // Demander confirmation à l'utilisateur avant de supprimer la pièce
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this piece?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Connexion à la base de données
                        string connectionString = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
                        using (SqlConnection cn = new SqlConnection(connectionString))
                        {
                            cn.Open();

                            // Requête SQL pour supprimer la pièce en fonction de son ID
                            string deleteQuery = "DELETE FROM Piece WHERE Id_piece = @Id_piece";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, cn))
                            {
                                cmd.Parameters.AddWithValue("@Id_piece", Id_piece);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Piece deleted successfully!");
                                }
                                else
                                {
                                    MessageBox.Show("Piece not found. Deletion failed.");
                                }
                            }

                            // Actualiser le DataGridView après la suppression d'une pièce
                            Piece_Load(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a piece to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Costumer_btn_Click(object sender, EventArgs e)
        {
            Costumer CostumerF = new Costumer();
            CostumerF.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepairForm repairF = new RepairForm();
            repairF.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void btn_search_costumer_Click(object sender, EventArgs e)
        {
            try
            {
                int searchId; // Variable pour stocker l'ID de la pièce recherchée
                if (!int.TryParse(textBox4.Text.Trim(), out searchId))
                {
                    MessageBox.Show("Please enter a valid piece ID (numeric value).");
                    return;
                }

                bool idExists = false; // Variable pour indiquer si l'ID existe
                int rowIndex = -1; // Variable pour stocker l'index de la ligne correspondante

                // Vérifier si le DataGridView contient des lignes
                if (DGVPiece.Rows.Count > 0)
                {
                    // Parcourir les lignes du DataGridView
                    for (int i = 0; i < DGVPiece.Rows.Count; i++)
                    {
                        // Récupérer la valeur de la cellule dans la colonne "Id_piece" pour la ligne actuelle
                        int cellValue = Convert.ToInt32(DGVPiece.Rows[i].Cells["Id_piece"].Value);

                        // Vérifier si la valeur de la cellule correspond à l'ID de la pièce recherchée
                        if (cellValue == searchId)
                        {
                            idExists = true; // L'ID existe
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

                // Afficher un message indiquant si l'ID existe ou non
                if (idExists)
                {
                    MessageBox.Show("Piece with ID " + searchId + " exists.");

                    // Sélectionner la ligne correspondante dans le DataGridView
                    DGVPiece.ClearSelection();
                    DGVPiece.Rows[rowIndex].Selected = true;
                    DGVPiece.FirstDisplayedScrollingRowIndex = rowIndex;
                }
                else
                {
                    MessageBox.Show("Piece with ID " + searchId + " does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
