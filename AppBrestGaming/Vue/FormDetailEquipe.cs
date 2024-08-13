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
    public partial class FormDetailEquipe : Form
    {
        private ControleurEquipe controleurEquipe;
        private Equipe equipeCourante;
        private bool accesModif;

        public FormDetailEquipe(int idEquipeParam, bool accesModification)
        {
            InitializeComponent();
            this.controleurEquipe = new ControleurEquipe();
            if (idEquipeParam > 0)
            {  
                this.equipeCourante = controleurEquipe.GetUneEquipe(idEquipeParam);
            }
            else
            {
                equipeCourante = null;
            }
            this.accesModif = accesModification;
        }

        private void FormDetailEquipe_Load(object sender, EventArgs e)
        {
            if (equipeCourante != null)
            {
                // si equipeCourante n'est pas null, on alimente les zones
                this.textBoxId.Text = equipeCourante.Id.ToString();
                this.textBoxNom.Text = equipeCourante.Nom;
                this.textBoxSiteWeb.Text = equipeCourante.SiteWeb;
                this.textBoxImage.Text = equipeCourante.ImageEquipe;
                // création de l'image à partir du chemin stocké en base de données
                string cheminImage = @"..\..\" + equipeCourante.ImageEquipe;
                Image image = Image.FromFile(cheminImage);
                this.imageEquipe.Image = image;
            }
            else
            {
                // si equipeCourante est null, on est en mode "Ajout" : toutes les zones doivent être vides 
                this.textBoxId.Visible = false;
                this.labelId.Visible = false;
                this.textBoxNom.Text = "";
                this.textBoxSiteWeb.Text = "";
                this.textBoxImage.Text = "";
            }

            this.textBoxId.Enabled = false;
            // si le booléen "accesModif" est vrai,
            // les boutons "Valider" et "Annuler" sont visibles, 
            // le bouton "OK" est invisible,
            // et les textbox sont actives (enabled)
            // Sinon, on est en mode "Détail" : donc on fait l'inverse (textbox inactives : disabled)
            this.textBoxNom.Enabled = accesModif;
            this.textBoxSiteWeb.Enabled = accesModif;
            this.textBoxImage.Enabled = accesModif;
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
            string nom = this.textBoxNom.Text;
            string siteWeb = this.textBoxSiteWeb.Text;
            string image = this.textBoxImage.Text;

            // si une des zones est vide, on renvoie une erreur
            if (nom.Length < 1 || siteWeb.Length < 1 || image.Length < 1)
            {
                MessageBox.Show("Toutes les zones doivent être renseignées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // en cas d'erreur, on ne continue pas le traitement
            }

            // on envoie l'équipe courante et les nouvelles valeurs au contrôleur
            bool resultat = controleurEquipe.AjoutModifEquipe(equipeCourante, nom, siteWeb, image);

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
