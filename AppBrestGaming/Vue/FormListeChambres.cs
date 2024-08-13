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
    public partial class FormListeChambres : Form
    {
        ControleurChambre chambreControleur;

        public FormListeChambres()
        {
            InitializeComponent();
            chambreControleur = new ControleurChambre();
        }

        private void FormListeChambres_Load(object sender, EventArgs e)
        {
            // Chargement de la liste des chambres dans le listView "tableauChambres"
            List<Chambre> listeChambres = chambreControleur.GetListeChambres();
            if (listeChambres != null)
            {
                foreach (Chambre chambre in listeChambres)
                {
                    ListViewItem item = new ListViewItem(chambre.NumChambre.ToString());
                    item.SubItems.Add(chambre.Etage.ToString());
                    item.SubItems.Add(chambre.Capacite.ToString());
                    item.SubItems.Add(chambre.Prix.ToString() + " €");
                    tableauChambres.Items.Add(item);
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
