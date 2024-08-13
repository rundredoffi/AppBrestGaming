using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    
    public class Role
    {
        private int id;
        private string nom;

        public Role(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public override string ToString()
        {
            string serialisation = "--- ROLE ---\n";
            serialisation += $"Id : {this.Id.ToString()}\n";
            serialisation += $"Nom : {this.Nom}";
            return serialisation;
        }
    }
}
