using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class Chambre
    {
        private int numChambre;
        private int etage;
        private int capacite;
        private float prix;

        public Chambre(int numChambre, int etage, int capacite, float prix)
        {
            this.NumChambre = numChambre;
            this.Etage = etage;
            this.Capacite = capacite;
            this.Prix = prix;
        }

        public int NumChambre { get => numChambre; set => numChambre = value; }
        public int Etage { get => etage; set => etage = value; }
        public int Capacite { get => capacite; set => capacite = value; }
        public float Prix { get => prix; set => prix = value; }

        public override string ToString()
        {
            string serialisation = "--- CHAMBRE ---\n";
            serialisation += $"N° : {this.NumChambre.ToString()}\n";
            serialisation += $"Étage : {this.Etage.ToString()}\n";
            serialisation += $"Capacité : {this.Capacite.ToString()}\n";
            serialisation += $"Prix : {this.Prix.ToString()}\n";
            return serialisation;
        }
    }
}
