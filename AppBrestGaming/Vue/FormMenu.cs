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
        public FormMenu()
        {
            InitializeComponent();
        }

        private void equipesAcceuil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEquipe formulaireEquipe = new FormEquipe();
            formulaireEquipe.ShowDialog();
            this.Show();
        }

        private void quitterButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
