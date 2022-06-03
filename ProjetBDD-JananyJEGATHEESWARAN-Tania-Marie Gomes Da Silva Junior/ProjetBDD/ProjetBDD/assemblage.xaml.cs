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
using System.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Xml;

namespace ProjetBDD
{
    /// <summary>
    /// Logique d'interaction pour assemblage.xaml
    /// </summary>
    public partial class assemblage : Window
    {
        string connexionInfo = "SERVER=localhost;PORT=3306;DATABASE=velomax;UID=root;Password=root";
        public assemblage()
        {
            InitializeComponent();

            
        }

        private void Exportation_Click1(object sender, RoutedEventArgs e)
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

                    private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Menu bWin = new Menu();
            bWin.Show();
            this.Close(); //only if you want to close the current form.
        }
    }
}
