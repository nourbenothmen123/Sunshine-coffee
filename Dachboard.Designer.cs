namespace projetCoffee1
{
    partial class Dachboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dachboard));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.PnlContent = new System.Windows.Forms.Panel();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.BtnLogOut = new System.Windows.Forms.LinkLabel();
            this.BtnMngUsers = new Guna.UI.WinForms.GunaButton();
            this.BtnMngItems = new Guna.UI.WinForms.GunaButton();
            this.BtnPlaceOrder = new Guna.UI.WinForms.GunaButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // PnlContent
            // 
            this.PnlContent.BackColor = System.Drawing.Color.White;
            this.PnlContent.Location = new System.Drawing.Point(223, 12);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(701, 506);
            this.PnlContent.TabIndex = 0;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 10;
            this.gunaElipse2.TargetControl = this.PnlContent;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.gunaCirclePictureBox1);
            this.panel2.Controls.Add(this.BtnLogOut);
            this.panel2.Controls.Add(this.BtnMngUsers);
            this.panel2.Controls.Add(this.BtnMngItems);
            this.panel2.Controls.Add(this.BtnPlaceOrder);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 506);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coffee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sunrise";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Webdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(64, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(63, -1);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(84, 83);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.AutoSize = true;
            this.BtnLogOut.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.Black;
            this.BtnLogOut.LinkColor = System.Drawing.Color.White;
            this.BtnLogOut.Location = new System.Drawing.Point(57, 456);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(93, 33);
            this.BtnLogOut.TabIndex = 0;
            this.BtnLogOut.TabStop = true;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnLogOut_LinkClicked);
            // 
            // BtnMngUsers
            // 
            this.BtnMngUsers.AnimationHoverSpeed = 0.07F;
            this.BtnMngUsers.AnimationSpeed = 0.03F;
            this.BtnMngUsers.BaseColor = System.Drawing.Color.Crimson;
            this.BtnMngUsers.BorderColor = System.Drawing.Color.Black;
            this.BtnMngUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnMngUsers.FocusedColor = System.Drawing.Color.Empty;
            this.BtnMngUsers.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMngUsers.ForeColor = System.Drawing.Color.White;
            this.BtnMngUsers.Image = ((System.Drawing.Image)(resources.GetObject("BtnMngUsers.Image")));
            this.BtnMngUsers.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnMngUsers.Location = new System.Drawing.Point(27, 341);
            this.BtnMngUsers.Name = "BtnMngUsers";
            this.BtnMngUsers.OnHoverBaseColor = System.Drawing.Color.White;
            this.BtnMngUsers.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnMngUsers.OnHoverForeColor = System.Drawing.Color.Crimson;
            this.BtnMngUsers.OnHoverImage = null;
            this.BtnMngUsers.OnPressedColor = System.Drawing.Color.Black;
            this.BtnMngUsers.Size = new System.Drawing.Size(196, 42);
            this.BtnMngUsers.TabIndex = 2;
            this.BtnMngUsers.Text = "Manage Users";
            this.BtnMngUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnMngUsers.Click += new System.EventHandler(this.BtnMngUsers_Click);
            // 
            // BtnMngItems
            // 
            this.BtnMngItems.AnimationHoverSpeed = 0.07F;
            this.BtnMngItems.AnimationSpeed = 0.03F;
            this.BtnMngItems.BaseColor = System.Drawing.Color.Crimson;
            this.BtnMngItems.BorderColor = System.Drawing.Color.Black;
            this.BtnMngItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnMngItems.FocusedColor = System.Drawing.Color.Empty;
            this.BtnMngItems.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMngItems.ForeColor = System.Drawing.Color.White;
            this.BtnMngItems.Image = ((System.Drawing.Image)(resources.GetObject("BtnMngItems.Image")));
            this.BtnMngItems.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnMngItems.Location = new System.Drawing.Point(27, 246);
            this.BtnMngItems.Name = "BtnMngItems";
            this.BtnMngItems.OnHoverBaseColor = System.Drawing.Color.White;
            this.BtnMngItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnMngItems.OnHoverForeColor = System.Drawing.Color.Crimson;
            this.BtnMngItems.OnHoverImage = null;
            this.BtnMngItems.OnPressedColor = System.Drawing.Color.Black;
            this.BtnMngItems.Size = new System.Drawing.Size(196, 42);
            this.BtnMngItems.TabIndex = 1;
            this.BtnMngItems.Text = "Manage Items";
            this.BtnMngItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnMngItems.Click += new System.EventHandler(this.BtnMngItems_Click);
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.AnimationHoverSpeed = 0.07F;
            this.BtnPlaceOrder.AnimationSpeed = 0.03F;
            this.BtnPlaceOrder.BaseColor = System.Drawing.Color.Crimson;
            this.BtnPlaceOrder.BorderColor = System.Drawing.Color.Black;
            this.BtnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPlaceOrder.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPlaceOrder.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.BtnPlaceOrder.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlaceOrder.Image")));
            this.BtnPlaceOrder.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnPlaceOrder.Location = new System.Drawing.Point(27, 153);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.OnHoverBaseColor = System.Drawing.Color.White;
            this.BtnPlaceOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPlaceOrder.OnHoverForeColor = System.Drawing.Color.Crimson;
            this.BtnPlaceOrder.OnHoverImage = null;
            this.BtnPlaceOrder.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPlaceOrder.Size = new System.Drawing.Size(196, 42);
            this.BtnPlaceOrder.TabIndex = 0;
            this.BtnPlaceOrder.Text = "Place Order";
            this.BtnPlaceOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // Dachboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(936, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dachboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dachboard";
            this.Load += new System.EventHandler(this.Dachboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton BtnMngItems;
        private Guna.UI.WinForms.GunaButton BtnPlaceOrder;
        private System.Windows.Forms.Panel PnlContent;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.LinkLabel BtnLogOut;
        private Guna.UI.WinForms.GunaButton BtnMngUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}