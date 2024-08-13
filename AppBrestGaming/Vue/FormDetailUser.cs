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
    public partial class FormDetailUser : Form
    {
        ControleurUser userControleur;
        User userCourant;
        private bool accesModif;

        public FormDetailUser(int idUserParam, bool accesModification)
        {
            InitializeComponent();
            this.userControleur = new ControleurUser();
            if (idUserParam > 0)
            {
                this.userCourant = userControleur.GetUnUser(idUserParam);
            }
            else
            {
                this.userCourant = null;
            }
            this.accesModif = accesModification;
        }

        private void FormDetailUser_Load(object sender, EventArgs e)
        {
            if (userCourant != null)
            {
                // si userCourant n'est pas nul, on alimente les zones
                this.labelValeurId.Text = userCourant.IdUser.ToString();
                this.textBoxPrenom.Text = userCourant.Prenom;
                this.textBoxLogin.Text = userCourant.Login;
                this.textBoxPassword.Text = userCourant.Password;
                this.textBoxRole.Text = userCourant.Role;
            }
            else
            {
                // si userCourant est null, on est en mode "Ajout" : toutes les zones doivent être vides 
                this.labelId.Visible = false;
                this.labelValeurId.Visible = false;
                this.textBoxPrenom.Text = "";
                this.textBoxLogin.Text = "";
                this.textBoxPassword.Text = "";
                this.textBoxRole.Text = "";
            }

            // si le booléen "accesModif" est vrai,
            // les boutons "Valider" et "Annuler" sont visibles, 
            // le bouton "OK" est invisible,
            // et les textbox sont actives (enabled)
            // Sinon, on est en mode "Détail" : donc on fait l'inverse (textbox inactives : disabled)
            if (accesModif)
            {
                this.buttonValider.Visible = true;
                this.buttonAnnuler.Visible = true;
                this.buttonOK.Visible = false;
                this.textBoxPrenom.Enabled = true;
                this.textBoxLogin.Enabled = true;
                this.textBoxPassword.Enabled = true;
                this.textBoxRole.Enabled = true;
            }
            else
            {
                this.buttonValider.Visible = false;
                this.buttonAnnuler.Visible = false;
                this.buttonOK.Visible = true;
                this.textBoxPrenom.Enabled = false;
                this.textBoxLogin.Enabled = false;
                this.textBoxPassword.Enabled = false;
                this.textBoxRole.Enabled = false;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            // on est en mode "Ajout" ou "Modification",
            // donc on récupère les valeurs saisies par l'utilisateur
            string prenom = this.textBoxPrenom.Text;
            string login = this.textBoxLogin.Text;
            string password = this.textBoxPassword.Text;
            string role = this.textBoxRole.Text;
            // si une des zones est vide, on renvoie une erreur
            if (prenom.Length < 1 || login.Length < 1 || password.Length < 1 || role.Length < 1)
            {
                MessageBox.Show("Toutes les zones doivent être renseignées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // en cas d'erreur, on ne continue pas le traitement
            }

            // on envoie l'utilisateur courant et les nouvelles valeurs au contrôleur
            bool resultat = userControleur.AjoutModifUser(userCourant, prenom, login, password, role);

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
