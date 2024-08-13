using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class Jeu
    {
        private int id;
        private string nom;
        private string genre;
        private string editeur;
        private string logoImage;
        private List<string> listePlateformes;

        public Jeu(int id, string nom, string genre, string editeur, string logoImage, List<string> listePlateformes)
        {
            this.id = id;
            this.nom = nom;
            this.genre = genre;
            this.editeur = editeur;
            this.LogoImage = logoImage;
            this.listePlateformes = listePlateformes;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public List<string> ListePlateformes { get => listePlateformes; set => listePlateformes = value; }
        public int Id { get => id; set => id = value; }
        public string LogoImage { get => logoImage; set => logoImage = value; }

        public override string ToString()
        {
            string plateformes = "";
            try
            {
                foreach (string platf in listePlateformes)
                {
                    plateformes += platf;
                    plateformes += ", ";
                }
                if (plateformes.LastIndexOf(", ") > 0)
                {
                    plateformes = plateformes.Remove(plateformes.LastIndexOf(", "), 1);
                }

                string seriaisation = "--- JEU ---\n";
                seriaisation += $"Id : {this.Id.ToString()}\n";
                seriaisation += $"Nom : {this.Nom}\n";
                seriaisation += $"Genre : {this.Genre}\n";
                seriaisation += $"Éditeur : {this.Editeur}\n";
                seriaisation += $"Plateformes : {plateformes}\n";
                return seriaisation;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Jeu.ToString. Erreur : {ex.Message}");
            }
            return "";
        }
    }
}
