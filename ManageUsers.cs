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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bdSysMngtCoffee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        void populate()
        {
            Con.Open();
            string query = "select * from Users";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGv.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtPhone.Text == "" || TxtPassword.Text=="")
            {
                MessageBox.Show("fill all the Data");
            }
            else
            {
                Con.Open();
                String query = "insert into Users values('" + TxtName.Text + "','" + TxtPhone.Text + "','" + TxtPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" User successfully created ");
                Con.Close();
                populate();
            }
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtPhone.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("fill all the fields");
            }
            else
            {
                Con.Open();
                string query = "update Users set Uname='"+TxtName.Text+"',Upassword='"+TxtPassword.Text+"' where Uphone='"+TxtPhone.Text+"'  ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" item successfully Updated ");
                Con.Close();
                populate();//Refraîchir le datagridview
            }
        }
        int ind;

        private void UsersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = UsersGv.CurrentRow.Index; //prend l'indice du ligne selectionné
            
            TxtName.Text = UsersGv[0, ind].Value.ToString();
            TxtPhone.Text = UsersGv[1, ind].Value.ToString();
            TxtPassword.Text = UsersGv[2, ind].Value.ToString();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            Con.Open();
            String query = "delete from Users where Uphone='"+ TxtPhone.Text +"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully deleted");
            Con.Close();
            populate();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtPassword.Clear();
            TxtName.Clear();
            TxtPhone.Clear();
        }
    }
}
