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
        MySqlConnection maConnexion = ConnexionBddDAO.GetInstance();
        public List<Plateforme> GetListe()
        {
            List<Plateforme> listePlateformes = new List<Plateforme>();
            try
            {
                Plateforme plateformeToAdd = null;
                // Exécution de la requête SQL
                string requeteSql = "SELECT * FROM plateforme;";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPlateforme = reader.GetInt32("IDPLATEFORME");
                            string nomPlateforme = reader.GetString("NOMPLATEFORME");
                            plateformeToAdd = new Plateforme(idPlateforme,nomPlateforme);
                            listePlateformes.Add(plateformeToAdd);

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
        public List<Plateforme> GetListeFromJeu(int idJeu)
        {
            List<Plateforme> listePlateformes = new List<Plateforme>();
            try
            {
                Plateforme plateformeToAdd = null;
                // Exécution de la requête SQL
                string requeteSql = $"SELECT compatible.IDPLATEFORME, plateforme.NOMPLATEFORME FROM compatible INNER JOIN plateforme ON plateforme.IDPLATEFORME = compatible.IDPLATEFORME WHERE compatible.IDJEU = {idJeu}; ";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPlateforme = reader.GetInt32("IDPLATEFORME");
                            string nomPlateforme = reader.GetString("NOMPLATEFORME");
                            plateformeToAdd = new Plateforme(idPlateforme, nomPlateforme);
                            listePlateformes.Add(plateformeToAdd);

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
        public Plateforme GetById(int id)
        {
            try
            {
                Plateforme plateformeFound = null;
                // Exécution de la requête SQL
                string requeteSql = $"SELECT * FROM plateforme WHERE IDPLATEFORME = {id};";
                if (maConnexion != null)
                {
                    MySqlCommand commande = new MySqlCommand(requeteSql, maConnexion);
                    using (MySqlDataReader reader = commande.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPlateforme = reader.GetInt32("IDPLATEFORME");
                            string nomPlateforme = reader.GetString("NOMPLATEFORME");
                            plateformeFound = new Plateforme(idPlateforme, nomPlateforme);
                        }

                    }
                }
                return plateformeFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public bool Ajout(Plateforme plateformeAjout)
        {
            try
            {
                string requestSql = $"INSERT INTO plateforme (IDPLATEFORME, NOMPLATEFORME) VALUES ({plateformeAjout.IdPlateforme}, '{plateformeAjout.NomPlateforme}');";
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
        public bool Modification(int idPlateforme, Plateforme plateformeModif)
        {
            try
            {
                string requestSql = $"UPDATE plateforme SET IDPLATEFORME = '{plateformeModif.IdPlateforme}', NOMPLATEFORME = '{plateformeModif.NomPlateforme}' WHERE IDPLATEFORME = '{idPlateforme}';";
                if (maConnexion !=null)
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
        public bool Supression(int idPlateforme)
        {
            try
            {
                string requestSql = $"DELETE FROM plateforme WHERE IDPLATEFORME = '{idPlateforme}';";
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
