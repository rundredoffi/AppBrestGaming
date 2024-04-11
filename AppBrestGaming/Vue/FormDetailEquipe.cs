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
        public FormDetailEquipe(int idEquipeParam)
        {
            InitializeComponent();
            equipeCourante = daoEquipe.GetEquipeById(idEquipeParam);
        }

        private void quitterDetailsEquipe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailsEquipeChargement(object sender, EventArgs e)
        {
            // Ajout des informations générale de l'équipe
            this.numeroEquipeDetailsEquipe.Value = equipeCourante.Id;

            ListViewItem item1 = new ListViewItem("Scarface");
            item1.SubItems.Add("Vitality");
            item1.SubItems.Add("Vitality");
            item1.SubItems.Add("Vitality");
            tableauDetailsEquipe.Items.Add(item1);
        }
    }
}
