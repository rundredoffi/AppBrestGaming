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
    public partial class FormListeJeux : Form
    {
        private ControleurJeu controleurJeu;
        public FormListeJeux()
        {
            InitializeComponent();
            controleurJeu = new ControleurJeu();
        }

        private void FormListeJeux_Load(object sender, EventArgs e)
        {
            tableauJeux.Items.Clear(); // on vide le listView en cas de rechargement

            List<Jeu> listeJeux = controleurJeu.GetListeJeux();
            if (listeJeux != null)
            {
                int indexImage = 0;
                foreach (Jeu jeu in listeJeux)
                {
                    ListViewItem item = new ListViewItem(jeu.Id.ToString());
                    // création de l'image à partir du chemin stocké en base de données
                    string cheminImage = @"..\..\" + jeu.LogoImage;
                    try
                    {
                        Image image = Image.FromFile(cheminImage);
                        imageList1.Images.Add(image);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Problème de chargement de l'image : " + ex.Message);
                    }
                    
                    item.ImageIndex = indexImage;
                    item.StateImageIndex = indexImage;
                    indexImage++;
                    item.SubItems.Add(jeu.Nom);
                    item.SubItems.Add(jeu.Genre);
                    item.SubItems.Add(jeu.Editeur);

                    tableauJeux.Items.Add(item);
                }
                tableauJeux.SmallImageList = imageList1;
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (tableauJeux.SelectedItems != null && tableauJeux.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauJeux.SelectedItems[0].Text, out int idJeu))
                {
                    FormDetailJeu fenetreDetailJeu = new FormDetailJeu(idJeu, false);
                    fenetreDetailJeu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un jeu", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            FormDetailJeu fenetreDetailJeu = new FormDetailJeu(0, true);
            fenetreDetailJeu.ShowDialog();
            this.FormListeJeux_Load(sender, e); // rechargement du formulaire
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            if (tableauJeux.SelectedItems != null && tableauJeux.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauJeux.SelectedItems[0].Text, out int idJeu))
                {
                    FormDetailJeu fenetreDetailJeu = new FormDetailJeu(idJeu, true);
                    fenetreDetailJeu.ShowDialog();
                    this.FormListeJeux_Load(sender, e); // rechargement du formulaire
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un jeu", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonSupp_Click(object sender, EventArgs e)
        {
            if (tableauJeux.SelectedItems != null && tableauJeux.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauJeux.SelectedItems[0].Text, out int idJeu))
                {
                    DialogResult reponse = MessageBox.Show("Voulez-vous supprimer ce jeu ?", "Confirmation de suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (reponse == DialogResult.OK)
                    {
                        controleurJeu.SupprimerJeu(idJeu);
                        this.FormListeJeux_Load(sender, e); // rechargement du formulaire
                    }
                    else
                    {
                        // Demande de suppression annulée : aucune action
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un jeu", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
