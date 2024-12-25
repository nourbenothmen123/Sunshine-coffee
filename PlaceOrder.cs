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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bdSysMngtCoffee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        void populate()
        {
            Con.Open();
            string query = "select * from ItemsTb";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGv.DataSource = ds.Tables[0];
            Con.Close();
        }
        void FilterByCategory()
        {
            Con.Open();
            string query = "select * from ItemsTb where Itemcat='"+ CmbCat.SelectedItem.ToString() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGv.DataSource = ds.Tables[0];
            Con.Close();
        }
        int num = 0;
        int price, total;
        string item, cat;

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (TxtQuantity.Text == "")
            {
                MessageBox.Show("What is the Quantity of item");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product to be ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(TxtQuantity.Text);
                //toutefois flag==1 il ajoute une ligne
                table.Rows.Add(num, item, cat, price, total);
                OrdersGv.DataSource = table;
                flag = 0;
            }
            sum = sum + total;
            TxtAmount.Text = sum +"";

        }
        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;
        int Amount;
        private void OrdersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Amount = int.Parse(OrdersGv.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch { }

        }
        ///int ind;

        private void ItemsGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ind = ItemsGv.CurrentRow.Index;
            flag = 1;
            item = ItemsGv.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGv.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGv.SelectedRows[0].Cells[3].Value.ToString()) ;

        }

        private void CmbCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void BtnPlaceTheOrder_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into Orders values(" + TxtOrderNum.Text +",'"+ Datelbl.Text +"','"+ TxtSellerName.Text +"',"+ TxtAmount.Text +")";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("order successfully created");
            Con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrdersForm VF = new ViewOrdersForm();
            VF.Show();
           
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersGv.Rows.RemoveAt(this.OrdersGv.SelectedRows[0].Index);
            }
            catch { }
            total -= Amount;
            TxtAmount.Text = "" + total;
           
        }





        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            /* Dachboard ds1 = new Dachboard("Guest");
             Dachboard ds2 = new Dachboard("Admin");
             if ("Guest")
             {
                 BtnRemove.Visible = false;
                 BtnViewOrders.Visible = false;
             }
             else
             {
                 BtnRemove.Visible = true;
                 BtnViewOrders.Visible = true;
             }*/
            /*if (TxtSellerName.Text == "Guest")
            {
                BtnRemove.Visible = false;
                BtnViewOrders.Visible = false;
            }
            else 
            {
                BtnRemove.Visible = true;
                BtnViewOrders.Visible = true;
            }*/

            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGv.DataSource = table;
            Datelbl.Text = DateTime.Today.Day.ToString()+"/"+DateTime.Today.Month.ToString()+"/"+DateTime.Today.Year.ToString();
            TxtSellerName.Text = Form1.user;


        }
    }
}
