using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour ClientsP.xaml
    /// </summary>
    public partial class ClientsP : Window
    {
        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";
        int id_client=0;
        string affichage = "Select * From Individuel";


        public ClientsP()
        {
            InitializeComponent();
            GridFill();
            //dataLoader(affichage);
        }

        
        void GridFill()
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {

                MySqlCommand marequete = new MySqlCommand("VoirClients", connexion);
                DataTable dt = new DataTable();
                connexion.Open();
                MySqlDataAdapter a = new MySqlDataAdapter(marequete);
                a.Fill(dt);
                connexion.Close();
                datagrid.ItemsSource = dt.DefaultView;

            }
        }
        

        public DataTable dataLoader(string marequete)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                DataTable erreur = new DataTable();
                connexion.Open();
                MySqlCommand commande = connexion.CreateCommand();
                commande.CommandText = marequete;
                MySqlDataReader reader = commande.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                reader.Close();
                connexion.Close();
                return data;
                //pieceDataGrid.ItemsSource = data.DefaultView;
                //manqueStock.ItemsSource = manquePiece.DefaultView;
            }
        }

        public void affiche(DataTable data)
        {
            datagrid.ItemsSource = data.DefaultView;
            //Permet l'affichage d'une DataTable dans un DataGrid
        }

        private void Creation_Click(object sender, RoutedEventArgs e)
        {

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("AjouterIndividuel", connexion);
                    marequete.CommandType = CommandType.StoredProcedure;
                    marequete.Parameters.AddWithValue("_id_client", id_client);
                    marequete.Parameters.AddWithValue("_nom_client", nom_client_txt.Text);
                    marequete.Parameters.AddWithValue("_prenom_client", prenom_client_txt.Text);
                    marequete.Parameters.AddWithValue("_rue_client", rue_client_txt.Text);
                    marequete.Parameters.AddWithValue("_ville_client", ville_client_txt.Text);
                    marequete.Parameters.AddWithValue("_codeP_client", codeP_client_txt.Text);
                    marequete.Parameters.AddWithValue("_province_client", province_client_txt.Text);
                    marequete.Parameters.AddWithValue("_tel_client", tel_client_txt.Text);
                    marequete.Parameters.AddWithValue("_mail_client", mail_client_txt.Text);
                    marequete.Parameters.AddWithValue("_n_programme", n_programme_txt.Text);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Soumission Réussie");
                    affiche(dataLoader(affichage));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void Suppression_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Delete From Individuel where id_client=" + search_txt.Text + " ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Client supprimé");
                    dataLoader(affichage);
                    GridFill();
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }
            }

        }

      

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Menu bWin = new Menu();
            bWin.Show();
            this.Close(); //only if you want to close the current form.
        }

        private void MAJ(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Update Individuel set nom_client = '" + nom_client_txt.Text + "', prenom_client = '" + prenom_client_txt.Text + "', rue_client = '" + rue_client_txt.Text + "',ville_client = '" + ville_client_txt.Text + "', codeP_client = '" + codeP_client_txt.Text + "', province_client = '" + province_client_txt.Text + "', tel_client = '" + tel_client_txt.Text + "', mail_client = '" + mail_client_txt.Text + "', n_programme = '" + n_programme_txt.Text + "' Where id_client = '" + search_txt.Text + "' ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Client mis à jour");
                    GridFill();
                    connexion.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Not Deleted" + ex.Message);
                }
            }

        }
    }
}
