using AppBrestGaming.Modele;
using LibrairieGaming; // Bibliothèque généré.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppBrestGaming.Controleur
{
    public class ControleurUser
    {
        private UserDAO daoUser;
        private FichierLog ficlog;

        public ControleurUser()
        {
            DateTime maintenant = DateTime.Now;
            string jour = maintenant.ToString("dd-MM-yyyy");
            daoUser = new UserDAO();
            ficlog = new FichierLog($"{jour} - BG - User.log");
        }

        public List<User> GetListeUsers()
        {
            return daoUser.GetListe();
        }

        public List<Role> GetListeRoles()
        {
            return daoUser.GetListeRole();
        }

        public User GetUnUser(int idUser)
        {
            return daoUser.GetById(idUser);
        }

        public User VerifierAuthentification(string login, string motDePasse)
        {
            if (UtilitaireSaisies.ControleMotDePasse(motDePasse))
            {
                User utilisateur = daoUser.GetByLogin(login);
                if (utilisateur != null)
                {
                    if (utilisateur.Password != null && utilisateur.Password.Equals(motDePasse))
                    {
                        ficlog.EcrireLog($"Connexion de {utilisateur.Login}");
                        return utilisateur;
                    }
                }
            }
            ficlog.EcrireLog($"{login} n'a pas réussi à se connecter.");
            return null;
        }

        public bool SupprimerUser(int idUser)
        {
            try
            {
                daoUser.Suppression(idUser);
                ficlog.EcrireLog($"Utilisateur n°{idUser} a été supprimé.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de l'utilisateur : " + ex.Message);
                ficlog.EcrireLog($"Erreur lors de la suppression de l'utilisateur n°{idUser}.");
                return false;
            }

        }

        public bool AjoutModifUser(User ancienUser, string prenom, string login, string password, string role)
        {
            try
            {
                // on crée un nouveau user à partir des valeurs saisies par l'utilisateur
                User nouveauUser = new User(0, prenom, login, password, role);

                // si ancienUser n'est pas null, on est en mode "Modification"
                // sinon, on est en mode "Ajout"
                if (ancienUser != null)
                {
                    ficlog.EcrireLog($"Utilisateur n°{ancienUser.IdUser} a été modifié.");
                    // en mode "Modification", on envoie l'id du user à modifier et les nouvelles données du User
                    return daoUser.Modification(ancienUser.IdUser, nouveauUser);
                }
                else
                {
                    ficlog.EcrireLog($"L'utilisateur {nouveauUser.Login} a été créé.");
                    // en mode "Ajout", on envoie un nouvel objet "User"
                    return daoUser.Ajout(nouveauUser);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout ou la modification d'utilisateur : " + ex.Message);
                ficlog.EcrireLog("Erreur lors de l'ajout de l'utilisateur.");
                return false;
            }
        }
    }
}
