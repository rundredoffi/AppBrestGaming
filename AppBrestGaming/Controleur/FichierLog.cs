using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppBrestGaming.Controleur
{
    public class FichierLog
    {
        private string nomFichier;
        // Constructeur :
        public FichierLog(string nomFichier)
        {
            this.nomFichier = nomFichier;
        }
        public void EcrireLog(string chainelog)
        {
            try
            {
                using (StreamWriter monWriter = new StreamWriter(nomFichier, true))
                {
                    monWriter.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy")}\t{DateTime.Now.ToString("HH:mm:ss")}\t{chainelog}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Le fichier " + ex.FileName + " est introuvable");
            }
        }
        public List<string> AfficherFichier()
        {
            string ligne = null;
            List<string> ligneListe = new List<string>();
            try
            {
                using (StreamReader monReader = new StreamReader(nomFichier))
                {
                    ligne = monReader.ReadLine();
                    while (ligne != null)
                    {
                        ligneListe.Add(ligne);
                        ligne = monReader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Le fichier " + ex.FileName + " est introuvable");
            }
            return ligneListe;
        }
        public int OccurencesLogin(string login)
        {
            string ligne = null;
            int comptage = 0;
            try
            {
                using (StreamReader monReader = new StreamReader(nomFichier))
                {
                    ligne = monReader.ReadLine();
                    while (ligne != null)
                    {
                        string[] coupages = ligne.Split('\t');
                        if (coupages[2] == login)
                        {
                            comptage++;
                        }
                        ligne = monReader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Le fichier " + ex.FileName + " est introuvable");
            }
            return comptage;
        }
        public bool SuppressionFichier()
        {
            try
            {
                File.Delete(nomFichier);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
