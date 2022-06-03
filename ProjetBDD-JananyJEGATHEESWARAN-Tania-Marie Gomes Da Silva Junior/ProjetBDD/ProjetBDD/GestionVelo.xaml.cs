using System;
using System.Windows;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour gestion_velo.xaml
    /// </summary>
    public partial class GestionVelo : Window
    {
        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";
        int num_modele = 0;
        public GestionVelo()
        {
            InitializeComponent();
            GridFill();
        }

        private void add_velo(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("AjouterVelo", connexion);
                    marequete.CommandType = CommandType.StoredProcedure;
                    marequete.Parameters.AddWithValue("_num_modele", num_modele);
                    marequete.Parameters.AddWithValue("_nom_modele", nom_modele_txt.Text);
                    marequete.Parameters.AddWithValue("_grandeur", grandeur_txt.Text);
                    marequete.Parameters.AddWithValue("_prix_unitaire_modele", prix_unitaire_modele_txt.Text);
                    marequete.Parameters.AddWithValue("_ligne_produit", ligne_produit_txt.Text);
                    marequete.Parameters.AddWithValue("_date_intro_modele", date_intro_modele_txt.Text);
                    marequete.Parameters.AddWithValue("_stock_velo", stock_velo_txt.Text);

                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Soumission Réussie");
                    GridFill();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
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
                MySqlCommand marequete = new MySqlCommand("VoirVelo", connexion);
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
                    MySqlCommand marequete = new MySqlCommand("Delete From modele where num_modele=" + num_modele_txt.Text + " ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("velo supprimé");
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

        private void Maj_velo(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Update modele set nom_modele = '" + nom_modele_txt.Text + "', grandeur = '" + grandeur_txt.Text + "',prix_unitaire_modele = '" + prix_unitaire_modele_txt.Text + "', ligne_produit = '" + ligne_produit_txt.Text + "', date_intro_modele = '" + date_intro_modele_txt.Text + "', date_discon_modele = '" + date_discon_modele_txt.Text + "', stock_velo = '" + stock_velo_txt.Text + "' Where num_modele = '" + num_modele_txt.Text + "' ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("velo mis à jour");
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