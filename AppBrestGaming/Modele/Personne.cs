using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class Personne
    { 
        private int IDPERSONNE;
        private int numerochambre;
        private int idequipe;
        private string pseudo;
        private string nomjoueur;
        private string pays;
        private string role;

        public Personne(int iDPERSONNE, int numerochambre, int idequipe, string pseudo,string nomjoueur, string pays, string role)
        {
            IDPERSONNE1 = iDPERSONNE;
            this.Numerochambre = numerochambre;
            this.Idequipe = idequipe;
            this.Pseudo = pseudo;
            this.Nomjoueur = nomjoueur;
            this.Pays = pays;
            this.Role = role;
        }

        public int IDPERSONNE1 { get => IDPERSONNE; set => IDPERSONNE = value; }
        public int Numerochambre { get => numerochambre; set => numerochambre = value; }
        public int Idequipe { get => idequipe; set => idequipe = value; }
        public string Nomjoueur { get => nomjoueur; set => nomjoueur = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Pays { get => pays; set => pays = value; }
        public string Role { get => role; set => role = value; }

        public override string ToString()
        {
            string seriaisation = "--- personne --- \n";
            seriaisation += $"Id personne : {this.IDPERSONNE1}\n";
            seriaisation += $"Numéro chambre : {this.Numerochambre}\n";
            seriaisation += $"Id Equipe : {this.Idequipe}\n";
            seriaisation += $"Pseudo : {this.Pseudo}\n";
            seriaisation += $"nomjoueur : {this.Nomjoueur}\n";
            seriaisation += $"pays : {this.Pays}\n";
            seriaisation += $"role : {this.Role}\n";
            return seriaisation;
        }
    }
}
