using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class PlateformeDAO
    {
        private MySqlConnection maConnexion;

        public Plateforme GetById(int id)
        {
            Plateforme resPlateforme = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idplateforme, nomplateforme";
                requeteSql += " FROM plateforme WHERE idplateforme = " + id + "; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idplateforme = reader.GetInt32("idplateforme");
                            string nom = reader.GetString("nomplateforme");
                            resPlateforme = new Plateforme(idplateforme, nom);
                            return resPlateforme;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resPlateforme;
        }


        public List<Plateforme> GetListe()
        {
            List<Plateforme> resListe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idplateforme, nomplateforme FROM plateforme";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<Plateforme>();
                        while (reader.Read())
                        {
                            int idplateforme = reader.GetInt32("idplateforme");
                            string nomplateforme = reader.GetString("nomplateforme");

                            Plateforme nouvellePlateforme = new Plateforme(idplateforme, nomplateforme);
                            resListe.Add(nouvellePlateforme);
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

        public List<Plateforme> GetListeFromJeu(int idJeu)
        {
            List<Plateforme> resListe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT plateforme.idplateforme, nomplateforme FROM compatible ";
                requeteSql += " INNER JOIN plateforme ON compatible.IDPLATEFORME = plateforme.IDPLATEFORME ";
                requeteSql += " WHERE compatible.idjeu = " + idJeu + "; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<Plateforme>();
                        while (reader.Read())
                        {
                            int idplateforme = reader.GetInt32("idplateforme");
                            string nomplateforme = reader.GetString("nomplateforme");

                            Plateforme nouvellePlateforme = new Plateforme(idplateforme, nomplateforme);
                            resListe.Add(nouvellePlateforme);
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

        public bool Ajout(Plateforme plateformeAjout)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "INSERT INTO plateforme (nomplateforme)";
                requeteSql += $"VALUES ('{plateformeAjout.NomPlateforme}'); ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    if (lignesAffectees == 1)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de l'insertion. Lignes affectées : {lignesAffectees}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return false;
        }

        public bool Suppression(int idPlateforme)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"DELETE FROM plateforme WHERE idplateforme = {idPlateforme};";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    if (lignesAffectees == 1)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la suppression. Lignes affectées : {lignesAffectees}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return false;
        }

        public bool Modification(int idPlateforme, string nomPlateforme)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"UPDATE plateforme SET nomplateforme = '{nomPlateforme}' ";
                requeteSql += $" WHERE idplateforme = {idPlateforme};";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    if (lignesAffectees == 1)
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la modification. Lignes affectées : {lignesAffectees}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return false;
        }
    }
}
