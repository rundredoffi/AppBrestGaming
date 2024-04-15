﻿
namespace AppBrestGaming
{
    partial class FormDetailEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailEquipe));
            this.voirPlusDetailsEquipes = new System.Windows.Forms.Button();
            this.modifierDetailsEquipe = new System.Windows.Forms.Button();
            this.supprimerDetailsEquipe = new System.Windows.Forms.Button();
            this.texteNumeroEquipeDetailsEquipe = new System.Windows.Forms.Label();
            this.logoDetailsEquipe = new System.Windows.Forms.PictureBox();
            this.tableauDetailsEquipe = new System.Windows.Forms.ListView();
            this.pseudoTableauDetailsEquipe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomTableauDetailsEquipe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roleTableauDetailsEquipe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paystableauDetailsEquipe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quitterDetailsEquipe = new System.Windows.Forms.Button();
            this.headerDetailsEquipe = new System.Windows.Forms.GroupBox();
            this.nomEquipe = new System.Windows.Forms.TextBox();
            this.siteWebEquipe = new System.Windows.Forms.TextBox();
            this.idEquipe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoDetailsEquipe)).BeginInit();
            this.headerDetailsEquipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // voirPlusDetailsEquipes
            // 
            this.voirPlusDetailsEquipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.voirPlusDetailsEquipes.ForeColor = System.Drawing.Color.White;
            this.voirPlusDetailsEquipes.Location = new System.Drawing.Point(345, 345);
            this.voirPlusDetailsEquipes.Name = "voirPlusDetailsEquipes";
            this.voirPlusDetailsEquipes.Size = new System.Drawing.Size(128, 41);
            this.voirPlusDetailsEquipes.TabIndex = 0;
            this.voirPlusDetailsEquipes.Text = "Voir Plus";
            this.voirPlusDetailsEquipes.UseVisualStyleBackColor = false;
            // 
            // modifierDetailsEquipe
            // 
            this.modifierDetailsEquipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.modifierDetailsEquipe.ForeColor = System.Drawing.Color.White;
            this.modifierDetailsEquipe.Location = new System.Drawing.Point(234, 392);
            this.modifierDetailsEquipe.Name = "modifierDetailsEquipe";
            this.modifierDetailsEquipe.Size = new System.Drawing.Size(126, 41);
            this.modifierDetailsEquipe.TabIndex = 1;
            this.modifierDetailsEquipe.Text = "Modifier";
            this.modifierDetailsEquipe.UseVisualStyleBackColor = false;
            // 
            // supprimerDetailsEquipe
            // 
            this.supprimerDetailsEquipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.supprimerDetailsEquipe.ForeColor = System.Drawing.Color.White;
            this.supprimerDetailsEquipe.Location = new System.Drawing.Point(458, 392);
            this.supprimerDetailsEquipe.Name = "supprimerDetailsEquipe";
            this.supprimerDetailsEquipe.Size = new System.Drawing.Size(126, 41);
            this.supprimerDetailsEquipe.TabIndex = 2;
            this.supprimerDetailsEquipe.Text = "Supprimer";
            this.supprimerDetailsEquipe.UseVisualStyleBackColor = false;
            // 
            // texteNumeroEquipeDetailsEquipe
            // 
            this.texteNumeroEquipeDetailsEquipe.AutoSize = true;
            this.texteNumeroEquipeDetailsEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texteNumeroEquipeDetailsEquipe.Location = new System.Drawing.Point(44, 46);
            this.texteNumeroEquipeDetailsEquipe.Name = "texteNumeroEquipeDetailsEquipe";
            this.texteNumeroEquipeDetailsEquipe.Size = new System.Drawing.Size(74, 16);
            this.texteNumeroEquipeDetailsEquipe.TabIndex = 5;
            this.texteNumeroEquipeDetailsEquipe.Text = "Equipe n°";
            // 
            // logoDetailsEquipe
            // 
            this.logoDetailsEquipe.Image = ((System.Drawing.Image)(resources.GetObject("logoDetailsEquipe.Image")));
            this.logoDetailsEquipe.Location = new System.Drawing.Point(593, 3);
            this.logoDetailsEquipe.Name = "logoDetailsEquipe";
            this.logoDetailsEquipe.Size = new System.Drawing.Size(195, 214);
            this.logoDetailsEquipe.TabIndex = 8;
            this.logoDetailsEquipe.TabStop = false;
            // 
            // tableauDetailsEquipe
            // 
            this.tableauDetailsEquipe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pseudoTableauDetailsEquipe,
            this.nomTableauDetailsEquipe,
            this.roleTableauDetailsEquipe,
            this.paystableauDetailsEquipe});
            this.tableauDetailsEquipe.FullRowSelect = true;
            this.tableauDetailsEquipe.HideSelection = false;
            this.tableauDetailsEquipe.Location = new System.Drawing.Point(110, 160);
            this.tableauDetailsEquipe.Name = "tableauDetailsEquipe";
            this.tableauDetailsEquipe.Size = new System.Drawing.Size(421, 179);
            this.tableauDetailsEquipe.TabIndex = 9;
            this.tableauDetailsEquipe.UseCompatibleStateImageBehavior = false;
            this.tableauDetailsEquipe.View = System.Windows.Forms.View.Details;
            // 
            // pseudoTableauDetailsEquipe
            // 
            this.pseudoTableauDetailsEquipe.Text = "Pseudo";
            this.pseudoTableauDetailsEquipe.Width = 100;
            // 
            // nomTableauDetailsEquipe
            // 
            this.nomTableauDetailsEquipe.Text = "Nom";
            this.nomTableauDetailsEquipe.Width = 100;
            // 
            // roleTableauDetailsEquipe
            // 
            this.roleTableauDetailsEquipe.Text = "Rôle";
            this.roleTableauDetailsEquipe.Width = 100;
            // 
            // paystableauDetailsEquipe
            // 
            this.paystableauDetailsEquipe.Text = "Pays";
            this.paystableauDetailsEquipe.Width = 100;
            // 
            // quitterDetailsEquipe
            // 
            this.quitterDetailsEquipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.quitterDetailsEquipe.ForeColor = System.Drawing.Color.White;
            this.quitterDetailsEquipe.Location = new System.Drawing.Point(12, 12);
            this.quitterDetailsEquipe.Name = "quitterDetailsEquipe";
            this.quitterDetailsEquipe.Size = new System.Drawing.Size(126, 41);
            this.quitterDetailsEquipe.TabIndex = 10;
            this.quitterDetailsEquipe.Text = "Retour";
            this.quitterDetailsEquipe.UseVisualStyleBackColor = false;
            this.quitterDetailsEquipe.Click += new System.EventHandler(this.quitterDetailsEquipe_Click);
            // 
            // headerDetailsEquipe
            // 
            this.headerDetailsEquipe.Controls.Add(this.idEquipe);
            this.headerDetailsEquipe.Controls.Add(this.nomEquipe);
            this.headerDetailsEquipe.Controls.Add(this.siteWebEquipe);
            this.headerDetailsEquipe.Location = new System.Drawing.Point(182, 12);
            this.headerDetailsEquipe.Name = "headerDetailsEquipe";
            this.headerDetailsEquipe.Size = new System.Drawing.Size(349, 142);
            this.headerDetailsEquipe.TabIndex = 15;
            this.headerDetailsEquipe.TabStop = false;
            this.headerDetailsEquipe.Text = "groupBox1";
            // 
            // nomEquipe
            // 
            this.nomEquipe.Location = new System.Drawing.Point(183, 47);
            this.nomEquipe.Name = "nomEquipe";
            this.nomEquipe.Size = new System.Drawing.Size(158, 20);
            this.nomEquipe.TabIndex = 6;
            // 
            // siteWebEquipe
            // 
            this.siteWebEquipe.Location = new System.Drawing.Point(183, 73);
            this.siteWebEquipe.Name = "siteWebEquipe";
            this.siteWebEquipe.Size = new System.Drawing.Size(158, 20);
            this.siteWebEquipe.TabIndex = 7;
            // 
            // idEquipe
            // 
            this.idEquipe.Location = new System.Drawing.Point(183, 21);
            this.idEquipe.Name = "idEquipe";
            this.idEquipe.Size = new System.Drawing.Size(158, 20);
            this.idEquipe.TabIndex = 8;
            // 
            // FormDetailEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.quitterDetailsEquipe);
            this.Controls.Add(this.logoDetailsEquipe);
            this.Controls.Add(this.supprimerDetailsEquipe);
            this.Controls.Add(this.modifierDetailsEquipe);
            this.Controls.Add(this.voirPlusDetailsEquipes);
            this.Controls.Add(this.tableauDetailsEquipe);
            this.Controls.Add(this.headerDetailsEquipe);
            this.Name = "FormDetailEquipe";
            this.Text = "Détails équipe";
            this.Load += new System.EventHandler(this.detailsEquipeChargement);
            ((System.ComponentModel.ISupportInitialize)(this.logoDetailsEquipe)).EndInit();
            this.headerDetailsEquipe.ResumeLayout(false);
            this.headerDetailsEquipe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voirPlusDetailsEquipes;
        private System.Windows.Forms.Button modifierDetailsEquipe;
        private System.Windows.Forms.Button supprimerDetailsEquipe;
        private System.Windows.Forms.Label texteNumeroEquipeDetailsEquipe;
        private System.Windows.Forms.PictureBox logoDetailsEquipe;
        private System.Windows.Forms.ListView tableauDetailsEquipe;
        private System.Windows.Forms.ColumnHeader pseudoTableauDetailsEquipe;
        private System.Windows.Forms.ColumnHeader nomTableauDetailsEquipe;
        private System.Windows.Forms.ColumnHeader roleTableauDetailsEquipe;
        private System.Windows.Forms.ColumnHeader paystableauDetailsEquipe;
        private System.Windows.Forms.Button quitterDetailsEquipe;
        private System.Windows.Forms.GroupBox headerDetailsEquipe;
        private System.Windows.Forms.TextBox nomEquipe;
        private System.Windows.Forms.TextBox siteWebEquipe;
        private System.Windows.Forms.TextBox idEquipe;
    }
}