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
        MySqlConnection maConnexion = ConnexionBddDAO.GetInstance();

        public List<Personne> GetListe()
        {
            List<Personne> listePlayers = new List<Personne>();
            try
            {
                Personne personneToList = null;
                // Exécution de la requête SQL
                string requeteSql = "SELECT * FROM personne;";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Ints
                            int playerID = reader.GetInt32("IDPERSONNE");
                            int numChambre = reader.GetInt32("NUMEROCHAMBRE");
                            int idEquipe = reader.GetInt32("IDEQUIPE");
                            // Strings
                            string pseudo = reader.GetString("PSEUDO");
                            string nomjoueur = reader.GetString("NOMJOUEUR");
                            string pays = reader.GetString("PAYS");
                            string role = reader.GetString("ROLE");
                            personneToList = new Personne(playerID, numChambre, idEquipe, pseudo,nomjoueur, pays, role);
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
        public Personne GetById(int id)
        {
            try
            {
                Personne personneFound = null;
                // Exécution de la requête SQL
                string requeteSql = $"SELECT * FROM personne WHERE idpersonne = {id};";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int playerID = reader.GetInt32("IDPERSONNE");
                            int numChambre = reader.GetInt32("NUMEROCHAMBRE");
                            int idEquipe = reader.GetInt32("IDEQUIPE");
                            string pseudo = reader.GetString("PSEUDO");
                            string nomjoueur = reader.GetString("NOMJOUEUR");
                            string pays = reader.GetString("PAYS");
                            string role = reader.GetString("ROLE");
                            personneFound = new Personne(playerID,numChambre,idEquipe, pseudo,nomjoueur, pays,role);
                            
                        }
                        
                    }
                }
                return personneFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public bool Ajout(Personne personneAjout)
        {
            try
            {
                string requestSql = $"INSERT INTO personne (NUMEROCHAMBRE, IDEQUIPE, PSEUDO, NOMJOUEUR, PAYS, ROLE) VALUES ({personneAjout.Numerochambre}, {personneAjout.Idequipe}, '{personneAjout.Pseudo}', '{personneAjout.Nomjoueur}', '{personneAjout.Pays}', '{personneAjout.Role}'); ";
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
        public bool Modification(int idPersonne, Personne personneModif)
        {
            try
            {
                string requestSql = $"UPDATE personne SET NUMEROCHAMBRE = '{personneModif.Numerochambre}', IDEQUIPE = '{personneModif.Idequipe}', PSEUDO = '{personneModif.Pseudo}', NOMJOUEUR = '{personneModif.Nomjoueur}', PAYS = '{personneModif.Pays}', ROLE = '{personneModif.Role}' WHERE IDPERSONNE = '{idPersonne}';";
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
        public bool Supression(int idPersonne)
        {
            try
            {
                string requestSql = $"DELETE FROM personne WHERE IDPERSONNE = '{idPersonne}';";
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
