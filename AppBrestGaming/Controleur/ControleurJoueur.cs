using AppBrestGaming.Modele;
using System;
using System.Collections.Generic;


namespace AppBrestGaming.Controleur
{
    public class ControleurJoueur
    {
        private PersonneDAO daoPersonne;
        public ControleurJoueur()
        {
            daoPersonne = new PersonneDAO();
        }

        public List<Personne> GetListePersonnes()
        {
            return daoPersonne.GetListe();
        }

        public Personne GetUnePersonne(int idPersonne)
        {
            return daoPersonne.GetById(idPersonne);
        }

        public bool AjoutModifPersonne(Personne anciennePersonne, string pseudo, string nomJoueur, string pays, string role, int idEquipe, int numChambre)
        {
            try
            {
                // on crée une nouvelle personne à partir des valeurs saisies par l'utilisateur
                Personne nouvellePersonne = new Personne(0, pseudo, nomJoueur, pays, role, idEquipe, numChambre);

                // si anciennePersonne n'est pas null, on est en mode "Modification"
                // sinon, on est en mode "Ajout"
                if (anciennePersonne != null)
                {
                    // en mode "Modification", on envoie l'id de la personne à modifier et les nouvelles données de la personne
                    return daoPersonne.Modification(anciennePersonne.Id, nouvellePersonne);
                }
                else
                {
                    // en mode "Ajout", on envoie un nouvel objet "Personne"
                    return daoPersonne.Ajout(nouvellePersonne);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout ou la modification de personne : " + ex.Message);
                return false;
            }
        }

        public bool SupprimerPersonne(int idPersonne)
        {
            try
            {
                daoPersonne.Suppression(idPersonne);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de la personne : " + ex.Message);
                return false;
            }
        }
    }
}
