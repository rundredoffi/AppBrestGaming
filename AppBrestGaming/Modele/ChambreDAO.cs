using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AppBrestGaming.Modele
{
    public class ChambreDAO
    {
        private MySqlConnection maConnexion;

        public Chambre GetById(int id)
        {
            Chambre resChambre = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT numerochambre, etage, capacite, prix ";
                requeteSql += " FROM chambre WHERE numChambre = " + id + "; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int numChambre = reader.GetInt32("numerochambre");
                            int etage = reader.GetInt32("etage");
                            int capacite = reader.GetInt32("capacite");
                            float prix = reader.GetFloat("prix");

                            resChambre = new Chambre(numChambre, etage, capacite, prix);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resChambre;
        }

        public List<Chambre> GetListe()
        {
            List<Chambre> resListe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT numerochambre, etage, capacite, prix ";
                requeteSql += " FROM chambre; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<Chambre>();
                        while (reader.Read())
                        {
                            int numChambre = reader.GetInt32("numerochambre");
                            int etage = reader.GetInt32("etage");
                            int capacite = reader.GetInt32("capacite");
                            float prix = reader.GetFloat("prix");

                            Chambre nouvelleChambre = new Chambre(numChambre, etage, capacite, prix);
                            resListe.Add(nouvelleChambre);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resListe;
        }
    }
}
