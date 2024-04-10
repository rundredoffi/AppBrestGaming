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
        public FormEquipe()
        {
            InitializeComponent();
        }

        private void FormEquipe_Load(object sender, EventArgs e)
        {

        }

        private void detailsEquipes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDetailEquipe FormDetailsEquipe = new FormDetailEquipe();
            FormDetailsEquipe.ShowDialog();
            this.Show();
        }

        private void equipesChargement(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem("1");
            item1.SubItems.Add("Vitality");
            item1.SubItems.Add("https://vitality.gg/");
            tableauEquipes.Items.Add(item1);
        }

        private void retourEquipes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
