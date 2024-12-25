namespace projetCoffee1
{
    partial class ManageItems
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
            this.TxtItemNum = new Guna.UI.WinForms.GunaTextBox();
            this.TxtItemName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbcat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtItemPrice = new Guna.UI.WinForms.GunaTextBox();
            this.BtnAdd = new Guna.UI.WinForms.GunaButton();
            this.BtnEdit = new Guna.UI.WinForms.GunaButton();
            this.BtnDelete = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemsGv = new System.Windows.Forms.DataGridView();
            this.BtnClear = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGv)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // TxtItemNum
            // 
            this.TxtItemNum.BaseColor = System.Drawing.Color.White;
            this.TxtItemNum.BorderColor = System.Drawing.Color.Silver;
            this.TxtItemNum.BorderSize = 0;
            this.TxtItemNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtItemNum.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtItemNum.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtItemNum.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtItemNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtItemNum.Location = new System.Drawing.Point(25, 73);
            this.TxtItemNum.Name = "TxtItemNum";
            this.TxtItemNum.PasswordChar = '\0';
            this.TxtItemNum.SelectedText = "";
            this.TxtItemNum.Size = new System.Drawing.Size(160, 30);
            this.TxtItemNum.TabIndex = 0;
            // 
            // TxtItemName
            // 
            this.TxtItemName.BaseColor = System.Drawing.Color.White;
            this.TxtItemName.BorderColor = System.Drawing.Color.Silver;
            this.TxtItemName.BorderSize = 0;
            this.TxtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtItemName.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtItemName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtItemName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtItemName.Location = new System.Drawing.Point(25, 165);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.PasswordChar = '\0';
            this.TxtItemName.SelectedText = "";
            this.TxtItemName.Size = new System.Drawing.Size(160, 30);
            this.TxtItemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Name";
            // 
            // Cbcat
            // 
            this.Cbcat.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbcat.FormattingEnabled = true;
            this.Cbcat.Items.AddRange(new object[] {
            "Food ",
            "Beverage"});
            this.Cbcat.Location = new System.Drawing.Point(25, 239);
            this.Cbcat.Name = "Cbcat";
            this.Cbcat.Size = new System.Drawing.Size(160, 36);
            this.Cbcat.TabIndex = 4;
            this.Cbcat.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Price";
            // 
            // TxtItemPrice
            // 
            this.TxtItemPrice.BaseColor = System.Drawing.Color.White;
            this.TxtItemPrice.BorderColor = System.Drawing.Color.Silver;
            this.TxtItemPrice.BorderSize = 0;
            this.TxtItemPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtItemPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtItemPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtItemPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtItemPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtItemPrice.Location = new System.Drawing.Point(25, 340);
            this.TxtItemPrice.Name = "TxtItemPrice";
            this.TxtItemPrice.PasswordChar = '\0';
            this.TxtItemPrice.SelectedText = "";
            this.TxtItemPrice.Size = new System.Drawing.Size(160, 30);
            this.TxtItemPrice.TabIndex = 6;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AnimationHoverSpeed = 0.07F;
            this.BtnAdd.AnimationSpeed = 0.03F;
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnAdd.BorderColor = System.Drawing.Color.Black;
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Image = null;
            this.BtnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAdd.Location = new System.Drawing.Point(241, 328);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAdd.OnHoverImage = null;
            this.BtnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAdd.Radius = 10;
            this.BtnAdd.Size = new System.Drawing.Size(85, 42);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AnimationHoverSpeed = 0.07F;
            this.BtnEdit.AnimationSpeed = 0.03F;
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnEdit.BorderColor = System.Drawing.Color.Black;
            this.BtnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Image = null;
            this.BtnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEdit.Location = new System.Drawing.Point(361, 328);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEdit.OnHoverImage = null;
            this.BtnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEdit.Radius = 10;
            this.BtnEdit.Size = new System.Drawing.Size(85, 42);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AnimationHoverSpeed = 0.07F;
            this.BtnDelete.AnimationSpeed = 0.03F;
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnDelete.BorderColor = System.Drawing.Color.Black;
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Image = null;
            this.BtnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDelete.Location = new System.Drawing.Point(483, 328);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDelete.OnHoverImage = null;
            this.BtnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDelete.Radius = 10;
            this.BtnDelete.Size = new System.Drawing.Size(83, 42);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(387, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Items List";
            // 
            // ItemsGv
            // 
            this.ItemsGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGv.Location = new System.Drawing.Point(241, 73);
            this.ItemsGv.Name = "ItemsGv";
            this.ItemsGv.Size = new System.Drawing.Size(439, 212);
            this.ItemsGv.TabIndex = 11;
            this.ItemsGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGv_CellContentClick);
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
            this.BtnClear.Location = new System.Drawing.Point(593, 328);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnClear.OnHoverImage = null;
            this.BtnClear.OnPressedColor = System.Drawing.Color.Black;
            this.BtnClear.Radius = 10;
            this.BtnClear.Size = new System.Drawing.Size(87, 42);
            this.BtnClear.TabIndex = 12;
            this.BtnClear.Text = "Clear";
            this.BtnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(701, 506);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.ItemsGv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtItemPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtItemName);
            this.Controls.Add(this.TxtItemNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageItems";
            this.Load += new System.EventHandler(this.ManageItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton BtnDelete;
        private Guna.UI.WinForms.GunaButton BtnEdit;
        private Guna.UI.WinForms.GunaButton BtnAdd;
        private Guna.UI.WinForms.GunaTextBox TxtItemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbcat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox TxtItemName;
        private Guna.UI.WinForms.GunaTextBox TxtItemNum;
        private System.Windows.Forms.DataGridView ItemsGv;
        private Guna.UI.WinForms.GunaButton BtnClear;
    }
}