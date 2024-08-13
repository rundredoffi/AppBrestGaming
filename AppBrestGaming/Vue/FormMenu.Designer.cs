
namespace AppBrestGaming.Vue
{
    partial class FormMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonChambres = new System.Windows.Forms.Button();
            this.buttonJoueurs = new System.Windows.Forms.Button();
            this.buttonEquipes = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.buttonJeux = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion du tournoi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.buttonJeux);
            this.groupBox1.Controls.Add(this.buttonAdmin);
            this.groupBox1.Controls.Add(this.buttonChambres);
            this.groupBox1.Controls.Add(this.buttonJoueurs);
            this.groupBox1.Controls.Add(this.buttonEquipes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(128, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(382, 347);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdmin.Location = new System.Drawing.Point(89, 270);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(206, 41);
            this.buttonAdmin.TabIndex = 4;
            this.buttonAdmin.Text = "Administration";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonChambres
            // 
            this.buttonChambres.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChambres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChambres.Location = new System.Drawing.Point(89, 207);
            this.buttonChambres.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChambres.Name = "buttonChambres";
            this.buttonChambres.Size = new System.Drawing.Size(206, 41);
            this.buttonChambres.TabIndex = 2;
            this.buttonChambres.Text = "Chambres";
            this.buttonChambres.UseVisualStyleBackColor = false;
            this.buttonChambres.Click += new System.EventHandler(this.buttonChambres_Click);
            // 
            // buttonJoueurs
            // 
            this.buttonJoueurs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJoueurs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonJoueurs.Location = new System.Drawing.Point(89, 91);
            this.buttonJoueurs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJoueurs.Name = "buttonJoueurs";
            this.buttonJoueurs.Size = new System.Drawing.Size(206, 41);
            this.buttonJoueurs.TabIndex = 1;
            this.buttonJoueurs.Text = "Participants";
            this.buttonJoueurs.UseVisualStyleBackColor = false;
            this.buttonJoueurs.Click += new System.EventHandler(this.buttonJoueurs_Click);
            // 
            // buttonEquipes
            // 
            this.buttonEquipes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEquipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquipes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEquipes.Location = new System.Drawing.Point(89, 30);
            this.buttonEquipes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEquipes.Name = "buttonEquipes";
            this.buttonEquipes.Size = new System.Drawing.Size(206, 41);
            this.buttonEquipes.TabIndex = 0;
            this.buttonEquipes.Text = "Équipes";
            this.buttonEquipes.UseVisualStyleBackColor = false;
            this.buttonEquipes.Click += new System.EventHandler(this.buttonEquipes_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuitter.Location = new System.Drawing.Point(562, 427);
            this.buttonQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(70, 34);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = false;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // buttonJeux
            // 
            this.buttonJeux.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJeux.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonJeux.Location = new System.Drawing.Point(89, 149);
            this.buttonJeux.Margin = new System.Windows.Forms.Padding(2);
            this.buttonJeux.Name = "buttonJeux";
            this.buttonJeux.Size = new System.Drawing.Size(206, 41);
            this.buttonJeux.TabIndex = 5;
            this.buttonJeux.Text = "Jeux";
            this.buttonJeux.UseVisualStyleBackColor = false;
            this.buttonJeux.Click += new System.EventHandler(this.buttonJeux_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(642, 527);
            this.ControlBox = false;
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEquipes;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonChambres;
        private System.Windows.Forms.Button buttonJoueurs;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonJeux;
    }
}