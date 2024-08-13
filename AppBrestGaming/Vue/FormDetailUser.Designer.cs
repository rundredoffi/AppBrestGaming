
namespace AppBrestGaming.Vue
{
    partial class FormDetailUser
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelValeurId = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.ListeDeroulante_Role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnnuler.Location = new System.Drawing.Point(509, 241);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(86, 37);
            this.buttonAnnuler.TabIndex = 29;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonValider.Location = new System.Drawing.Point(509, 290);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(86, 37);
            this.buttonValider.TabIndex = 28;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOK.Location = new System.Drawing.Point(527, 280);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(80, 37);
            this.buttonOK.TabIndex = 27;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(170, 180);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(264, 28);
            this.textBoxPassword.TabIndex = 24;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(170, 129);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(264, 28);
            this.textBoxLogin.TabIndex = 23;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(110, 243);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(49, 24);
            this.labelRole.TabIndex = 22;
            this.labelRole.Text = "Role";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(39, 184);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(123, 24);
            this.labelPassword.TabIndex = 20;
            this.labelPassword.Text = "Mot de passe";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(103, 133);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(57, 24);
            this.labelLogin.TabIndex = 19;
            this.labelLogin.Text = "Login";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(170, 78);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(264, 28);
            this.textBoxPrenom.TabIndex = 18;
            // 
            // labelValeurId
            // 
            this.labelValeurId.AutoSize = true;
            this.labelValeurId.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelValeurId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValeurId.Location = new System.Drawing.Point(166, 27);
            this.labelValeurId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValeurId.Name = "labelValeurId";
            this.labelValeurId.Size = new System.Drawing.Size(20, 24);
            this.labelValeurId.TabIndex = 17;
            this.labelValeurId.Text = "x";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(133, 27);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 24);
            this.labelId.TabIndex = 16;
            this.labelId.Text = "Id";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(84, 82);
            this.labelPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(77, 24);
            this.labelPrenom.TabIndex = 15;
            this.labelPrenom.Text = "Prénom";
            // 
            // ListeDeroulante_Role
            // 
            this.ListeDeroulante_Role.FormattingEnabled = true;
            this.ListeDeroulante_Role.Location = new System.Drawing.Point(170, 241);
            this.ListeDeroulante_Role.Name = "ListeDeroulante_Role";
            this.ListeDeroulante_Role.Size = new System.Drawing.Size(264, 21);
            this.ListeDeroulante_Role.TabIndex = 31;
            // 
            // FormDetailUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 351);
            this.ControlBox = false;
            this.Controls.Add(this.ListeDeroulante_Role);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelValeurId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelPrenom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDetailUser";
            this.Text = "Utilisateur";
            this.Load += new System.EventHandler(this.FormDetailUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelValeurId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.ComboBox ListeDeroulante_Role;
    }
}