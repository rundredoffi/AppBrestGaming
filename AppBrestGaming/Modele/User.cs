using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Modele
{
    public class User
    {
        private int idUser;
        private string prenom;
        private string login;
        private string password;
        private string role;
        private string sel;

        public User(int idUser, string prenom, string login, string password, string role, string sel)
        {
            this.idUser = idUser;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
            this.role = role;
            this.sel = sel;
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Sel { get => sel; set => sel = value; }

        public override string ToString()
        {
            string serialisation = "--- USER ---\n";
            serialisation += $"Id : {this.IdUser.ToString()}\n";
            serialisation += $"Nom : {this.Prenom}\n";
            serialisation += $"Prénom : {this.Login}\n";
            serialisation += $"Adresse : {this.Password}\n";
            serialisation += $"Code postal : {this.Role}\n";
            return serialisation;
        }
    }
}
