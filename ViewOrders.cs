using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projetCoffee1
{
    public partial class ViewOrdersForm : Form
    {
        public ViewOrdersForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bdSysMngtCoffee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from Orders";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewOedersGv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void ViewOedersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("===== Sunrise Coffee =====",new Font("Abeezee",20,FontStyle.Bold),Brushes.Red,new Point(200,40));
            e.Graphics.DrawString("====== Order Summary ======", new Font("Abeezee", 20, FontStyle.Bold), Brushes.Red, new Point(208,70));
            e.Graphics.DrawString("Number: "+ViewOedersGv.SelectedRows[0].Cells[0].Value.ToString(),new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 135)) ;
            e.Graphics.DrawString("Date: "+ViewOedersGv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 170));
            e.Graphics.DrawString("Seller: " +ViewOedersGv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 205));  
            e.Graphics.DrawString("Amount: " +ViewOedersGv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 15, FontStyle.Regular), Brushes.Black, new Point(120, 240));
            e.Graphics.DrawString("===== Welcome =====", new Font("Abeezee", 25, FontStyle.Bold), Brushes.Red, new Point(208, 340));
        }
    }
}
