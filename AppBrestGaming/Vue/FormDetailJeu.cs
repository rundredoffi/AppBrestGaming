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
    public partial class FormDetailJeu : Form
    {
        private ControleurJeu controleurJeu;
        private Jeu jeuCourant;
        private bool accesModif;

        public FormDetailJeu(int idJeuParam, bool accesModification)
        {
            InitializeComponent();
            this.controleurJeu = new ControleurJeu();
            if (idJeuParam > 0)
            {
                this.jeuCourant = controleurJeu.GetUnJeu(idJeuParam);
            }
            else
            {
                jeuCourant = null;
            }
            this.accesModif = accesModification;
        }

        private void FormDetailJeu_Load(object sender, EventArgs e)
        {
            if (jeuCourant != null)
            {
                // si jeuCourant n'est pas null, on alimente les zones
                this.textBoxId.Text = jeuCourant.Id.ToString();
                this.textBoxNom.Text = jeuCourant.Nom;
                this.textBoxGenre.Text = jeuCourant.Genre;
                this.textBoxEditeur.Text = jeuCourant.Editeur;
                this.textBoxImage.Text = jeuCourant.LogoImage;
                // création de l'image à partir du chemin stocké en base de données
                string cheminImage = @"..\..\" + jeuCourant.LogoImage;
                try
                {
                    Image image = Image.FromFile(cheminImage);
                    this.imageJeu.Image = image;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Problème de chargement de l'image : " + ex.Message);
                }
            }
            else
            {
                // si jeuCourant est null, on est en mode "Ajout" : toutes les zones doivent être vides 
                this.textBoxId.Visible = false;
                this.labelId.Visible = false;
                this.textBoxNom.Text = "";
                this.textBoxGenre.Text = "";
                this.textBoxEditeur.Text = "";
                this.textBoxImage.Text = "";
            }

            this.textBoxId.Enabled = false;
            // si le booléen "accesModif" est vrai,
            // les boutons "Valider" et "Annuler" sont visibles, 
            // le bouton "OK" est invisible,
            // et les textbox sont actives (enabled)
            // Sinon, on est en mode "Détail" : donc on fait l'inverse (textbox inactives : disabled)
            this.textBoxNom.Enabled = accesModif;
            this.textBoxGenre.Enabled = accesModif;
            this.textBoxEditeur.Enabled = accesModif;
            this.textBoxImage.Enabled = accesModif;
            this.buttonValider.Visible = accesModif;
            this.buttonAnnuler.Visible = accesModif;
            this.buttonOK.Visible = !accesModif;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string genre = this.textBoxGenre.Text;
            string editeur = this.textBoxEditeur.Text;
            string image = this.textBoxImage.Text;

            // si une des zones est vide, on renvoie une erreur
            if (nom.Length < 1 || genre.Length < 1 || editeur.Length < 1 || image.Length < 1)
            {
                MessageBox.Show("Toutes les zones doivent être renseignées", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // en cas d'erreur, on ne continue pas le traitement
            }

            // on envoie le jeu courant et les nouvelles valeurs au contrôleur
            bool resultat = controleurJeu.AjoutModifJeu(jeuCourant, nom, genre, editeur, image);

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
    }
}
