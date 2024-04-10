using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class Plateforme
    {
        private int idPlateforme;
        private string nomPlateforme;

        public Plateforme(int idPlateforme, string nomPlateforme)
        {
            this.IdPlateforme = idPlateforme;
            this.NomPlateforme = nomPlateforme;
        }

        public int IdPlateforme { get => idPlateforme; set => idPlateforme = value; }
        public string NomPlateforme { get => nomPlateforme; set => nomPlateforme = value; }
        public override string ToString()
        {
            string seriaisation = "--- Platerformes ---\n";
            seriaisation += $"Identifiant : {this.idPlateforme}\n";
            seriaisation += $"Nom : {this.nomPlateforme}";    
            return seriaisation;
        }
    }
}
