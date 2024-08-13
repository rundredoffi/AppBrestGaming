
namespace AppBrestGaming.Vue
{
    partial class FormListeUsers
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
            this.buttonSuppression = new System.Windows.Forms.Button();
            this.buttonModification = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.tableauUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSuppression
            // 
            this.buttonSuppression.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSuppression.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuppression.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSuppression.Location = new System.Drawing.Point(587, 72);
            this.buttonSuppression.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSuppression.Name = "buttonSuppression";
            this.buttonSuppression.Size = new System.Drawing.Size(139, 41);
            this.buttonSuppression.TabIndex = 13;
            this.buttonSuppression.Text = "Suppression";
            this.buttonSuppression.UseVisualStyleBackColor = false;
            this.buttonSuppression.Click += new System.EventHandler(this.buttonSuppression_Click);
            // 
            // buttonModification
            // 
            this.buttonModification.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonModification.Location = new System.Drawing.Point(409, 72);
            this.buttonModification.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModification.Name = "buttonModification";
            this.buttonModification.Size = new System.Drawing.Size(139, 41);
            this.buttonModification.TabIndex = 12;
            this.buttonModification.Text = "Modification";
            this.buttonModification.UseVisualStyleBackColor = false;
            this.buttonModification.Click += new System.EventHandler(this.buttonModification_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAjout.Location = new System.Drawing.Point(230, 72);
            this.buttonAjout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(139, 41);
            this.buttonAjout.TabIndex = 11;
            this.buttonAjout.Text = "Ajout";
            this.buttonAjout.UseVisualStyleBackColor = false;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDetail.Location = new System.Drawing.Point(42, 72);
            this.buttonDetail.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(139, 41);
            this.buttonDetail.TabIndex = 10;
            this.buttonDetail.Text = "Détail";
            this.buttonDetail.UseVisualStyleBackColor = false;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMenu.Location = new System.Drawing.Point(641, 414);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(85, 47);
            this.buttonMenu.TabIndex = 9;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // tableauUsers
            // 
            this.tableauUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.tableauUsers.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableauUsers.FullRowSelect = true;
            this.tableauUsers.GridLines = true;
            this.tableauUsers.HideSelection = false;
            this.tableauUsers.Location = new System.Drawing.Point(42, 133);
            this.tableauUsers.Margin = new System.Windows.Forms.Padding(2);
            this.tableauUsers.MultiSelect = false;
            this.tableauUsers.Name = "tableauUsers";
            this.tableauUsers.Size = new System.Drawing.Size(685, 276);
            this.tableauUsers.TabIndex = 8;
            this.tableauUsers.UseCompatibleStateImageBehavior = false;
            this.tableauUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prénom";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Login";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mot de passe";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rôle";
            this.columnHeader4.Width = 100;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(260, 15);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(269, 31);
            this.labelTitre.TabIndex = 7;
            this.labelTitre.Text = "Liste des utilisateurs";
            // 
            // FormListeUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 474);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSuppression);
            this.Controls.Add(this.buttonModification);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.tableauUsers);
            this.Controls.Add(this.labelTitre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListeUsers";
            this.Text = "Utilisateurs";
            this.Load += new System.EventHandler(this.FormListeUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSuppression;
        private System.Windows.Forms.Button buttonModification;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ListView tableauUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}