namespace projetCoffee1
{
    partial class ManageUsers
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.TxtName = new Guna.UI.WinForms.GunaTextBox();
            this.TxtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsersGv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddUser = new Guna.UI.WinForms.GunaButton();
            this.BtnEditUser = new Guna.UI.WinForms.GunaButton();
            this.BtnDeleteUser = new Guna.UI.WinForms.GunaButton();
            this.BtnClear = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGv)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // TxtName
            // 
            this.TxtName.BaseColor = System.Drawing.Color.White;
            this.TxtName.BorderColor = System.Drawing.Color.Silver;
            this.TxtName.BorderSize = 0;
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtName.Location = new System.Drawing.Point(12, 110);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.SelectedText = "";
            this.TxtName.Size = new System.Drawing.Size(148, 30);
            this.TxtName.TabIndex = 0;
            // 
            // TxtPhone
            // 
            this.TxtPhone.BaseColor = System.Drawing.Color.White;
            this.TxtPhone.BorderColor = System.Drawing.Color.Silver;
            this.TxtPhone.BorderSize = 0;
            this.TxtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPhone.Location = new System.Drawing.Point(12, 200);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.PasswordChar = '\0';
            this.TxtPhone.SelectedText = "";
            this.TxtPhone.Size = new System.Drawing.Size(148, 31);
            this.TxtPhone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BaseColor = System.Drawing.Color.White;
            this.TxtPassword.BorderColor = System.Drawing.Color.Silver;
            this.TxtPassword.BorderSize = 0;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPassword.Location = new System.Drawing.Point(12, 295);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.Size = new System.Drawing.Size(148, 30);
            this.TxtPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // UsersGv
            // 
            this.UsersGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGv.Location = new System.Drawing.Point(202, 72);
            this.UsersGv.Name = "UsersGv";
            this.UsersGv.Size = new System.Drawing.Size(456, 237);
            this.UsersGv.TabIndex = 8;
            this.UsersGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGv_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(369, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Users List";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.AnimationHoverSpeed = 0.07F;
            this.BtnAddUser.AnimationSpeed = 0.03F;
            this.BtnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddUser.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnAddUser.BorderColor = System.Drawing.Color.Black;
            this.BtnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAddUser.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddUser.ForeColor = System.Drawing.Color.White;
            this.BtnAddUser.Image = null;
            this.BtnAddUser.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAddUser.Location = new System.Drawing.Point(202, 346);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnAddUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAddUser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAddUser.OnHoverImage = null;
            this.BtnAddUser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAddUser.Radius = 10;
            this.BtnAddUser.Size = new System.Drawing.Size(87, 42);
            this.BtnAddUser.TabIndex = 12;
            this.BtnAddUser.Text = "Add";
            this.BtnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.AnimationHoverSpeed = 0.07F;
            this.BtnEditUser.AnimationSpeed = 0.03F;
            this.BtnEditUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditUser.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnEditUser.BorderColor = System.Drawing.Color.Black;
            this.BtnEditUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEditUser.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEditUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEditUser.ForeColor = System.Drawing.Color.White;
            this.BtnEditUser.Image = null;
            this.BtnEditUser.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEditUser.Location = new System.Drawing.Point(329, 346);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnEditUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEditUser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEditUser.OnHoverImage = null;
            this.BtnEditUser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEditUser.Radius = 10;
            this.BtnEditUser.Size = new System.Drawing.Size(87, 42);
            this.BtnEditUser.TabIndex = 13;
            this.BtnEditUser.Text = "Edit";
            this.BtnEditUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.AnimationHoverSpeed = 0.07F;
            this.BtnDeleteUser.AnimationSpeed = 0.03F;
            this.BtnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteUser.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnDeleteUser.BorderColor = System.Drawing.Color.Black;
            this.BtnDeleteUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDeleteUser.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteUser.Image = null;
            this.BtnDeleteUser.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDeleteUser.Location = new System.Drawing.Point(451, 346);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnDeleteUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDeleteUser.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDeleteUser.OnHoverImage = null;
            this.BtnDeleteUser.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDeleteUser.Radius = 10;
            this.BtnDeleteUser.Size = new System.Drawing.Size(88, 42);
            this.BtnDeleteUser.TabIndex = 14;
            this.BtnDeleteUser.Text = "Delete";
            this.BtnDeleteUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AnimationHoverSpeed = 0.07F;
            this.BtnClear.AnimationSpeed = 0.03F;
            this.BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.BtnClear.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnClear.BorderColor = System.Drawing.Color.Black;
            this.BtnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnClear.FocusedColor = System.Drawing.Color.Empty;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Image = null;
            this.BtnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnClear.Location = new System.Drawing.Point(569, 346);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnClear.OnHoverImage = null;
            this.BtnClear.OnPressedColor = System.Drawing.Color.Black;
            this.BtnClear.Radius = 10;
            this.BtnClear.Size = new System.Drawing.Size(89, 42);
            this.BtnClear.TabIndex = 19;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(685, 467);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.BtnEditUser);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UsersGv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.DataGridView UsersGv;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox TxtPhone;
        private Guna.UI.WinForms.GunaTextBox TxtName;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton BtnDeleteUser;
        private Guna.UI.WinForms.GunaButton BtnEditUser;
        private Guna.UI.WinForms.GunaButton BtnAddUser;
        private Guna.UI.WinForms.GunaButton BtnClear;
    }
}