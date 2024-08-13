using AppBrestGaming.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Controleur
{
    public class ControleurEquipe
    {
        private EquipeDAO daoEquipe;
        public ControleurEquipe()
        {
            daoEquipe = new Modele.EquipeDAO();
        }

        public List<Equipe> GetListeEquipes()
        {
            return daoEquipe.GetListe();
        }

        public Equipe GetUneEquipe(int idEquipe)
        {
            return daoEquipe.GetById(idEquipe);
        }

        public bool AjoutModifEquipe(Equipe ancienneEquipe, string nom, string siteweb, string image)
        {
            try
            {
                // on crée une nouvelle équipe à partir des valeurs saisies par l'utilisateur
                Equipe nouvelleEquipe = new Equipe(0, nom, siteweb, image, null);

                // si ancienneEquipe n'est pas null, on est en mode "Modification"
                // sinon, on est en mode "Ajout"
                if (ancienneEquipe != null)
                {
                    // en mode "Modification", on envoie l'id de l'équipe à modifier et les nouvelles données de l'équipe
                    return daoEquipe.Modification(ancienneEquipe.Id, nouvelleEquipe);
                }
                else
                {
                    // en mode "Ajout", on envoie un nouvel objet "Equipe"
                    return daoEquipe.Ajout(nouvelleEquipe);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout ou la modification d'équipe : " + ex.Message);
                return false;
            }
        }

        public bool SupprimerEquipe(int idEquipe)
        {
            try
            {
                daoEquipe.Suppression(idEquipe);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de l'équipe : " + ex.Message);
                return false;
            }
        }
    }
 }
