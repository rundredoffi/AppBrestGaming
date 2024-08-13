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
    public partial class FormMenu : Form
    {
        private User userConnecte;
        public FormMenu()
        {
            InitializeComponent();
        }

        public FormMenu(User userConnecteParam)
        {
            InitializeComponent();
            userConnecte = userConnecteParam;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEquipes_Click(object sender, EventArgs e)
        {
            this.Hide(); // on cache le menu
            // création d'un nouveau formulaire Equipes : 
            FormListeEquipes formulaireEquipes = new FormListeEquipes();
            formulaireEquipes.ShowDialog(); // ouverture du formulaire dans une fenêtre modale
            // On revient ici lorsque ShowDialog() est terminé, donc quand on ferme le formulaire Equipe
            this.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (userConnecte != null && userConnecte.Role.Equals("admin"))
            {
                this.buttonAdmin.Visible = true;
            }
            else
            {
                //this.buttonAdmin.Visible = false;
                this.buttonAdmin.Visible = false;
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide(); // on cache le menu
            // création d'un nouveau formulaire ListeUsers : 
            FormListeUsers formulaireUsers = new FormListeUsers();
            formulaireUsers.ShowDialog(); // ouverture du formulaire dans une fenêtre modale
            // On revient ici lorsque ShowDialog() est terminé, donc quand on ferme le formulaire Utilisateurs
            this.Show();
        }

        private void buttonChambres_Click(object sender, EventArgs e)
        {
            this.Hide(); // on cache le menu
            // création d'un nouveau formulaire Clients : 
            FormListeChambres formulaireChambres = new FormListeChambres();
            formulaireChambres.ShowDialog(); // ouverture du formulaire dans une fenêtre modale
            // On revient ici lorsque ShowDialog() est terminé, donc quand on ferme le formulaire Chambres
            this.Show();
        }

        private void buttonJoueurs_Click(object sender, EventArgs e)
        {
            this.Hide(); // on cache le menu
            // création d'un nouveau formulaire Clients : 
            FormListeJoueurs formulaireJoueurs = new FormListeJoueurs();
            formulaireJoueurs.ShowDialog(); // ouverture du formulaire dans une fenêtre modale
            // On revient ici lorsque ShowDialog() est terminé, donc quand on ferme le formulaire Joueurs
            this.Show();
        }
    }
}
