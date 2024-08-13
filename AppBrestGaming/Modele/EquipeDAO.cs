using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppBrestGaming.Modele
{
    public class EquipeDAO
    {
        private MySqlConnection maConnexion;

        public Equipe GetById(int id)
        {
            Equipe resEquipe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idequipe, nomequipe, siteweb, logoequipe";
                requeteSql += " FROM equipe WHERE idequipe = " + id + "; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idequipe = reader.GetInt32("idequipe");
                            string nomequipe = reader.GetString("nomequipe");
                            string siteweb = reader.GetString("siteweb");
                            string logoequipe = reader.GetString("logoequipe");

                            resEquipe = new Equipe(idequipe, nomequipe, siteweb, logoequipe, null);
                        }
                    }
                    PersonneDAO persDAO = new PersonneDAO();
                    List<Personne> personnesEquipe = persDAO.GetListeFromEquipe(id);
                    resEquipe.ListeJoueurs = personnesEquipe;
                    return resEquipe;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resEquipe;
        }

        public List<Equipe> GetListe()
        {
            List<Equipe> resListe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idequipe, nomequipe, siteweb, logoequipe ";
                requeteSql += " FROM equipe";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<Equipe>();
                        while (reader.Read())
                        {
                            int idequipe = reader.GetInt32("idequipe");
                            string nomequipe = reader.GetString("nomequipe");
                            string siteweb = reader.GetString("siteweb");
                            string logoequipe = reader.GetString("logoequipe");
                            Equipe nouvelleEquipe = new Equipe(idequipe, nomequipe, siteweb, logoequipe, null);
                            resListe.Add(nouvelleEquipe);
                        }
                    }
                    PersonneDAO persDAO = new PersonneDAO();
                    foreach (Equipe eq in resListe)
                    {
                        List<Personne> personnesEquipe = persDAO.GetListeFromEquipe(eq.Id);
                        eq.ListeJoueurs = personnesEquipe;
                    }
                    return resListe;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resListe;
        }

        public bool Ajout(Equipe equipeAjout)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "INSERT INTO equipe (NOMEQUIPE, SITEWEB, LOGOEQUIPE)";
                requeteSql += $"VALUES ('{equipeAjout.Nom}', ";
                requeteSql += $"'{equipeAjout.SiteWeb}', '{equipeAjout.ImageEquipe}'); ";

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

        public bool Suppression(int idEquipe)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"DELETE FROM equipe WHERE idequipe = {idEquipe};";

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

        public bool Modification(int idEquipe, Equipe equipeModif)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"UPDATE equipe SET NOMEQUIPE = '{equipeModif.Nom}', ";
                requeteSql += $"SITEWEB = '{equipeModif.SiteWeb}', LOGOEQUIPE = '{equipeModif.ImageEquipe}' ";
                requeteSql += $" WHERE idequipe = {idEquipe};";

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
