using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class Personne
    {
        private int id;
        private string pseudo;
        private string nomJoueur;
        private string pays;
        private string role;
        private int idEquipe;
        private int numChambre;

        public Personne(int id, string pseudo, string nomJoueur, string pays, string role, int idEquipe, int numChambre)
        {
            this.id = id;
            this.pseudo = pseudo;
            this.nomJoueur = nomJoueur;
            this.pays = pays;
            this.role = role;
            this.IdEquipe = idEquipe;
            this.numChambre = numChambre;
        }

        public int Id { get => id; set => id = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string NomJoueur { get => nomJoueur; set => nomJoueur = value; }
        public string Pays { get => pays; set => pays = value; }
        public string Role { get => role; set => role = value; }
        public int NumChambre { get => numChambre; set => numChambre = value; }
        public int IdEquipe { get => idEquipe; set => idEquipe = value; }

        public override string ToString()
        {
            string serialisation = "--- PERSONNE ---\n";
            serialisation += $"Id : {this.Id.ToString()}\n";
            serialisation += $"Pseudo : {this.Pseudo}\n";
            serialisation += $"Nom joueur : {this.NomJoueur}\n";
            serialisation += $"Pays : {this.Pays}\n";
            serialisation += $"Role : {this.Role}\n";
            serialisation += $"Équipe : {this.IdEquipe}\n";
            serialisation += $"Numéro chambre : {this.NumChambre.ToString()}\n";
            return serialisation;
        }
    }
}
