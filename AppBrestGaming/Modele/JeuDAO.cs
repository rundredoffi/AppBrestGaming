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
        MySqlConnection maConnexion = ConnexionBddDAO.GetInstance();
        public List<Jeu> GetListe()
        {
            List<Jeu> listeJeux = new List<Jeu>();
            try
            {
                Jeu jeuToAdd = null;
                // Exécution de la requête SQL
                string requeteSql = "SELECT * FROM jeu;";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idJeu = reader.GetInt32("IDJEU");
                            string nomJeu = reader.GetString("NOMJEU");
                            string genreJeu = reader.GetString("GENRE");
                            string editeurJeu = reader.GetString("EDITEUR");
                            string logoImage = reader.GetString("LOGOIMAGE");
                            jeuToAdd = new Jeu(idJeu, nomJeu, genreJeu,editeurJeu,logoImage, null);
                            listeJeux.Add(jeuToAdd);
                        }
                    }
                }
                foreach(Jeu jeuPlat in listeJeux)
                {
                    jeuPlat.ListePlateformes = GetListeFromCompatible(jeuPlat.IdJeu);
                }
                return listeJeux;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        private List<Plateforme> GetListeFromCompatible(int idJeu) // utiliser pour les recherches des équipes par ID et nom
        {
            List<Plateforme> listePlateformes = new List<Plateforme>();
            try
            {
                Plateforme plateformeToList = null;
                // Exécution de la requête SQL
                string requeteSql = $"SELECT * FROM compatible INNER JOIN plateforme ON compatible.IDPLATEFORME = plateforme.IDPLATEFORME WHERE IDJEU = {idJeu};";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPlateforme = reader.GetInt32("IDPLATEFORME");
                            string nomPlateforme = reader.GetString("NOMPLATEFORME");
                            plateformeToList = new Plateforme(idPlateforme, nomPlateforme);
                            listePlateformes.Add(plateformeToList);
                        }

                    }
                }
                return listePlateformes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public Jeu GetById(int id)
        {
            try
            {
                Jeu jeuFound = null;
                // Exécution de la requête SQL
                string requeteSql = $"SELECT * FROM jeu WHERE IDJEU = {id};";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idJeu = reader.GetInt32("IDJEU");
                            string nomJeu = reader.GetString("NOMJEU");
                            string genreJeu = reader.GetString("GENRE");
                            string editeurJeu = reader.GetString("EDITEUR");
                            string logoImage = reader.GetString("LOGOIMAGE");
                            List<Plateforme> listePlatforme = new List<Plateforme>();
                            jeuFound = new Jeu(idJeu,nomJeu,genreJeu,editeurJeu,logoImage, listePlatforme);
                        }

                    }
                    jeuFound.ListePlateformes = GetListeFromCompatible(jeuFound.IdJeu);
                }
                return jeuFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public bool Ajout(Jeu jeuAjout)
        {
            try
            {
                string requestSql = $"INSERT INTO jeu (IDJEU, NOMJEU,GENRE, EDITEUR, LOGOIMAGE) VALUES ({jeuAjout.IdJeu}, '{jeuAjout.Nom}', '{jeuAjout.Genre}','{jeuAjout.Editeur}','{jeuAjout.LogoImage}');";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requestSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    if (lignesAffectees == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public bool Modification(int idJeu, Jeu jeuModif)
        {
            try
            {
                string requestSql = $"UPDATE jeu SET IDJEU = '{idJeu}', NOMJEU = '{jeuModif.Nom}', GENRE = '{jeuModif.Genre}', EDITEUR = '{jeuModif.Editeur}', LOGOIMAGE = '{jeuModif.LogoImage}' WHERE IDJEU = '{idJeu}';";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requestSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    if (lignesAffectees == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public bool Supression(int idJeu)
        {
            try
            {
                string requestSql = $"DELETE FROM jeu WHERE IDJEU = '{idJeu}';";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requestSql, maConnexion);
                    int lignesAffectees = commande.ExecuteNonQuery();
                    if (lignesAffectees == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}