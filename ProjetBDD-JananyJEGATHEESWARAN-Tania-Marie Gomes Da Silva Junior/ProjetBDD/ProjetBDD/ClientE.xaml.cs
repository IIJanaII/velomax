using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace ProjetBDD
{   
    /// <summary>
   
    /// </summary>
    public partial class ClientE : Window
    {

        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";
        int id_entreprise = 0;


        public ClientE()
        {
            InitializeComponent();

            GridFill();        
        }

     

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("AjouterEntreprise", connexion);
                    marequete.CommandType = CommandType.StoredProcedure;
                    marequete.Parameters.AddWithValue("_id_entreprise", id_entreprise);
                    marequete.Parameters.AddWithValue("_nom_entreprise", nom_entreprise_txt.Text);
                    marequete.Parameters.AddWithValue("_rue_entreprise", rue_entreprise_txt.Text);
                    marequete.Parameters.AddWithValue("_ville_entreprise", ville_entreprise_txt.Text);
                    marequete.Parameters.AddWithValue("_codeP_entreprise", codeP_entreprise_txt.Text);
                    marequete.Parameters.AddWithValue("_province_entreprise", province_entreprise_txt.Text);
                    marequete.Parameters.AddWithValue("_tel_entreprise", tel_entreprise_txt.Text);
                    marequete.Parameters.AddWithValue("_courriel_entreprise", courriel_entreprise_txt.Text);
                    marequete.Parameters.AddWithValue("_nom_contact", nom_contact_txt.Text);
                    marequete.Parameters.AddWithValue("_remise_e", remise_e_txt.Text);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Soumission Réussie");
                    GridFill();

                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Soumission Réussie");
                    GridFill();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }

            }
        }

        void GridFill()
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                MySqlCommand marequete = new MySqlCommand("VoirClients_e", connexion);
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
                    MySqlCommand marequete = new MySqlCommand("Delete From Entreprise where id_entreprise=" +search_txt.Text+" ", connexion);
                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Client supprimé");
                    GridFill();
                    connexion.Close();
                }
    
                catch(MySqlException ex)
                {
                    MessageBox.Show("Erreur" +ex.Message);
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
                    MySqlCommand marequete = new MySqlCommand("Update Entreprise set nom_entreprise = '" + nom_entreprise_txt.Text + "', rue_entreprise = '" + rue_entreprise_txt.Text + "', codeP_entreprise = '" + codeP_entreprise_txt.Text + "', province_entreprise = '" + province_entreprise_txt.Text + "', tel_entreprise = '" + tel_entreprise_txt.Text + "', courriel_entreprise = '" + courriel_entreprise_txt.Text + "', nom_contact = '" + nom_contact_txt.Text + "', remise_e = '" + remise_e_txt.Text + "' Where id_entreprise = '" + search_txt.Text + "' ", connexion);

                    marequete.ExecuteNonQuery();
                    MessageBox.Show("Client mis à jour");
                    GridFill();
                    connexion.Close();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Not Deleted" + ex.Message);
                }
            }
        }


        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Menu bWin = new Menu();
            bWin.Show();
            this.Close();
        }

        private void MAJ(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MySqlCommand marequete = new MySqlCommand("Update Entreprise set nom_entreprise = '" + nom_entreprise_txt.Text + "', rue_entreprise = '" + rue_entreprise_txt.Text + "',ville_entreprise = '" + ville_entreprise_txt.Text + "', codeP_entreprise = '" + codeP_entreprise_txt.Text + "', province_entreprise = '" + province_entreprise_txt.Text + "', tel_entreprise = '" + tel_entreprise_txt.Text + "', courriel_entreprise = '" + courriel_entreprise_txt.Text + "', nom_contact = '" + nom_contact_txt.Text + "', remise_e = '" + remise_e_txt.Text + "' Where id_entreprise = '" + search_txt.Text + "' ", connexion);
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


