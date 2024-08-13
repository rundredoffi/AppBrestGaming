
namespace AppBrestGaming.Vue
{
    partial class FormListeJoueurs
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
            this.components = new System.ComponentModel.Container();
            this.tableauJoueurs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRetourMenu = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.buttonSupp = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tableauJoueurs
            // 
            this.tableauJoueurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.tableauJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableauJoueurs.FullRowSelect = true;
            this.tableauJoueurs.GridLines = true;
            this.tableauJoueurs.HideSelection = false;
            this.tableauJoueurs.Location = new System.Drawing.Point(46, 113);
            this.tableauJoueurs.Margin = new System.Windows.Forms.Padding(2);
            this.tableauJoueurs.MultiSelect = false;
            this.tableauJoueurs.Name = "tableauJoueurs";
            this.tableauJoueurs.Size = new System.Drawing.Size(648, 305);
            this.tableauJoueurs.TabIndex = 0;
            this.tableauJoueurs.UseCompatibleStateImageBehavior = false;
            this.tableauJoueurs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pseudo";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nom";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Pays";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Rôle";
            this.columnHeader5.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des participants";
            // 
            // buttonRetourMenu
            // 
            this.buttonRetourMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetourMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRetourMenu.Location = new System.Drawing.Point(716, 381);
            this.buttonRetourMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetourMenu.Name = "buttonRetourMenu";
            this.buttonRetourMenu.Size = new System.Drawing.Size(80, 37);
            this.buttonRetourMenu.TabIndex = 2;
            this.buttonRetourMenu.Text = "Menu";
            this.buttonRetourMenu.UseVisualStyleBackColor = false;
            this.buttonRetourMenu.Click += new System.EventHandler(this.buttonRetourMenu_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDetail.Location = new System.Drawing.Point(46, 62);
            this.buttonDetail.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(130, 37);
            this.buttonDetail.TabIndex = 3;
            this.buttonDetail.Text = "Détail";
            this.buttonDetail.UseVisualStyleBackColor = false;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAjout.Location = new System.Drawing.Point(197, 62);
            this.buttonAjout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(130, 37);
            this.buttonAjout.TabIndex = 4;
            this.buttonAjout.Text = "Ajout";
            this.buttonAjout.UseVisualStyleBackColor = false;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModif.Location = new System.Drawing.Point(347, 62);
            this.buttonModif.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(130, 37);
            this.buttonModif.TabIndex = 5;
            this.buttonModif.Text = "Modification";
            this.buttonModif.UseVisualStyleBackColor = false;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // buttonSupp
            // 
            this.buttonSupp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupp.Location = new System.Drawing.Point(497, 62);
            this.buttonSupp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupp.Name = "buttonSupp";
            this.buttonSupp.Size = new System.Drawing.Size(130, 37);
            this.buttonSupp.TabIndex = 6;
            this.buttonSupp.Text = "Suppression";
            this.buttonSupp.UseVisualStyleBackColor = false;
            this.buttonSupp.Click += new System.EventHandler(this.buttonSupp_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormListeJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 444);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSupp);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonRetourMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableauJoueurs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListeJoueurs";
            this.Text = "Gestion des équipes";
            this.Load += new System.EventHandler(this.FormListeJoueurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView tableauJoueurs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRetourMenu;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Button buttonSupp;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}