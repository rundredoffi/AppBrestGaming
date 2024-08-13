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
    public partial class FormListeJoueurs : Form
    {
        private ControleurJoueur controleurJoueur;
        public FormListeJoueurs()
        {
            InitializeComponent();
            controleurJoueur = new ControleurJoueur();
        }

        private void FormListeJoueurs_Load(object sender, EventArgs e)
        {
            tableauJoueurs.Items.Clear(); // on vide le listView en cas de rechargement

            List<Personne> listeJoueurs = controleurJoueur.GetListePersonnes();
            if (listeJoueurs != null)
            {
                foreach (Personne joueur in listeJoueurs)
                {
                    ListViewItem item = new ListViewItem(joueur.Id.ToString());
                    item.SubItems.Add(joueur.Pseudo);
                    item.SubItems.Add(joueur.NomJoueur);
                    item.SubItems.Add(joueur.Pays);
                    item.SubItems.Add(joueur.Role);
               
                    tableauJoueurs.Items.Add(item);
                }
            }
        }
        private void buttonRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSupp_Click(object sender, EventArgs e)
        {

            if (tableauJoueurs.SelectedItems != null && tableauJoueurs.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauJoueurs.SelectedItems[0].Text, out int idJoueur))
                {
                    DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette personne ?", "Confirmation de suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (reponse == DialogResult.OK)
                    {
                        controleurJoueur.SupprimerPersonne(idJoueur);
                        this.FormListeJoueurs_Load(sender, e); // rechargement du formulaire
                    }
                    else
                    {
                        // Demande de suppression annulée : aucune action
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une personne", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (tableauJoueurs.SelectedItems != null && tableauJoueurs.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauJoueurs.SelectedItems[0].Text, out int idJoueur))
                {
                    FormDetailJoueur fenetreDetailJoueur = new FormDetailJoueur(idJoueur, false);
                    fenetreDetailJoueur.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une équipe", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            if (tableauJoueurs.SelectedItems != null && tableauJoueurs.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauJoueurs.SelectedItems[0].Text, out int idJoueur))
                {
                    FormDetailJoueur fenetreDetailJoueur = new FormDetailJoueur(idJoueur, true);
                    fenetreDetailJoueur.ShowDialog();
                    this.FormListeJoueurs_Load(sender, e); // rechargement du formulaire
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un joueur", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            FormDetailJoueur fenetreDetailJoueur = new FormDetailJoueur(0, true);
            fenetreDetailJoueur.ShowDialog();
            this.FormListeJoueurs_Load(sender, e); // rechargement du formulaire
        }

    }
}
