
namespace AppBrestGaming.Vue
{
    partial class FormListeChambres
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.tableauChambres = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(270, 32);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(318, 40);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Liste des chambres";
            // 
            // tableauChambres
            // 
            this.tableauChambres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tableauChambres.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableauChambres.FullRowSelect = true;
            this.tableauChambres.GridLines = true;
            this.tableauChambres.HideSelection = false;
            this.tableauChambres.Location = new System.Drawing.Point(113, 114);
            this.tableauChambres.MultiSelect = false;
            this.tableauChambres.Name = "tableauChambres";
            this.tableauChambres.Size = new System.Drawing.Size(627, 294);
            this.tableauChambres.TabIndex = 2;
            this.tableauChambres.UseCompatibleStateImageBehavior = false;
            this.tableauChambres.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Étage";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Capacité";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prix par nuit";
            this.columnHeader4.Width = 150;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMenu.Location = new System.Drawing.Point(627, 442);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(113, 42);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // FormListeChambres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 510);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.tableauChambres);
            this.Controls.Add(this.labelTitre);
            this.Name = "FormListeChambres";
            this.Text = "Chambres";
            this.Load += new System.EventHandler(this.FormListeChambres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.ListView tableauChambres;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonMenu;
    }
}