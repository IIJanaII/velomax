using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Utilisateur_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Connexionbase(object sender, RoutedEventArgs e)
        {
            MySqlConnection maConnexion = null;
            try
            {
                string connexionString = "SERVER=localhost;PORT=3306;" +
                                         "DATABASE=velomax;" +
                                         "UID=" + Utilisateur.Text + ";PASSWORD=" + Convert.ToString(Mdp.Password) + ";";

                maConnexion = new MySqlConnection(connexionString);
                maConnexion.Open();
                MessageBox.Show("Connexion réussite");
                Menu bWin = new Menu();
                bWin.Show();
                this.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(" ErreurConnexion : " + ex.ToString());
                return;
            }
        }
    }
}
