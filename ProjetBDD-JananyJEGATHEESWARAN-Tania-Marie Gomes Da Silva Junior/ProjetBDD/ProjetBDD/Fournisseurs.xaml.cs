
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour Fournisseurs.xaml
    /// </summary>
    /// <summary>
    /// Logique d'interaction pour Fournisseurs.xaml
    /// </summary>
    public partial class Fournisseurs : Window
    {
        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";

        public Fournisseurs()
        {
            InitializeComponent();
            GridFill();
        }
        private void add_Fournisseur(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("AjouterFournisseur", connexion);
                    marequete.CommandType = CommandType.StoredProcedure;
                    marequete.Parameters.AddWithValue("_siret", siret_txt.Text);
                    marequete.Parameters.AddWithValue("_nom_fournisseur", nom_fournisseur_txt.Text);
                    marequete.Parameters.AddWithValue("_contact", contact_txt.Text);
                    marequete.Parameters.AddWithValue("_rue_fournisseur", rue_fournisseur_txt.Text);
                    marequete.Parameters.AddWithValue("_ville_fournisseur", ville_fournisseur_txt.Text);
                    marequete.Parameters.AddWithValue("_codeP_fournisseur", codeP_fournisseur_txt.Text);
                    marequete.Parameters.AddWithValue("_province_fournisseur", province_fournisseur_txt.Text);
                    marequete.Parameters.AddWithValue("_libelle", libelle_txt.Text);
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
                MySqlCommand marequete = new MySqlCommand("VoirFournisseur", connexion);
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
                    MySqlCommand marequete = new MySqlCommand("Delete From fournisseur where siret=" + search_txt.Text + " ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Fournisseur supprimé");
                    GridFill();
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Update Fournisseur set siret = '" + siret_txt.Text + "', nom_fournisseur = '" + nom_fournisseur_txt.Text + "', rue_fournisseur = '" + rue_fournisseur_txt.Text + "',ville_fournisseur = '" + ville_fournisseur_txt.Text + "', codeP_fournisseur = '" + codeP_fournisseur_txt.Text + "', province_fournisseur = '" + province_fournisseur_txt.Text + "', libelle = '" + libelle_txt.Text + "' Where siret = '" + search_txt.Text + "' ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Fournisseur mis à jour");
                    GridFill();
                    connexion.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Not Deleted" + ex.Message);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Menu bWin = new Menu();
            bWin.Show();
            this.Close(); //only if you want to close the current form.
        }
    }
}
