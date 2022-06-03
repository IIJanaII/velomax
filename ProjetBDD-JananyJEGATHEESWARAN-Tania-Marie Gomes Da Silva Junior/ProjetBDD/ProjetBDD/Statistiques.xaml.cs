using System;
using System.Windows;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour Statistiques.xaml
    /// </summary>
    public partial class Statistiques : Window
    {
        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";

        public Statistiques()
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
             
            }
        }

        public void affiche(DataTable data)
        {
            datagrid.ItemsSource = data.DefaultView;
            //Permet l'affichage d'une DataTable dans un DataGrid
        }

        private void Qte_Vendue_E_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select nom_modele, description_piece, quantite from commande_e group by nom_modele; ";

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

        private void Qte_Vendue_P_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select nom_modele, description_piece, quantite from commande_individuel group by nom_modele; ";

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

        private void Membres_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select f.n_programme, id_client,nom_client,prenom_client from Individuel c inner join fidelio f on f.n_programme=c.n_programme group by f.n_programme; ";

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

        

        private void Client_P_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select p.id_client,p.nom_client,count(c.id_commande_individuel), sum(quantite) from Individuel p inner join commande_individuel c on c.nom_client = p.nom_client group by p.id_client order by sum(quantite) DESC;";
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

        private void Clients_E_Click(object sender, RoutedEventArgs e)
        {
            string affichage1 = "select e.id_entreprise,e.nom_entreprise,count(c.id_commande_e), sum(quantite) from Entreprise e inner join commande_e c on c.nom_e = e.nom_entreprise group by e.id_entreprise order by sum(quantite) DESC;";
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

        private void adhésion_fin_Click(object sender, RoutedEventArgs e)
        {
                string affichage1 = "Adhésion_Fin";
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

        private void Moyenne_E_V_Click(object sender, RoutedEventArgs e)
        {
           
            string affichage = "select avg(quantite) from commande_e where description_piece='0'";
            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }
            }
        }

        private void Moyenne_E_P_Click(object sender, RoutedEventArgs e)
        {
            string affichage = "select avg(quantite) from commande_e where nom_modele='0'";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }
            }
        }

        private void Moyenne_P_V_Click(object sender, RoutedEventArgs e)
        {
            string affichage = "select avg(quantite) from commande_individuel where description_piece='0';";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage));
                    connexion.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur" + ex.Message);
                }
            }
        }

        private void Moyenne_P_P_Click(object sender, RoutedEventArgs e)
        {
            string affichage = "select avg(quantite) from commande_individuel where nom_modele='0'";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage));
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
            this.Close();
        }

        private void liste_clients_Click(object sender, RoutedEventArgs e)
        {
            string affichage = "select nom_client from Individuel UNION select nom_entreprise from Entreprise";

            using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
            {
                try
                {
                    connexion.Open();
                    MessageBox.Show("Réussite");
                    affiche(dataLoader(affichage));
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
