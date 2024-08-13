using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AppBrestGaming.Modele
{
    public class UserDAO
    {
        private MySqlConnection maConnexion;

        public User GetById(int id)
        {
            User resUser = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idUser, prenom, login, password, role ";
                requeteSql += " FROM users WHERE idUser = " + id + "; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idUser = reader.GetInt32("idUser");
                            string prenom = reader.GetString("prenom");
                            string login = reader.GetString("login");
                            string password = reader.GetString("password");
                            string role = reader.GetString("role");

                            resUser = new User(idUser, prenom, login, password, role);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resUser;
        }

        public User GetByLogin(string login)
        {
            User resUser = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idUser, prenom, password, role ";
                requeteSql += " FROM users WHERE login = '" + login + "'; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idUser = reader.GetInt32("idUser");
                            string prenom = reader.GetString("prenom");
                            string password = reader.GetString("password");
                            string role = reader.GetString("role");

                            resUser = new User(idUser, prenom, login, password, role);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
            }
            return resUser;
        }

        public List<Role> GetListeRole()
        {
            List<Role> resListe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT id, role ";
                requeteSql += " FROM role; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<Role>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string role = reader.GetString("role");

                            Role nouveauRole = new Role(id, role);
                            resListe.Add(nouveauRole);
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

        public List<User> GetListe()
        {
            List<User> resListe = null;
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "SELECT idUser, prenom, login, password, role ";
                requeteSql += " FROM users; ";

                maConnexion = ConnexionBddDAO.GetInstance();
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    // Exécution de la commande et lecture des résultats
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        resListe = new List<User>();
                        while (reader.Read())
                        {
                            int idUser = reader.GetInt32("idUser");
                            string prenom = reader.GetString("prenom");
                            string login = reader.GetString("login");
                            string password = reader.GetString("password");
                            string role = reader.GetString("role");

                            User nouveauUser = new User(idUser, prenom, login, password, role);
                            resListe.Add(nouveauUser);
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

        public bool Ajout(User userAjout)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = "INSERT INTO users (prenom, login, password, role)";
                requeteSql += $"VALUES ('{userAjout.Prenom}', '{userAjout.Login}', ";
                requeteSql += $"'{userAjout.Password}', '{userAjout.Role}'); ";

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

        public bool Suppression(int idUser)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"DELETE FROM users WHERE idUser = {idUser};";

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

        public bool Modification(int idUser, User userModif)
        {
            try
            {
                // Exécution de la requête SQL
                string requeteSql = $"UPDATE users SET prenom = '{userModif.Prenom}', ";
                requeteSql += $"login = '{userModif.Login}', password = '{userModif.Password}', ";
                requeteSql += $"role = '{userModif.Role}' ";
                requeteSql += $" WHERE idUser = {idUser};";

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
