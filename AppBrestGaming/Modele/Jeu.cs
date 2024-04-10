using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class Jeu
    {
        private int idJeu;
        private string nom;
        private string genre;
        private string editeur;
        private string logoImage;
        private List<Plateforme> listePlateformes;

        public Jeu(int idJeu, string nom, string genre, string editeur, string logoImage, List<Plateforme> listePlateformes)
        {
            this.IdJeu = idJeu;
            this.nom = nom;
            this.genre = genre;
            this.editeur = editeur;
            this.logoImage = logoImage;
            this.listePlateformes = listePlateformes;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public List<Plateforme> ListePlateformes { get => listePlateformes; set => listePlateformes = value; }
        public string LogoImage { get => logoImage; set => logoImage = value; }
        public int IdJeu { get => idJeu; set => idJeu = value; }

        public override string ToString()
        {
            string seriaisation = "--- JEU ---\n";
            seriaisation += $"Nom : {this.Nom}\n";
            seriaisation += $"Genre : {this.Genre}\n";
            seriaisation += $"Logo : {this.LogoImage}\n";
            seriaisation += $"Éditeur : {this.Editeur}\n";
            if (listePlateformes != null)
            {
                string virgule = ", ";
                int i = 1;
                foreach (Plateforme plateforme in listePlateformes)
                {
                    i++;
                    if (i > listePlateformes.Count())
                    {
                        virgule = "";
                    }
                    seriaisation += plateforme.NomPlateforme + virgule;
                }
            }
            return seriaisation;
        }
    }
}
