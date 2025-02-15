using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proojet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Costumer_Load();

        }
        private string connectionstring = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";

        private void Costumer_Load()
        {
            
            
                // Chargement des clients depuis la base de données dans la ComboBox
                string query = "SELECT ID_client FROM client";
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    comboBox1.DisplayMember = "ID_client";// Afficher le nom du client dans la ComboBox
                    comboBox1.ValueMember = "Id_client"; // Utiliser le CIN comme valeur associée
                    comboBox1.DataSource = table; // Définir la source de données de la ComboBox
                }
            

        }
        private void button3_Click(object sender, EventArgs e)
        {

            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void Costumer_btn_Click(object sender, EventArgs e)
        {
            Costumer Cast = new Costumer();
            Cast.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Piece PieceF = new Piece();
            PieceF.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepairForm repairF = new RepairForm();
            repairF.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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

                        string query = "SELECT * FROM Equipements";
                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {

                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            DGVEquipement.DataSource = dataTable;

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

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_add_equipement_Click(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base de données
                string connectionString = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";

                // Ouverture de la connexion
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    // Récupération des valeurs des contrôles du formulaire
                    int Num_Ser;
                    if (!int.TryParse(textBox1.Text, out Num_Ser))
                    {
                        MessageBox.Show("Please enter a valid Equipement ID (numeric value).");
                        return;
                    }

                    string Brand = textBox2.Text;

                    int ID_Client = Convert.ToInt32(comboBox1.SelectedValue);

                    // Requête SQL pour insérer les données dans la table Equipements
                    string insertQuery = "INSERT INTO Equipements (Num_Ser, Brand, ID_Client) VALUES (@Num_Ser, @Brand, @ID_Client)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, cn))
                    {
                        // Ajout des paramètres
                        cmd.Parameters.AddWithValue("@Num_Ser", Num_Ser);
                        cmd.Parameters.AddWithValue("@Brand", Brand);
                        cmd.Parameters.AddWithValue("@ID_Client", ID_Client);

                        // Exécution de la commande
                        cmd.ExecuteNonQuery();
                    }

                    // Affichage d'un message de succès
                    MessageBox.Show("Equipement added successfully!");

                    // Rechargement des données dans le DataGridView
                    MainForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_update_equipement_Click(object sender, EventArgs e)
        {
            try
            {
                // Chaîne de connexion à la base de données
                string connectionString = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";

                // Ouverture de la connexion
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    // Récupération des valeurs des contrôles du formulaire
                    int Num_Ser;
                    if (!int.TryParse(textBox1.Text, out Num_Ser))
                    {
                        MessageBox.Show("Please enter a valid Equipement ID (numeric value).");
                        return;
                    }

                    string Brand = textBox2.Text;

                    int ID_Client = Convert.ToInt32(comboBox1.SelectedValue);

                    // Requête SQL pour mettre à jour les données de l'équipement
                    string updateQuery = "UPDATE Equipements SET Brand = @Brand, ID_Client = @ID_Client WHERE Num_Ser = @Num_Ser";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, cn))
                    {
                        // Ajout des paramètres
                        cmd.Parameters.AddWithValue("@Brand", Brand);
                        cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
                        cmd.Parameters.AddWithValue("@Num_Ser", Num_Ser);

                        // Exécution de la commande
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Equipement information updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Equipement not found. Update failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_delete_equipement_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si une ligne est sélectionnée dans le DataGridView
                if (DGVEquipement.SelectedRows.Count > 0)
                {
                    // Récupérer le numéro de série de l'équipement à supprimer
                    int numSer = Convert.ToInt32(DGVEquipement.SelectedRows[0].Cells["Num_Ser"].Value);

                    // Demander confirmation à l'utilisateur avant de supprimer l'équipement
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this equipment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Connexion à la base de données
                        string connectionString = "Data Source=LAPTOP-5H14RHSK\\SQLEXPRESS;Initial Catalog=Projeet;Integrated Security=True";
                        using (SqlConnection cn = new SqlConnection(connectionString))
                        {
                            cn.Open();

                            // Requête SQL pour supprimer l'équipement en fonction de son numéro de série
                            string deleteQuery = "DELETE FROM Equipements WHERE Num_Ser = @Num_Ser";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, cn))
                            {
                                cmd.Parameters.AddWithValue("@Num_Ser", numSer);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Equipment deleted successfully!");
                                }
                                else
                                {
                                    MessageBox.Show("Equipment not found. Deletion failed.");
                                }
                            }

                            // Actualiser le DataGridView après la suppression d'un équipement
                            MainForm_Load(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an equipment to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_costumer_Click(object sender, EventArgs e)
        {
            try
            {
                int searchNumSer; // Variable pour stocker le numéro de série de l'équipement recherché
                if (!int.TryParse(textBox3.Text.Trim(), out searchNumSer))
                {
                    MessageBox.Show("Please enter a valid equipment number (numeric value).");
                    return;
                }

                bool equipmentFound = false; // Variable pour indiquer si l'équipement a été trouvé
                int rowIndex = -1; // Variable pour stocker l'index de la ligne correspondante

                // Vérifier si le DataGridView contient des lignes
                if (DGVEquipement.Rows.Count > 0)
                {
                    // Parcourir les lignes du DataGridView
                    for (int i = 0; i < DGVEquipement.Rows.Count; i++)
                    {
                        // Récupérer la valeur de la cellule dans la colonne "Num_Ser" pour la ligne actuelle
                        int cellValue = Convert.ToInt32(DGVEquipement.Rows[i].Cells["Num_Ser"].Value);

                        // Vérifier si la valeur de la cellule correspond au numéro de série de l'équipement recherché
                        if (cellValue == searchNumSer)
                        {
                            equipmentFound = true; // L'équipement a été trouvé
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

                // Afficher un message indiquant si l'équipement existe ou non
                if (equipmentFound)
                {
                    MessageBox.Show("Equipment with number " + searchNumSer + " exists.");

                    // Sélectionner la ligne correspondante dans le DataGridView
                    DGVEquipement.ClearSelection();
                    DGVEquipement.Rows[rowIndex].Selected = true;
                    DGVEquipement.FirstDisplayedScrollingRowIndex = rowIndex;
                }
                else
                {
                    MessageBox.Show("Equipment with number " + searchNumSer + " does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
