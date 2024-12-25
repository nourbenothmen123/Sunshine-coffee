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
    public partial class ManageItems : Form
    {
        public ManageItems()
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

        private void ManageItems_Load(object sender, EventArgs e)
        {
            populate();

        }
        int ind;

        private void ItemsGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = ItemsGv.CurrentRow.Index; //prend l'indice du ligne selectionné
            TxtItemNum.Text = ItemsGv[0, ind].Value.ToString();
            TxtItemName.Text = ItemsGv[1,ind].Value.ToString();
            Cbcat.SelectedItem = ItemsGv[2,ind].Value.ToString();
            TxtItemPrice.Text = ItemsGv[3,ind].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtItemName.Text == "" || TxtItemNum.Text == "" || TxtItemPrice.Text == "")
            {
                MessageBox.Show("fill all the Data");
            }
            else
            {
                Con.Open();
                String query="insert into ItemsTb values(" + TxtItemNum.Text + ",'" + TxtItemName.Text + "','" + Cbcat.SelectedItem.ToString() + "'," + TxtItemPrice.Text +")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Created");
                Con.Close();
                populate();
               
            }
        
                    
                    
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtItemNum.Text=="")
            {
                MessageBox.Show("Select the item to be deleted");
            }
            else 
            {
                Con.Open();
                string query="delete from ItemsTb where ItemNum='" + TxtItemNum.Text + "'";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" item successfully deleted ");
                Con.Close();
                populate();
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(TxtItemNum.Text=="" || TxtItemName.Text=="" || TxtItemPrice.Text=="")
            {
                MessageBox.Show("fill all the fields");
            }
            else
            {
                Con.Open();
                string query = "update ItemsTb set ItemName='" + TxtItemName.Text + "',ItemCat='" + Cbcat.SelectedItem.ToString() +"',ItemPrice="+ TxtItemPrice.Text +" where ItemNum="+ TxtItemNum.Text + " ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" item successfully Updated ");
                Con.Close();
                populate();//Refraîchir le datagridview
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtItemName.Clear();
            TxtItemNum.Clear();
            TxtItemPrice.Clear();
            Cbcat.Text = "Category";
        }
    }
}
