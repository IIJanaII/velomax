using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour PiecesRechanges.xaml
    /// </summary>
    public partial class PiecesRechange : Window
    {
        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";

        public PiecesRechange()
        {
            InitializeComponent();
            GridFill();
        }   
        private void add_Piece(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("AjouterPiece", connexion);
                    marequete.CommandType = CommandType.StoredProcedure;
                    marequete.Parameters.AddWithValue("_num_piece", num_piece_txt.Text);
                    marequete.Parameters.AddWithValue("_siret", siret_txt.Text);
                    marequete.Parameters.AddWithValue("_nom_fournisseur", nom_fournisseur_txt.Text);
                    marequete.Parameters.AddWithValue("_description_piece", description_piece_txt.Text);
                    marequete.Parameters.AddWithValue("_num_catalogue", num_catalogue_txt.Text);
                    marequete.Parameters.AddWithValue("_prix_piece", prix_piece_txt.Text);
                    marequete.Parameters.AddWithValue("_date_intro_piece", date_intro_piece_txt.Text);
                    marequete.Parameters.AddWithValue("_date_discon_piece", date_discon_piece_txt.Text);
                    marequete.Parameters.AddWithValue("_delais", delais_txt.Text);
                    marequete.Parameters.AddWithValue("_stock_piece", stock_piece_txt.Text);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Soumission Réussie");
                    GridFill();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }


            }
        }

        void GridFill()
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                /*
                connexion.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("VoirClients_e", connexion);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblClient_e = new DataTable();
                sqlDa.Fill(dtblClient_e);
                DataGrid.ItemsSourceProperty = dtblClient_e.DefaultView;
                connexion.Close();
                */
                MySqlCommand marequete = new MySqlCommand("VoirPiece", connexion);
                DataTable dt = new DataTable();
                connexion.Open();
                MySqlDataAdapter a = new MySqlDataAdapter(marequete);
                a.Fill(dt);
                connexion.Close();
                datagrid.ItemsSource = dt.DefaultView;

            }
        }

        private void Suppression_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Delete From pieceRechange where num_piece=" + num_piece_txt.Text + " ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Pièce supprimé");
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
                    MySqlCommand marequete = new MySqlCommand("Update pieceRechange set num_piece = '" + num_piece_txt.Text + "', siret = '" + siret_txt.Text + "', nom_fournisseur = '" + nom_fournisseur_txt.Text + "', description_piece = '" + description_piece_txt.Text + "', num_catalogue = '" + num_catalogue_txt.Text + "', prix_piece = '" + prix_piece_txt.Text + "', date_intro_piece = '" + date_intro_piece_txt.Text + "', date_discon_piece = '" + date_discon_piece_txt.Text + "', delais = '" + delais_txt.Text + "', stock_piece = '" + stock_piece_txt.Text + "' Where num_piece = '" + num_piece_txt.Text + "' ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Piece mis à jour");
                    GridFill();
                    connexion.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

        }
    }
}