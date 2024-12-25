namespace projetCoffee1
{
    partial class PlaceOrder
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
            this.CmbCat = new System.Windows.Forms.ComboBox();
            this.TxtOrderNum = new Guna.UI.WinForms.GunaTextBox();
            this.TxtSellerName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddToCart = new Guna.UI.WinForms.GunaButton();
            this.TxtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPlaceTheOrder = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRemove = new Guna.UI.WinForms.GunaButton();
            this.TxtAmount = new Guna.UI.WinForms.GunaTextBox();
            this.ItemsGv = new System.Windows.Forms.DataGridView();
            this.BtnViewOrders = new Guna.UI.WinForms.GunaButton();
            this.OrdersGv = new System.Windows.Forms.DataGridView();
            this.Datelbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // CmbCat
            // 
            this.CmbCat.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCat.FormattingEnabled = true;
            this.CmbCat.Items.AddRange(new object[] {
            "Food ",
            "Beverage"});
            this.CmbCat.Location = new System.Drawing.Point(17, 51);
            this.CmbCat.Name = "CmbCat";
            this.CmbCat.Size = new System.Drawing.Size(157, 36);
            this.CmbCat.TabIndex = 0;
            this.CmbCat.Text = "Category";
            this.CmbCat.SelectionChangeCommitted += new System.EventHandler(this.CmbCat_SelectionChangeCommitted);
            // 
            // TxtOrderNum
            // 
            this.TxtOrderNum.BaseColor = System.Drawing.Color.White;
            this.TxtOrderNum.BorderColor = System.Drawing.Color.Silver;
            this.TxtOrderNum.BorderSize = 0;
            this.TxtOrderNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtOrderNum.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtOrderNum.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtOrderNum.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtOrderNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtOrderNum.Location = new System.Drawing.Point(14, 146);
            this.TxtOrderNum.Name = "TxtOrderNum";
            this.TxtOrderNum.PasswordChar = '\0';
            this.TxtOrderNum.SelectedText = "";
            this.TxtOrderNum.Size = new System.Drawing.Size(160, 30);
            this.TxtOrderNum.TabIndex = 1;
            // 
            // TxtSellerName
            // 
            this.TxtSellerName.BaseColor = System.Drawing.Color.White;
            this.TxtSellerName.BorderColor = System.Drawing.Color.Silver;
            this.TxtSellerName.BorderSize = 0;
            this.TxtSellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSellerName.Enabled = false;
            this.TxtSellerName.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtSellerName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtSellerName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtSellerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSellerName.Location = new System.Drawing.Point(11, 233);
            this.TxtSellerName.Name = "TxtSellerName";
            this.TxtSellerName.PasswordChar = '\0';
            this.TxtSellerName.SelectedText = "";
            this.TxtSellerName.Size = new System.Drawing.Size(163, 30);
            this.TxtSellerName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Num";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seller Name";
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.AnimationHoverSpeed = 0.07F;
            this.BtnAddToCart.AnimationSpeed = 0.03F;
            this.BtnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddToCart.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnAddToCart.BorderColor = System.Drawing.Color.Black;
            this.BtnAddToCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAddToCart.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAddToCart.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddToCart.ForeColor = System.Drawing.Color.White;
            this.BtnAddToCart.Image = null;
            this.BtnAddToCart.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAddToCart.Location = new System.Drawing.Point(494, 220);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnAddToCart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAddToCart.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAddToCart.OnHoverImage = null;
            this.BtnAddToCart.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAddToCart.Radius = 10;
            this.BtnAddToCart.Size = new System.Drawing.Size(160, 30);
            this.BtnAddToCart.TabIndex = 6;
            this.BtnAddToCart.Text = "Add To Cart";
            this.BtnAddToCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BaseColor = System.Drawing.Color.White;
            this.TxtQuantity.BorderColor = System.Drawing.Color.Silver;
            this.TxtQuantity.BorderSize = 0;
            this.TxtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtQuantity.Location = new System.Drawing.Point(310, 220);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.PasswordChar = '\0';
            this.TxtQuantity.SelectedText = "";
            this.TxtQuantity.Size = new System.Drawing.Size(160, 30);
            this.TxtQuantity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // BtnPlaceTheOrder
            // 
            this.BtnPlaceTheOrder.AnimationHoverSpeed = 0.07F;
            this.BtnPlaceTheOrder.AnimationSpeed = 0.03F;
            this.BtnPlaceTheOrder.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlaceTheOrder.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnPlaceTheOrder.BorderColor = System.Drawing.Color.Black;
            this.BtnPlaceTheOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnPlaceTheOrder.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPlaceTheOrder.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlaceTheOrder.ForeColor = System.Drawing.Color.White;
            this.BtnPlaceTheOrder.Image = null;
            this.BtnPlaceTheOrder.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPlaceTheOrder.Location = new System.Drawing.Point(379, 465);
            this.BtnPlaceTheOrder.Name = "BtnPlaceTheOrder";
            this.BtnPlaceTheOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnPlaceTheOrder.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPlaceTheOrder.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnPlaceTheOrder.OnHoverImage = null;
            this.BtnPlaceTheOrder.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPlaceTheOrder.Radius = 10;
            this.BtnPlaceTheOrder.Size = new System.Drawing.Size(137, 29);
            this.BtnPlaceTheOrder.TabIndex = 10;
            this.BtnPlaceTheOrder.Text = "Place The Order";
            this.BtnPlaceTheOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPlaceTheOrder.Click += new System.EventHandler(this.BtnPlaceTheOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightPink;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(23, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order Amount";
            // 
            // BtnRemove
            // 
            this.BtnRemove.AnimationHoverSpeed = 0.07F;
            this.BtnRemove.AnimationSpeed = 0.03F;
            this.BtnRemove.BackColor = System.Drawing.Color.Transparent;
            this.BtnRemove.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnRemove.BorderColor = System.Drawing.Color.Black;
            this.BtnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.BtnRemove.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Image = null;
            this.BtnRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnRemove.Location = new System.Drawing.Point(211, 465);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnRemove.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnRemove.OnHoverImage = null;
            this.BtnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.BtnRemove.Radius = 10;
            this.BtnRemove.Size = new System.Drawing.Size(121, 29);
            this.BtnRemove.TabIndex = 12;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // TxtAmount
            // 
            this.TxtAmount.BaseColor = System.Drawing.Color.White;
            this.TxtAmount.BorderColor = System.Drawing.Color.Silver;
            this.TxtAmount.BorderSize = 0;
            this.TxtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.TxtAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TxtAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAmount.Location = new System.Drawing.Point(11, 360);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.PasswordChar = '\0';
            this.TxtAmount.SelectedText = "";
            this.TxtAmount.Size = new System.Drawing.Size(152, 39);
            this.TxtAmount.TabIndex = 13;
            this.TxtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            // 
            // ItemsGv
            // 
            this.ItemsGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGv.Location = new System.Drawing.Point(236, 38);
            this.ItemsGv.Name = "ItemsGv";
            this.ItemsGv.Size = new System.Drawing.Size(432, 166);
            this.ItemsGv.TabIndex = 14;
            this.ItemsGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGv_CellContentClick);
            // 
            // BtnViewOrders
            // 
            this.BtnViewOrders.AnimationHoverSpeed = 0.07F;
            this.BtnViewOrders.AnimationSpeed = 0.03F;
            this.BtnViewOrders.BackColor = System.Drawing.Color.Transparent;
            this.BtnViewOrders.BaseColor = System.Drawing.Color.DeepPink;
            this.BtnViewOrders.BorderColor = System.Drawing.Color.Black;
            this.BtnViewOrders.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnViewOrders.FocusedColor = System.Drawing.Color.Empty;
            this.BtnViewOrders.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewOrders.ForeColor = System.Drawing.Color.White;
            this.BtnViewOrders.Image = null;
            this.BtnViewOrders.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnViewOrders.Location = new System.Drawing.Point(542, 465);
            this.BtnViewOrders.Name = "BtnViewOrders";
            this.BtnViewOrders.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnViewOrders.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnViewOrders.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnViewOrders.OnHoverImage = null;
            this.BtnViewOrders.OnPressedColor = System.Drawing.Color.Black;
            this.BtnViewOrders.Radius = 10;
            this.BtnViewOrders.Size = new System.Drawing.Size(126, 29);
            this.BtnViewOrders.TabIndex = 16;
            this.BtnViewOrders.Text = "View orders";
            this.BtnViewOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnViewOrders.Click += new System.EventHandler(this.BtnViewOrders_Click);
            // 
            // OrdersGv
            // 
            this.OrdersGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGv.Location = new System.Drawing.Point(236, 283);
            this.OrdersGv.Name = "OrdersGv";
            this.OrdersGv.Size = new System.Drawing.Size(432, 156);
            this.OrdersGv.TabIndex = 17;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.BackColor = System.Drawing.Color.White;
            this.Datelbl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.Crimson;
            this.Datelbl.Location = new System.Drawing.Point(91, 7);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(49, 28);
            this.Datelbl.TabIndex = 18;
            this.Datelbl.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(169, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "DT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(385, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "List Of Items";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(385, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Customer Order";
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(701, 506);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.OrdersGv);
            this.Controls.Add(this.BtnViewOrders);
            this.Controls.Add(this.ItemsGv);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnPlaceTheOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSellerName);
            this.Controls.Add(this.TxtOrderNum);
            this.Controls.Add(this.CmbCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaceOrder";
            this.Text = "Add To Cart";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.ComboBox CmbCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox TxtSellerName;
        private Guna.UI.WinForms.GunaTextBox TxtOrderNum;
        private Guna.UI.WinForms.GunaTextBox TxtAmount;
        private Guna.UI.WinForms.GunaButton BtnRemove;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton BtnPlaceTheOrder;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox TxtQuantity;
        private Guna.UI.WinForms.GunaButton BtnAddToCart;
        private System.Windows.Forms.DataGridView ItemsGv;
        private Guna.UI.WinForms.GunaButton BtnViewOrders;
        private System.Windows.Forms.DataGridView OrdersGv;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}