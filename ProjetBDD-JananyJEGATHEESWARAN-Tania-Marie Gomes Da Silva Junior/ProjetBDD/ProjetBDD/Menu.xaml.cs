using MySql.Data.MySqlClient;
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
using System.Xml;


namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour Navigation.xaml
    /// </summary>
    public partial class Menu : Window
    {
        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";
        public Menu()
        {
            InitializeComponent();
        }   

        private void clients_e_Click(object sender, RoutedEventArgs e)
        {
            ClientE bWin = new ClientE();
            bWin.Show();
            this.Close(); 
        }

        private void commandes_Click(object sender, RoutedEventArgs e)
        {
            Commandes bWin = new Commandes();
            bWin.Show();
            this.Close(); 
        }

        private void clients_p_Click(object sender, RoutedEventArgs e)
        {
            ClientsP bWin = new ClientsP();
            bWin.Show();
            this.Close(); 
        }

        private void Statistiques_Click(object sender, RoutedEventArgs e)
        {
            Statistiques bWin = new Statistiques();
            bWin.Show();
            this.Close();
        }

        private void gestion_velos_Click(object sender, RoutedEventArgs e)
        {
            GestionVelo bWin = new GestionVelo();
            bWin.Show();
            this.Close();
        }

        private void fournisseurs_Click(object sender, RoutedEventArgs e)
        {
            Fournisseurs bWin = new Fournisseurs();
            bWin.Show();
            this.Close();

        }

        private void pieces_rechange_Click(object sender, RoutedEventArgs e)
        {
            PiecesRechange bWin = new PiecesRechange();
            bWin.Show();
            this.Close();
        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            Stock bWin = new Stock();
            bWin.Show();
            this.Close();
        }

        private void Exportation_Click(object sender, RoutedEventArgs e)
        {
           
                using (MySqlConnection connexion = new MySqlConnection(connexionInfo))
                {
                    try
                    {
                        string connexionString = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;PASSWORD=root";

                        MySqlConnection connection = new MySqlConnection(connexionString);
                        connection.Open();
                        string requete = "SELECT * FROM modele WHERE stock_velo<=2;";
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = requete;

                        XmlDocument docXml = new XmlDocument();
                        XmlElement racine = docXml.CreateElement("FichierXml_Database_Velomax");
                        docXml.AppendChild(racine);
                        XmlDeclaration xmldecl = docXml.CreateXmlDeclaration("1.0", "UTF-8", "no");
                        docXml.InsertBefore(xmldecl, racine);

                        XmlElement produit = docXml.CreateElement("produit");
                        XmlElement num_modele = docXml.CreateElement("num_modele");
                        XmlElement stock_velo = docXml.CreateElement("stock_velo");
                        XmlElement ligne_produit = docXml.CreateElement("ligne_produit");

                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            num_modele.InnerText = reader.GetString(0);
                            produit.AppendChild(num_modele);
                            stock_velo.InnerText = reader.GetString(7);
                            produit.AppendChild(stock_velo);
                            ligne_produit.InnerText = reader.GetString(4);
                            produit.AppendChild(ligne_produit);
                            racine.AppendChild(produit);
                            produit = docXml.CreateElement("produit");
                            num_modele = docXml.CreateElement("num_modele");
                            stock_velo = docXml.CreateElement("quantite");
                            ligne_produit = docXml.CreateElement("ligne_produit");
                        }



                        docXml.Save("C:\\Users\\jega_\\Downloads\\wetransfer_projetbdd_2022-05-17_0916\\ProjetBDD " + "Fichier.xml");
                        MessageBox.Show("Exportation réussie de la table filtrée Stock en XML");
                    }
                    catch
                    {
                        MessageBox.Show("Problème lors de l'insertion du messsage");
                    }
                }
            
        }
    }
}
