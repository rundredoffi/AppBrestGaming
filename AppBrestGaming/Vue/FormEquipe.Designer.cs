
namespace AppBrestGaming.Vue
{
    partial class FormEquipe
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "equipe-01.jpg",
            "Vitality",
            "https://vitality.gg/"}, "(aucun)");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "equipe-02.jpg",
            "Gentle Mates",
            "https://gentlemates.com/fr/"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "equipe-03.jpg",
            "Karmine Corp",
            "https://www.karminecorp.fr/"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "equipe-04.jpg",
            "Fnatic",
            "https://fnatic.com/"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "equipe-05.jpg",
            "Team liquid",
            "https://www.teamliquid.com/"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "equipe-06.jpg",
            "Dignitas",
            "https://dignitas.gg/"}, -1);
            this.tableauEquipes = new System.Windows.Forms.ListView();
            this.logoEquipes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomEquipes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siteEquipes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailsEquipes = new System.Windows.Forms.Button();
            this.ajouterEquipes = new System.Windows.Forms.Button();
            this.modifierEquipes = new System.Windows.Forms.Button();
            this.supprimerEquipes = new System.Windows.Forms.Button();
            this.retourEquipes = new System.Windows.Forms.Button();
            this.titreEquipes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableauEquipes
            // 
            this.tableauEquipes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.logoEquipes,
            this.nomEquipes,
            this.siteEquipes});
            this.tableauEquipes.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.tableauEquipes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.tableauEquipes.Location = new System.Drawing.Point(99, 77);
            this.tableauEquipes.Name = "tableauEquipes";
            this.tableauEquipes.Size = new System.Drawing.Size(600, 206);
            this.tableauEquipes.TabIndex = 0;
            this.tableauEquipes.UseCompatibleStateImageBehavior = false;
            this.tableauEquipes.View = System.Windows.Forms.View.Details;
            // 
            // logoEquipes
            // 
            this.logoEquipes.Text = "Logo";
            this.logoEquipes.Width = 200;
            // 
            // nomEquipes
            // 
            this.nomEquipes.Text = "Equipes";
            this.nomEquipes.Width = 200;
            // 
            // siteEquipes
            // 
            this.siteEquipes.Text = "Site Web";
            this.siteEquipes.Width = 200;
            // 
            // detailsEquipes
            // 
            this.detailsEquipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.detailsEquipes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detailsEquipes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsEquipes.ForeColor = System.Drawing.Color.White;
            this.detailsEquipes.Location = new System.Drawing.Point(305, 314);
            this.detailsEquipes.Name = "detailsEquipes";
            this.detailsEquipes.Size = new System.Drawing.Size(170, 49);
            this.detailsEquipes.TabIndex = 4;
            this.detailsEquipes.Text = "Détails";
            this.detailsEquipes.UseVisualStyleBackColor = false;
            this.detailsEquipes.Click += new System.EventHandler(this.detailsEquipes_Click);
            // 
            // ajouterEquipes
            // 
            this.ajouterEquipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ajouterEquipes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajouterEquipes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterEquipes.ForeColor = System.Drawing.Color.White;
            this.ajouterEquipes.Location = new System.Drawing.Point(99, 377);
            this.ajouterEquipes.Name = "ajouterEquipes";
            this.ajouterEquipes.Size = new System.Drawing.Size(170, 49);
            this.ajouterEquipes.TabIndex = 5;
            this.ajouterEquipes.Text = "Ajouter";
            this.ajouterEquipes.UseVisualStyleBackColor = false;
            // 
            // modifierEquipes
            // 
            this.modifierEquipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.modifierEquipes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifierEquipes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierEquipes.ForeColor = System.Drawing.Color.White;
            this.modifierEquipes.Location = new System.Drawing.Point(305, 377);
            this.modifierEquipes.Name = "modifierEquipes";
            this.modifierEquipes.Size = new System.Drawing.Size(170, 49);
            this.modifierEquipes.TabIndex = 6;
            this.modifierEquipes.Text = "Modifier";
            this.modifierEquipes.UseVisualStyleBackColor = false;
            // 
            // supprimerEquipes
            // 
            this.supprimerEquipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.supprimerEquipes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supprimerEquipes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimerEquipes.ForeColor = System.Drawing.Color.White;
            this.supprimerEquipes.Location = new System.Drawing.Point(516, 377);
            this.supprimerEquipes.Name = "supprimerEquipes";
            this.supprimerEquipes.Size = new System.Drawing.Size(170, 49);
            this.supprimerEquipes.TabIndex = 7;
            this.supprimerEquipes.Text = "Supprimer";
            this.supprimerEquipes.UseVisualStyleBackColor = false;
            // 
            // retourEquipes
            // 
            this.retourEquipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.retourEquipes.Location = new System.Drawing.Point(12, 12);
            this.retourEquipes.Name = "retourEquipes";
            this.retourEquipes.Size = new System.Drawing.Size(85, 32);
            this.retourEquipes.TabIndex = 8;
            this.retourEquipes.Text = "Retour";
            this.retourEquipes.UseVisualStyleBackColor = false;
            this.retourEquipes.Click += new System.EventHandler(this.retourEquipes_Click);
            // 
            // titreEquipes
            // 
            this.titreEquipes.AutoSize = true;
            this.titreEquipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreEquipes.Location = new System.Drawing.Point(301, 29);
            this.titreEquipes.Name = "titreEquipes";
            this.titreEquipes.Size = new System.Drawing.Size(186, 24);
            this.titreEquipes.TabIndex = 9;
            this.titreEquipes.Text = "Liste des équipes :";
            // 
            // FormEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titreEquipes);
            this.Controls.Add(this.retourEquipes);
            this.Controls.Add(this.supprimerEquipes);
            this.Controls.Add(this.modifierEquipes);
            this.Controls.Add(this.ajouterEquipes);
            this.Controls.Add(this.detailsEquipes);
            this.Controls.Add(this.tableauEquipes);
            this.Name = "FormEquipe";
            this.Text = "Equipes";
            this.Load += new System.EventHandler(this.equipesChargement);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView tableauEquipes;
        private System.Windows.Forms.ColumnHeader logoEquipes;
        private System.Windows.Forms.ColumnHeader nomEquipes;
        private System.Windows.Forms.ColumnHeader siteEquipes;
        private System.Windows.Forms.Button detailsEquipes;
        private System.Windows.Forms.Button ajouterEquipes;
        private System.Windows.Forms.Button modifierEquipes;
        private System.Windows.Forms.Button supprimerEquipes;
        private System.Windows.Forms.Button retourEquipes;
        private System.Windows.Forms.Label titreEquipes;
    }
}