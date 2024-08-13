using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class JeuDAO
    {
        
        private MySqlConnection maConnexion;

        public Jeu GetById(int id)
        {
            Jeu resJeu = null;
            PlateformeDAO plateformeDAO = new PlateformeDAO();
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idjeu, nomjeu, logoimage, genre, editeur ";
                requeteSql += " FROM jeu WHERE idjeu = " + id + "; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idjeu = reader.GetInt32("idjeu");
                            string nomjeu = reader.GetString("nomjeu");
                            string logoimage = reader.GetString("logoimage");
                            string genre = reader.GetString("genre");
                            string editeur = reader.GetString("editeur");
                            resJeu = new Jeu(idjeu, nomjeu, genre, editeur, logoimage, null);
                        }
                    }
                    if (plateformeDAO != null)
                    {
                        List<Plateforme> listePlateformes = plateformeDAO.GetListeFromJeu(resJeu.Id);
                        resJeu.ListePlateformes = new List<string>();
                        foreach (Plateforme plateforme in listePlateformes)
                        {
                            resJeu.ListePlateformes.Add(plateforme.NomPlateforme);
                        }
                    }
                    return resJeu;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resJeu;
        }


        public List<Jeu> GetListe()
        {
            List<Jeu> resListe = null;
            PlateformeDAO plateformeDAO = new PlateformeDAO();
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idjeu, nomjeu, logoimage, genre, editeur FROM jeu";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<Jeu>();
                        while (reader.Read())
                        {
                            int idjeu = reader.GetInt32("idjeu");
                            string nomjeu = reader.GetString("nomjeu");
                            string logoimage = reader.GetString("logoimage");
                            string genre = reader.GetString("genre");
                            string editeur = reader.GetString("editeur");
                            Jeu nouveauJeu = new Jeu(idjeu, nomjeu, genre, editeur, logoimage, null);
                            resListe.Add(nouveauJeu);
                        } 
                    }
                    if (plateformeDAO != null)
                    {
                        foreach (Jeu jeu in resListe)
                        {
                            List<Plateforme> listePlateformes = plateformeDAO.GetListeFromJeu(jeu.Id);
                            jeu.ListePlateformes = new List<string>();
                            foreach (Plateforme plateforme in listePlateformes)
                            {
                                jeu.ListePlateformes.Add(plateforme.NomPlateforme);
                            }
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

        public bool Ajout(Jeu jeuAjout)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "INSERT INTO jeu (nomjeu, logoimage, genre, editeur)";
                requeteSql += $"VALUES ('{jeuAjout.Nom}', '{jeuAjout.LogoImage}', ";
                requeteSql += $" '{jeuAjout.Genre}', '{jeuAjout.Editeur}'); ";

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

        public bool AjoutPlateformesJeu(int idJeu, List<Plateforme> listePlateformes)
        {
            bool resultat = true;
            try
            {
                if(listePlateformes != null)
                {
                    foreach (Plateforme plateforme in listePlateformes)
                    {
                        // Exécution de la requête SQL
                        string requeteSql = "INSERT INTO compatible (idjeu, idplateforme)";
                        requeteSql += $"VALUES ({idJeu}, {plateforme.Id}); ";

                        maConnexion = ConnexionBddDAO.GetInstance();
                        if (maConnexion != null)
                        {
                            MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                            int lignesAffectees = commande.ExecuteNonQuery();
                            if (lignesAffectees != 1)
                            {
                                Console.WriteLine($"Une erreur s'est produite lors de l'insertion. Lignes affectées : {lignesAffectees}");
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
                return false;
            }
            return resultat;
        }

        public bool Suppression(int idJeu)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"DELETE FROM jeu WHERE idjeu = {idJeu};";

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

        public bool Modification(int idJeu, Jeu jeuModif)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"UPDATE jeu SET nomjeu = '{jeuModif.Nom}',  logoimage = '{jeuModif.LogoImage}', ";
                requeteSql += $" genre = '{jeuModif.Genre}',  editeur = '{jeuModif.Editeur}' ";
                requeteSql += $" WHERE idjeu = {idJeu};";

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
