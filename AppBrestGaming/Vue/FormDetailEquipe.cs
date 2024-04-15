using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBrestGaming
{
    public partial class FormDetailEquipe : Form
    {
        private Modele.EquipeDAO daoEquipe = new Modele.EquipeDAO();
        private Modele.Equipe equipeCourante;
        // Utilisation de cette variable pour switch entre les modes
        private int modeForm;
        public FormDetailEquipe(int idEquipeParam, int mode)
        {
            this.modeForm = mode;
            InitializeComponent();
            equipeCourante = daoEquipe.GetEquipeById(idEquipeParam);
        }

        private void quitterDetailsEquipe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailsEquipeChargement(object sender, EventArgs e)
        {
            switch (modeForm){
                case 1:
                    detailsEquipe();
                    break;
                case 2:
                    modifEquipe();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        // Fonction pour le switch case
        private void detailsEquipe()
        {
            this.headerDetailsEquipe.Enabled = false;
            this.idEquipe.Text = equipeCourante.Id.ToString();
            this.nomEquipe.Text = equipeCourante.Nom;
            this.siteWebEquipe.Text = equipeCourante.SiteWeb;
            if (equipeCourante.ListeJoueurs != null)
            {
                foreach (Modele.Personne personne in equipeCourante.ListeJoueurs)
                {
                    ListViewItem item = new ListViewItem(personne.Pseudo);
                    item.SubItems.Add(personne.Nomjoueur);
                    item.SubItems.Add(personne.Role);
                    item.SubItems.Add(personne.Pays);
                    tableauDetailsEquipe.Items.Add(item);
                }
            }
        }
        private void modifEquipe()
        {
            this.headerDetailsEquipe.Hide();
        }
    }
}
