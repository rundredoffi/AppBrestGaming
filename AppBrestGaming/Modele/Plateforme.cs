using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class Plateforme
    {
        private int id;
        private String nomPlateforme;

        public Plateforme(int id, string nomPlateforme)
        {
            this.Id = id;
            this.NomPlateforme = nomPlateforme;
        }

        public int Id { get => id; set => id = value; }
        public string NomPlateforme { get => nomPlateforme; set => nomPlateforme = value; }

        public override string ToString()
        {
            string seriaisation = "--- PLATEFORME ---\n";
            seriaisation += $"Id : {this.Id.ToString()}\n";
            seriaisation += $"Nom : {this.NomPlateforme}\n";
            return seriaisation;
        }

    }
}
