using AppBrestGaming.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Controleur
{
    public class ControleurJeu
    {
        private JeuDAO daoJeu;
        public ControleurJeu()
        {
            daoJeu = new Modele.JeuDAO();
        }

        public List<Jeu> GetListeJeux()
        {
            return daoJeu.GetListe();
        }

        public Jeu GetUnJeu(int idJeu)
        {
            return daoJeu.GetById(idJeu);
        }

        public bool AjoutModifJeu(Jeu ancienJeu, string nom, string genre, string editeur, string image)
        {
            try
            {
                // on crée un nouveau jeu à partir des valeurs saisies par l'utilisateur
                Jeu nouveauJeu = new Jeu(0, nom, genre, editeur, image, null);

                // si ancienJeu n'est pas null, on est en mode "Modification"
                // sinon, on est en mode "Ajout"
                if (ancienJeu != null)
                {
                    // en mode "Modification", on envoie l'id du jeu à modifier et les nouvelles données du jeu
                    return daoJeu.Modification(ancienJeu.Id, nouveauJeu);
                }
                else
                {
                    // en mode "Ajout", on envoie un nouvel objet "Jeu"
                    return daoJeu.Ajout(nouveauJeu);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout ou la modification de jeu : " + ex.Message);
                return false;
            }
        }

        public bool SupprimerJeu(int idJeu)
        {
            try
            {
                daoJeu.Suppression(idJeu);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression du jeu : " + ex.Message);
                return false;
            }
        }
    }
 }
