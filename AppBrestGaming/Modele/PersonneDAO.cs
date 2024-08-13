using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class PersonneDAO
    {
        private MySqlConnection maConnexion;

        public Personne GetById(int id)
        {
            Personne resPersonne = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idpersonne, pseudo, nomjoueur, pays, role, numerochambre, idequipe";
                requeteSql += " FROM personne WHERE idpersonne = " + id + "; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idpersonne = reader.GetInt32("idpersonne");
                            string pseudo = reader.GetString("pseudo");
                            string nomJoueur = reader.GetString("nomjoueur");
                            string pays = reader.GetString("pays");
                            string role = reader.GetString("role");
                            int numChambre = reader.GetInt32("numerochambre");
                            int idequipe = reader.GetInt32("idequipe");

                            resPersonne = new Personne(idpersonne, pseudo, nomJoueur, pays, role, idequipe, numChambre);
                            return resPersonne;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resPersonne;
        }

        public List<Personne> GetListe()
        {
            List<Personne> resListe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idpersonne, pseudo, nomjoueur, pays, role, numerochambre, idequipe ";
                requeteSql += " FROM personne";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<Personne>();
                        while (reader.Read())
                        {
                            int idpersonne = reader.GetInt32("idpersonne");
                            string pseudo = reader.GetString("pseudo");
                            string nomJoueur = reader.GetString("nomjoueur");
                            string pays = reader.GetString("pays");
                            string role = reader.GetString("role");
                            int numChambre = reader.GetInt32("numerochambre");
                            int idequipe = reader.GetInt32("idequipe");

                            Personne nouvellePersonne = new Personne(idpersonne, pseudo, nomJoueur, pays, role, idequipe, numChambre);
                            resListe.Add(nouvellePersonne);
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

        public List<Personne> GetListeFromEquipe(int idEquipe)
        {
            List<Personne> resListe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idpersonne, pseudo, nomjoueur, pays, role, numerochambre, idequipe ";
                requeteSql += " FROM personne WHERE idequipe = " + idEquipe + "; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<Personne>();
                        while (reader.Read())
                        {
                            int idpersonne = reader.GetInt32("idpersonne");
                            string pseudo = reader.GetString("pseudo");
                            string nomJoueur = reader.GetString("nomjoueur");
                            string pays = reader.GetString("pays");
                            string role = reader.GetString("role");
                            int numChambre = reader.GetInt32("numerochambre");
                            int idequipe = reader.GetInt32("idequipe");

                            Personne nouvellePersonne = new Personne(idpersonne, pseudo, nomJoueur, pays, role, idequipe, numChambre);
                            resListe.Add(nouvellePersonne);
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

        public bool Ajout(Personne personneAjout)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "INSERT INTO personne (NUMEROCHAMBRE, IDEQUIPE, PSEUDO, NOMJOUEUR, PAYS, ROLE)";
                requeteSql += $"VALUES ({personneAjout.NumChambre}, {personneAjout.IdEquipe}, ";
                requeteSql += $"'{personneAjout.Pseudo}', '{personneAjout.NomJoueur}', ";
                requeteSql += $"'{personneAjout.Pays}', '{personneAjout.Role}'); ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    // Vérification du nombre de lignes affectées par la commande (doit être 1 si l'insertion est réussie)
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

        public bool Suppression(int idPersonne)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"DELETE FROM personne WHERE idpersonne = {idPersonne};";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    // Vérification du nombre de lignes affectées par la commande (doit être 1 si la suppression est réussie)
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

        public bool Modification(int idPersonne, Personne personneModif)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"UPDATE personne SET NOMJOUEUR = '{personneModif.NomJoueur}', ";
                requeteSql += $"PSEUDO = '{personneModif.Pseudo}', PAYS = '{personneModif.Pays}', ";
                requeteSql += $"ROLE = '{personneModif.Role}', NUMEROCHAMBRE = {personneModif.NumChambre.ToString()}, ";
                requeteSql += $"IDEQUIPE = {personneModif.IdEquipe} ";
                requeteSql += $" WHERE idpersonne = {idPersonne};";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    // Vérification du nombre de lignes affectées par la commande (doit être 1 si la modification est réussie)
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
