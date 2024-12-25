namespace projetCoffee1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.BtnLogin = new Guna.UI.WinForms.GunaButton();
            this.TxtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.BtneyeHide = new System.Windows.Forms.PictureBox();
            this.BtneyeShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtneyeHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtneyeShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BaseColor = System.Drawing.Color.White;
            this.TxtPassword.BorderColor = System.Drawing.Color.Silver;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPassword.Location = new System.Drawing.Point(71, 348);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.Size = new System.Drawing.Size(225, 32);
            this.TxtPassword.TabIndex = 4;
            // 
            // BtnLogin
            // 
            this.BtnLogin.AnimationHoverSpeed = 0.07F;
            this.BtnLogin.AnimationSpeed = 0.03F;
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.BtnLogin.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Image = null;
            this.BtnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnLogin.Location = new System.Drawing.Point(111, 417);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.OnHoverBaseColor = System.Drawing.Color.White;
            this.BtnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnLogin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.BtnLogin.OnHoverImage = null;
            this.BtnLogin.OnPressedColor = System.Drawing.Color.White;
            this.BtnLogin.Radius = 20;
            this.BtnLogin.Size = new System.Drawing.Size(159, 47);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BaseColor = System.Drawing.Color.White;
            this.TxtUsername.BorderColor = System.Drawing.Color.Silver;
            this.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtUsername.Location = new System.Drawing.Point(71, 263);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.Size = new System.Drawing.Size(225, 33);
            this.TxtUsername.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // BtneyeHide
            // 
            this.BtneyeHide.BackColor = System.Drawing.Color.White;
            this.BtneyeHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtneyeHide.Image = ((System.Drawing.Image)(resources.GetObject("BtneyeHide.Image")));
            this.BtneyeHide.Location = new System.Drawing.Point(272, 348);
            this.BtneyeHide.Name = "BtneyeHide";
            this.BtneyeHide.Size = new System.Drawing.Size(24, 32);
            this.BtneyeHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtneyeHide.TabIndex = 10;
            this.BtneyeHide.TabStop = false;
            this.BtneyeHide.Click += new System.EventHandler(this.BtneyeHide_Click);
            // 
            // BtneyeShow
            // 
            this.BtneyeShow.BackColor = System.Drawing.Color.White;
            this.BtneyeShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BtneyeShow.Image = ((System.Drawing.Image)(resources.GetObject("BtneyeShow.Image")));
            this.BtneyeShow.Location = new System.Drawing.Point(272, 348);
            this.BtneyeShow.Name = "BtneyeShow";
            this.BtneyeShow.Size = new System.Drawing.Size(24, 32);
            this.BtneyeShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtneyeShow.TabIndex = 11;
            this.BtneyeShow.TabStop = false;
            this.BtneyeShow.Click += new System.EventHandler(this.BtneyeShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(373, 540);
            this.Controls.Add(this.BtneyeShow);
            this.Controls.Add(this.BtneyeHide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtneyeHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtneyeShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox TxtPassword;
        private Guna.UI.WinForms.GunaButton BtnLogin;
        private Guna.UI.WinForms.GunaTextBox TxtUsername;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox BtneyeShow;
        private System.Windows.Forms.PictureBox BtneyeHide;
    }
}

