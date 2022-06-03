using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour Commandes.xaml
    /// </summary>
    public partial class Commandes : Window
    {
        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";
        int id_commande_i = 0;
        int id_commande_e = 0;

        public Commandes()
        {
            InitializeComponent();
           
        }

        private void Creation_ClickE(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("AjouterCommandeE", connexion);
                    marequete.CommandType = CommandType.StoredProcedure;
                    marequete.Parameters.AddWithValue("_id_commande_e", id_commande_e);
                    marequete.Parameters.AddWithValue("_nom_e", nom_e_txt.Text);
                    marequete.Parameters.AddWithValue("_nom_modele", type_velo_txt.Text);
                    marequete.Parameters.AddWithValue("_description_piece", description_piece_txt.Text);
                    marequete.Parameters.AddWithValue("_quantite", quantite_txt.Text);
                    marequete.Parameters.AddWithValue("_rue_livraison", rue_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_ville_livraison", ville_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_codeP_livraison", codeP_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_province_livraison", province_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_date_livraison", date_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_date_commande", date_commande_txt.Text);

                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Soumission Réussie");
                    affiche(dataLoader("VoirCommande_e"));
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }
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



        private void MAJP(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Update commande_individuel set nom_client = '" + nom_client_txt.Text + "', nom_modele = '" + type_velo_txt.Text + "', description_piece = '" + description_piece_txt.Text + "', quantite = '" + quantite_txt.Text + "', rue_livraison = '" + rue_livraison_txt.Text + "', ville_livraison = '" + ville_livraison_txt.Text + "', codeP_livraison = '" + codeP_livraison_txt.Text + "', province_livraison = '" + province_livraison_txt.Text + "', date_livraison = '" + date_livraison_txt.Text + "', date_commande = '" + date_commande_txt.Text +  "' Where id_commande_individuel = '" + id_commande_txt.Text + "' ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Commande individu mis à jour");

                    connexion.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Not Deleted" + ex.Message);
                }
            }
        }

        private void SuppressionP_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Delete From commande_individuel where id_commande_individuel=" + id_commande_txt.Text + " ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("commande supprimé");
                    affiche(dataLoader("VoirCommande_p"));

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

        private void Creation_ClickP(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("AjouterCommandeI", connexion);
                    marequete.CommandType = CommandType.StoredProcedure;
                    marequete.Parameters.AddWithValue("_id_commande_individuel", id_commande_i);
                    marequete.Parameters.AddWithValue("_nom_client", nom_client_txt.Text);
                    marequete.Parameters.AddWithValue("_nom_modele", type_velo_txt.Text);
                    marequete.Parameters.AddWithValue("_description_piece", description_piece_txt.Text);
                    marequete.Parameters.AddWithValue("_quantite", quantite_txt.Text);
                    marequete.Parameters.AddWithValue("_rue_livraison", rue_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_ville_livraison", ville_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_codeP_livraison", codeP_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_province_livraison", province_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_date_livraison", date_livraison_txt.Text);
                    marequete.Parameters.AddWithValue("_date_commande", date_commande_txt.Text);

                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Soumission Réussie");
                    affiche(dataLoader("VoirCommande_p"));
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void SuppressionE_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    affiche(dataLoader("VoirCommande_e"));
                    MySqlCommand marequete = new MySqlCommand("Delete From commande_e where id_commande_e=" + id_commande_txt.Text + " ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("commande supprimé");
                    affiche(dataLoader("VoirCommande_e"));

                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void voirCommandeE_Click_(object sender, RoutedEventArgs e)
        {
            affiche(dataLoader("VoirCommande_e"));
        }

        private void voirCommandeI_Click(object sender, RoutedEventArgs e)
        {
            affiche(dataLoader("VoirCommande_p"));
        }

        private void MAJE(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Update commande_e set nom_e = '" + nom_e_txt.Text + "', nom_modele = '" + type_velo_txt.Text + "', description_piece = '" + description_piece_txt.Text + "', quantite = '" + quantite_txt.Text + "', rue_livraison = '" + rue_livraison_txt.Text + "', ville_livraison = '" + ville_livraison_txt.Text + "', codeP_livraison = '" + codeP_livraison_txt.Text + "', province_livraison = '" + province_livraison_txt.Text + "', date_livraison = '" + date_livraison_txt.Text + "', date_commande = '" + date_commande_txt.Text + "' Where id_commande_e = '" + id_commande_txt.Text + "' ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Commande entreprise mis à jour");

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

