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
    public partial class FormListeUsers : Form
    {
        ControleurUser userControleur;
        public FormListeUsers()
        {
            InitializeComponent();
            userControleur = new ControleurUser();
        }

        private void FormListeUsers_Load(object sender, EventArgs e)
        {
            tableauUsers.Items.Clear(); // on vide le listView en cas de rechargement

            // Chargement de la liste des utilisateurs dans le listView "tableauUsers"
            List<User> listeUsers = userControleur.GetListeUsers();
            if (listeUsers != null)
            {
                foreach (User user in listeUsers)
                {
                    ListViewItem item = new ListViewItem(user.IdUser.ToString());
                    item.SubItems.Add(user.Prenom);
                    item.SubItems.Add(user.Login);
                    item.SubItems.Add(user.Password);
                    item.SubItems.Add(user.Role);
                    tableauUsers.Items.Add(item);
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (tableauUsers.SelectedItems != null && tableauUsers.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauUsers.SelectedItems[0].Text, out int idUser))
                {
                    FormDetailUser fenetreDetailUser = new FormDetailUser(idUser, false);
                    fenetreDetailUser.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            FormDetailUser fenetreDetailUser = new FormDetailUser(0, true);
            fenetreDetailUser.ShowDialog();
            this.FormListeUsers_Load(sender, e); // rechargement du formulaire
        }

        private void buttonModification_Click(object sender, EventArgs e)
        {
            if (tableauUsers.SelectedItems != null && tableauUsers.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauUsers.SelectedItems[0].Text, out int idUser))
                {
                    FormDetailUser fenetreDetailUser = new FormDetailUser(idUser, true);
                    fenetreDetailUser.ShowDialog();
                    this.FormListeUsers_Load(sender, e); // rechargement du formulaire
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonSuppression_Click(object sender, EventArgs e)
        {
            if (tableauUsers.SelectedItems != null && tableauUsers.SelectedItems.Count > 0)
            {
                if (int.TryParse(tableauUsers.SelectedItems[0].Text, out int idUser))
                {
                    DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cet utilisateur ?", "Confirmation de suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (reponse == DialogResult.OK)
                    {
                        userControleur.SupprimerUser(idUser);
                        this.FormListeUsers_Load(sender, e); // rechargement du formulaire
                    }
                    else
                    {
                        // Demande de suppression annulée : aucune action
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
