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
    public partial class FormConnexion : Form
    {

        ControleurUser userControleur;
        public FormConnexion()
        {
            InitializeComponent();
            userControleur = new ControleurUser();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            // aucune action au chargement
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string login = this.textBoxLogin.Text;
            string password = this.textBoxPassword.Text;
            if (login.Length > 1 && password.Length > 1)
            {
                User userConnecte = userControleur.VerifierAuthentification(login, password);
                if (userConnecte != null)
                {
                    this.Hide();
                    // création d'un nouveau formulaire Menu : 
                    FormMenu formulaireMenu = new FormMenu(userConnecte);
                    formulaireMenu.Show();
                }
                else
                {
                    MessageBox.Show("Échec d'authentification", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
