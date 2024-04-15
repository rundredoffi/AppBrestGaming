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
    public partial class FormEquipe : Form
    {
        private Modele.EquipeDAO daoEquipe = new Modele.EquipeDAO();
        public FormEquipe()
        {
            InitializeComponent();
        }
        private void detailsEquipes_Click(object sender, EventArgs e)
        {
            if (tableauEquipes.SelectedItems != null && tableauEquipes.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauEquipes.SelectedItems[0].Text, out int idEquipe))
                {
                    this.Hide();
                    FormDetailEquipe FormDetailsEquipe = new FormDetailEquipe(idEquipe,1);
                    FormDetailsEquipe.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez choisir une équipe", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void equipesChargement(object sender, EventArgs e)
        {
            foreach (Modele.Equipe equipe in daoEquipe.GetListeEquipes())
            {
                ListViewItem item = new ListViewItem(equipe.Id.ToString());
                item.SubItems.Add(equipe.Nom);
                item.SubItems.Add(equipe.SiteWeb);
                if (equipe.ListeJoueurs != null)
                {
                    item.SubItems.Add(equipe.ListeJoueurs.Count.ToString());
                }
                else
                {
                    item.SubItems.Add("Erreur");
                }
                tableauEquipes.Items.Add(item);
            }
        }

        private void retourEquipes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifierEquipes_Click(object sender, EventArgs e)
        {
            if (tableauEquipes.SelectedItems != null && tableauEquipes.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauEquipes.SelectedItems[0].Text, out int idEquipe))
                {
                    this.Hide();
                    FormDetailEquipe FormDetailsEquipe = new FormDetailEquipe(idEquipe, 2);
                    FormDetailsEquipe.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez choisir une équipe", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}