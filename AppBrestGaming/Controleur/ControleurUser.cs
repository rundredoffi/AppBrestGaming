using AppBrestGaming.Modele;
using LibrairieGaming;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AppBrestGaming.Controleur
{
    public class ControleurUser
    {
        private UserDAO daoUser;
        FichierLog ficLog;
        private string poivre = "loremIpsum";

        public ControleurUser()
        {
            daoUser = new UserDAO();
            ficLog = new FichierLog("logsAppli.txt");
        }

        public List<User> GetListeUsers()
        {
            return daoUser.GetListe();
        }

        public User GetUnUser(int idUser)
        {
            return daoUser.GetById(idUser);
        }

        public User VerifierAuthentification(string login, string motDePasse)
        {
            User utilisateur = daoUser.GetByLogin(login);
            if (utilisateur != null)
            {
                if (utilisateur.Password != null && utilisateur.Password.Equals(HashPassword(poivre+motDePasse+utilisateur.Sel))) // Ajout de la fonction de hash de mot de passe pour la comparaison
                {
                    return utilisateur;
                }
            }
            return null;
        }
        // Méthode pour Hash les mots de passe
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Calcule le hachage de la chaîne donnée et convertit en tableau de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertit les bytes hachés au format chaîne
                // (représentation hexadécimale sous forme de chaîne de caractères).
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool SupprimerUser(int idUser)
        {
            try
            {
                daoUser.Suppression(idUser);
                ficLog.EcrireLog($"Le user n°{idUser} a été supprimé");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                ficLog.EcrireLog($"Problème de suppression du user n°{idUser} : {ex.Message}");
                return false;
            }

        }

        public bool AjoutModifUser(User ancienUser, string prenom, string login, string password, string role)
        {
            try
            {
                bool prenomOk = UtilitaireSaisies.VerifChaineAlphabetique(prenom);
                if(!prenomOk)
                {
                    ficLog.EcrireLog($"La valeur du prénom : '{prenom}' n'est pas valide");
                    return false;
                }
                bool mdpOk = UtilitaireSaisies.ControleMotDePasse(password);
                if (!mdpOk)
                {
                    ficLog.EcrireLog($"La valeur du mot de passe : '{password}' n'est pas valide");
                    return false;
                }

                // on crée un nouveau user à partir des valeurs saisies par l'utilisateur
                User nouveauUser = new User(0, prenom, login, password, role,null); // Ajout fonction pour ajouter sel automatiquement

                // si ancienUser n'est pas null, on est en mode "Modification"
                // sinon, on est en mode "Ajout"
                if (ancienUser != null)
                {
                    // en mode "Modification", on envoie l'id du user à modifier et les nouvelles données du User
                    return daoUser.Modification(ancienUser.IdUser, nouveauUser);
                }
                else
                {
                    // en mode "Ajout", on envoie un nouvel objet "User"
                    return daoUser.Ajout(nouveauUser);
                }
            }
            catch (Exception ex)
            {
                ficLog.EcrireLog($"Problème d'ajout ou la modification d'utilisateur : {ex.Message}");
                return false;
            }
        }
    }
}
