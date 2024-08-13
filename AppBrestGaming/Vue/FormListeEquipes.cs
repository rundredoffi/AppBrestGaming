
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
    public partial class FormListeEquipes : Form
    {
        private ControleurEquipe controleurEquipe;

        public FormListeEquipes()
        {
            InitializeComponent();
            controleurEquipe = new ControleurEquipe();
        }


        private void buttonRetourMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEquipes_Load(object sender, EventArgs e)
        {
            tableauEquipes.Items.Clear(); // on vide le listView en cas de rechargement

            List<Equipe> listeEquipes = controleurEquipe.GetListeEquipes();
            if (listeEquipes != null)
            {
                int indexImage = 0;
                foreach (Equipe equipe in listeEquipes)
                {
                    ListViewItem item = new ListViewItem(equipe.Id.ToString());
                    // création de l'image à partir du chemin stocké en base de données
                    string cheminImage = @"..\..\" + equipe.ImageEquipe;
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
                    item.SubItems.Add(equipe.Nom);
                    item.SubItems.Add(equipe.SiteWeb);
                    if (equipe.ListeJoueurs != null)
                    {
                        item.SubItems.Add(equipe.ListeJoueurs.Count.ToString());
                    }
                    tableauEquipes.Items.Add(item);
                }
                tableauEquipes.SmallImageList = imageList1;
            }
        }

        private void buttonSupp_Click(object sender, EventArgs e)
        {
            if (tableauEquipes.SelectedItems != null && tableauEquipes.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauEquipes.SelectedItems[0].Text, out int idEquipe))
                {
                    DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette équipe ?", "Confirmation de suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (reponse == DialogResult.OK)
                    {
                        controleurEquipe.SupprimerEquipe(idEquipe);
                        this.FormEquipes_Load(sender, e); // rechargement du formulaire
                    }
                    else
                    {
                        // Demande de suppression annulée : aucune action
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une équipe", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (tableauEquipes.SelectedItems != null && tableauEquipes.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauEquipes.SelectedItems[0].Text, out int idEquipe))
                {
                    FormDetailEquipe fenetreDetailEquipe = new FormDetailEquipe(idEquipe, false);
                    fenetreDetailEquipe.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une équipe", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            if (tableauEquipes.SelectedItems != null && tableauEquipes.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauEquipes.SelectedItems[0].Text, out int idEquipe))
                {
                    FormDetailEquipe fenetreDetailEquipe = new FormDetailEquipe(idEquipe, true);
                    fenetreDetailEquipe.ShowDialog();
                    this.FormEquipes_Load(sender, e); // rechargement du formulaire
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une équipe", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            FormDetailEquipe fenetreDetailEquipe = new FormDetailEquipe(0, true);
            fenetreDetailEquipe.ShowDialog();
            this.FormEquipes_Load(sender, e); // rechargement du formulaire
        }
    }
}
