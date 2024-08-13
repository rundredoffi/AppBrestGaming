using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class Equipe
    {
        private int id;
        private string nom;
        private string siteWeb;
        private string imageEquipe;
        private List<Personne> listeJoueurs;

        public Equipe(int id, string nom, string siteWeb, string imageEquipe, List<Personne> listeJoueurs)
        {
            this.Id = id;
            this.Nom = nom;
            this.SiteWeb = siteWeb;
            this.ImageEquipe = imageEquipe;
            this.ListeJoueurs = listeJoueurs;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string SiteWeb { get => siteWeb; set => siteWeb = value; }
        public string ImageEquipe { get => imageEquipe; set => imageEquipe = value; }
        public List<Personne> ListeJoueurs { get => listeJoueurs; set => listeJoueurs = value; }

        public override string ToString()
        {
            string joueurs = "";
            try
            {
                if (listeJoueurs != null)
                {
                    foreach (Personne joueur in listeJoueurs)
                    {
                        joueurs += joueur.Pseudo;
                        joueurs += ", ";
                    }
                    if (joueurs.LastIndexOf(", ") > 0)
                    {
                        joueurs = joueurs.Remove(joueurs.LastIndexOf(", "), 1);
                    }
                }

                string serialisation = "--- EQUIPE ---\n";
                serialisation += $"Id : {this.Id}\n";
                serialisation += $"Nom : {this.Nom}\n";
                serialisation += $"Site Web : {this.SiteWeb}\n";
                serialisation += $"Image équipe : {this.ImageEquipe}\n";
                serialisation += $"Joueurs : {joueurs}\n";
                return serialisation;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Equipe.ToString. Erreur : {ex.Message}");
            }
            return "";
        }
    }
}
