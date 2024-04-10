using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConnexionBddDAO
{
    private static MySqlConnection maConnexion;
    private static string chaineConnexion;

    // Méthode qui va nous retourner notre instance
    // et la créer si elle n'existe pas
    public static MySqlConnection GetInstance()
    {
        if (maConnexion == null)
        {
            try
            {
                chaineConnexion = "Data Source=localhost;Initial Catalog=njd_gaming;User ID=myroot;Password=root123*";
                maConnexion = new MySqlConnection(chaineConnexion);
                if (maConnexion.State == System.Data.ConnectionState.Closed
                    || maConnexion.State == System.Data.ConnectionState.Broken)
                {
                    maConnexion.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        return maConnexion;
    }

    public static void FermerConnexion()
    {
        if (maConnexion != null
            && maConnexion.State != System.Data.ConnectionState.Closed)
        {
            maConnexion.Close();
        }
    }
}


