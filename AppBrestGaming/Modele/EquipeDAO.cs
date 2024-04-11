using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppBrestGaming.Modele
{
    public class EquipeDAO
    {
        private List<Equipe> listeEquipes;
        // Connexion SQL :
        MySqlConnection maConnexion = ConnexionBddDAO.GetInstance();
        public List<Modele.Equipe> GetListeEquipes()
        {
            listeEquipes = new List<Modele.Equipe>();
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT * FROM equipe;";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int equipeID = reader.GetInt32("IDEQUIPE");
                            string nomEquipe = reader.GetString("NOMEQUIPE");
                            string siteWeb = reader.GetString("SITEWEB");
                            string logo = reader.GetString("LOGOEQUIPE");
                            Equipe EquipeToAdd = new Equipe(equipeID, nomEquipe, siteWeb, logo,null);
                            listeEquipes.Add(EquipeToAdd);
                        }

                    }
                    foreach (Modele.Equipe equipe in listeEquipes)
                    {
                        equipe.ListeJoueurs = GetListeFromEquipe(equipe.Id);
                    }
                    return listeEquipes;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        private List<Personne> GetListeFromEquipe(int idEquipe) // utiliser pour les recherches des équipes par ID et nom
        {
            List<Personne> listePlayers = new List<Personne>();
            try
            {
                Personne personneToList = null;
                // Exécution de la requête SQL
                string requeteSql = $"SELECT * FROM personne WHERE IDEQUIPE = {idEquipe};";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int playerID = reader.GetInt32("IDPERSONNE");
                            int numChambre = reader.GetInt32("NUMEROCHAMBRE");
                            int idEquipeJoueur = reader.GetInt32("IDEQUIPE");
                            string pseudo = reader.GetString("PSEUDO");
                            string nomjoueur = reader.GetString("NOMJOUEUR");
                            string pays = reader.GetString("PAYS");
                            string role = reader.GetString("ROLE");
                            personneToList = new Personne(playerID, numChambre, idEquipeJoueur, pseudo, nomjoueur, pays, role);
                            listePlayers.Add(personneToList);
                        }

                    }
                }
                return listePlayers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public Equipe GetEquipeById(int id) // Renvoie les informations avec une liste de joueurs (objet Personne)
        {
            try
            {
                Equipe equipeResultat = null;
                // Exécution de la requête SQL
                string requeteSql = $"SELECT * FROM equipe WHERE IDEQUIPE = {id};";
                if (maConnexion  != null)
                {
                    List<Personne> listePlayers = new List<Personne>();
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            int idEquipe = reader.GetInt32("IDEQUIPE");
                            string nomEquipe = reader.GetString("NOMEQUIPE");
                            string siteEquipe = reader.GetString("SITEWEB");
                            string logoEquipe = reader.GetString("LOGOEQUIPE");
                            equipeResultat = new Equipe(idEquipe, nomEquipe, siteEquipe, logoEquipe, listePlayers);
                        }
                    }
                    listePlayers = GetListeFromEquipe(equipeResultat.Id);
                    equipeResultat.ListeJoueurs = listePlayers;
                }
                return equipeResultat;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public Equipe GetEquipeByNom(string nomEquipe) // Renvoie les informations avec une liste de joueurs (objet Personne)
        {
            try
            {
                Equipe equipeResultat = null;
                // Exécution de la requête SQL
                string requeteSql = $"SELECT * FROM equipe WHERE NOMEQUIPE = '{nomEquipe}';";
                if (maConnexion != null)
                {
                    List<Personne> listePlayers = new List<Personne>();
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idEquipe = reader.GetInt32("IDEQUIPE");
                            string nomTeam = reader.GetString("NOMEQUIPE");
                            string siteEquipe = reader.GetString("SITEWEB");
                            string logoEquipe = reader.GetString("LOGOEQUIPE");
                            equipeResultat = new Equipe(idEquipe, nomTeam, siteEquipe, logoEquipe, listePlayers);
                        }
                    }
                    listePlayers = GetListeFromEquipe(equipeResultat.Id);
                    equipeResultat.ListeJoueurs = listePlayers;
                }
                return equipeResultat;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public bool AjoutEquipe(Equipe nouvelleEquipe)
        {
            try
            {
                string requestSql = $"INSERT INTO equipe (NOMEQUIPE, SITEWEB, LOGOEQUIPE) VALUES ('{nouvelleEquipe.Nom}', '{nouvelleEquipe.SiteWeb}', 'null'); ";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requestSql, maConnexion);
                    maConnexion.Open();
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