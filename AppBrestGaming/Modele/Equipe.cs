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
            this.id = id;
            this.nom = nom;
            this.siteWeb = siteWeb;
            this.imageEquipe = imageEquipe;
            this.listeJoueurs = listeJoueurs;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string SiteWeb { get => siteWeb; set => siteWeb = value; }
        public string ImageEquipe { get => imageEquipe; set => imageEquipe = value; }
        public List<Personne> ListeJoueurs { get => listeJoueurs; set => listeJoueurs = value; }
        public override string ToString()
        {
            string seriaisation = "--- EQUIPE ---\n";
            seriaisation += $"Id : {this.id}\n";
            seriaisation += $"Nom : {this.nom}\n";
            seriaisation += $"Site Web : {this.siteWeb}\n";
            seriaisation += $"Logo : {this.imageEquipe}\n";
            if(ListeJoueurs != null)
            {
                foreach (Personne joueur in ListeJoueurs)
                {
                    seriaisation += joueur.Nomjoueur + ", ";
                }
            }
            return seriaisation;
        }
    }
}
