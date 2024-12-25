namespace projetCoffee1
{
    partial class ViewOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrdersForm));
            this.ViewOedersGv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new Guna.UI.WinForms.GunaButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOedersGv)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewOedersGv
            // 
            this.ViewOedersGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewOedersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOedersGv.Location = new System.Drawing.Point(110, 35);
            this.ViewOedersGv.Name = "ViewOedersGv";
            this.ViewOedersGv.Size = new System.Drawing.Size(534, 496);
            this.ViewOedersGv.TabIndex = 15;
            this.ViewOedersGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewOedersGv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "LIST OF ORDERS";
            // 
            // BtnClose
            // 
            this.BtnClose.AnimationHoverSpeed = 0.07F;
            this.BtnClose.AnimationSpeed = 0.03F;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BaseColor = System.Drawing.Color.MistyRose;
            this.BtnClose.BorderColor = System.Drawing.Color.Black;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnClose.FocusedColor = System.Drawing.Color.Empty;
            this.BtnClose.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Crimson;
            this.BtnClose.Image = null;
            this.BtnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnClose.Location = new System.Drawing.Point(301, 550);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnClose.OnHoverImage = null;
            this.BtnClose.OnPressedColor = System.Drawing.Color.Black;
            this.BtnClose.Radius = 10;
            this.BtnClose.Size = new System.Drawing.Size(146, 34);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(759, 610);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewOedersGv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewOedersGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewOedersGv;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton BtnClose;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}