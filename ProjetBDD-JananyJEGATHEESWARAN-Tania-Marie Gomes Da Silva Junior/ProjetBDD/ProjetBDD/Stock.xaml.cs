using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour Stock.xaml
    /// </summary>
    public partial class Stock : Window
    {

        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";

        public Stock()
        {
            InitializeComponent();
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

        private void Stock_Pieces_Click(object sender, RoutedEventArgs e)
        {
                string affichage1 = "select num_piece, description_piece, nom_fournisseur,stock_piece from pieceRechange group by num_piece";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage1));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void Stock_Fournisseur_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select nom_fournisseur,num_piece,stock_piece from pieceRechange group by num_piece";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage1));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void Stock_Velo_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select num_modele,nom_modele,stock_velo from modele group by num_modele";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage1));
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

        private void stock_modele_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select num_modele,nom_modele,ligne_produit,stock_velo from modele where nom_modele = " +search1_txt.Text+" order by ligne_produit";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage1));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void stock_marque_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select num_modele,nom_modele,ligne_produit,stock_velo from modele where ligne_produit = " + search2_txt.Text + " order by ligne_produit";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage1));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void gestion_stock_v_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "Gestion_Stock_V    ";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage1));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void gestion_stock_p_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "Gestion_Stock_P";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage1));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }
    }
}
