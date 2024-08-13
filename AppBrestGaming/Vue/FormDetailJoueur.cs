using AppBrestGaming.Controleur;
using AppBrestGaming.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBrestGaming.Vue
{
    public partial class FormDetailJoueur : Form
    {
        private ControleurJoueur controleurJoueur;
        private Personne joueurCourant;
        private bool accesModif;

        public FormDetailJoueur(int idJoueurParam, bool accesModification)
        {
            InitializeComponent();
            this.controleurJoueur = new ControleurJoueur();
            if (idJoueurParam > 0)
            {
                this.joueurCourant = controleurJoueur.GetUnePersonne(idJoueurParam);
            }
            else
            {
                joueurCourant = null;
            }
            this.accesModif = accesModification;
        }

        private void FormDetailJoueur_Load(object sender, EventArgs e)
        {
            if (joueurCourant != null)
            {
                // si joueurCourant n'est pas null, on alimente les zones
                this.textBoxId.Text = joueurCourant.Id.ToString();
                this.textBoxPseudo.Text = joueurCourant.Pseudo;
                this.textBoxNom.Text = joueurCourant.NomJoueur;
                this.textBoxPays.Text = joueurCourant.Pays;
                this.textBoxRole.Text = joueurCourant.Role;
                this.textBoxNumEquipe.Text = joueurCourant.IdEquipe.ToString();
                this.textBoxNumChambre.Text = joueurCourant.NumChambre.ToString();
            }
            else
            {
                // si joueurCourant est null, on est en mode "Ajout" : toutes les zones doivent être vides 
                this.textBoxId.Visible = false;
                this.labelId.Visible = false;
                this.textBoxPseudo.Text = "";
                this.textBoxNom.Text = "";
                this.textBoxPays.Text = "";
                this.textBoxRole.Text = "";
                // a completer
            }

            this.textBoxId.Enabled = false;
            // si le booléen "accesModif" est vrai,
            // les boutons "Valider" et "Annuler" sont visibles, 
            // le bouton "OK" est invisible,
            // et les textbox sont actives (enabled)
            // Sinon, on est en mode "Détail" : donc on fait l'inverse (textbox inactives : disabled)
            this.textBoxPseudo.Enabled = accesModif;
            this.textBoxPays.Enabled = accesModif;
            this.textBoxRole.Enabled = accesModif;
            this.buttonValider.Visible = accesModif;
            this.buttonAnnuler.Visible = accesModif;
            this.buttonOK.Visible = !accesModif;

        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            // on est en mode "Ajout" ou "Modification",
            // donc on récupère les valeurs saisies par l'utilisateur
            string pseudo = this.textBoxPseudo.Text;
            string nomJoueur = this.textBoxNom.Text;
            string pays = this.textBoxPays.Text;
            string role = this.textBoxRole.Text;
            int idEquipe;
            int.TryParse(this.textBoxNumEquipe.Text, out idEquipe);
            int numChambre;
            int.TryParse(this.textBoxNumChambre.Text, out numChambre);

            // si une des zones est vide, on renvoie une erreur
            if (pseudo.Length < 1 || nomJoueur.Length < 1 || pays.Length < 1 || role.Length < 1 || idEquipe < 1 || numChambre < 1)
            {
                MessageBox.Show("Toutes les zones doivent être renseignées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // en cas d'erreur, on ne continue pas le traitement
            }

            // on envoie l'équipe courante et les nouvelles valeurs au contrôleur
            bool resultat = controleurJoueur.AjoutModifPersonne(joueurCourant, pseudo, nomJoueur, pays, role, idEquipe, numChambre);

            // si l'ajout ou la modification a réussi, le booléen "resultat" est à vrai : 
            // on confirme et on ferme le formulaire
            if (resultat)
            {
                MessageBox.Show("Opération réussie", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Échec de l'opération, vérifiez votre saisie", "Échec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
