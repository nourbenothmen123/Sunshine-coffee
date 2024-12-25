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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bdSysMngtCoffee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           /* Dachboard ds = new Dachboard("Guest");
            this.Hide();
            ds.Show();
            */
        }
        public static string user;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            /*Dachboard ds = new Dachboard("Admin");
             this.Hide();
             ds.Show();
            */
            /*Dachboard ds=new Dachboard();
            this.Hide();
            ds.Show();*/
            user = TxtUsername.Text;
            if(TxtUsername.Text=="" || TxtPassword.Text=="")
            {
                MessageBox.Show("Enter a username or password");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Users where Uname='" + TxtUsername.Text + "'and Upassword='" + TxtPassword.Text + "'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    Dachboard ds=new Dachboard();
                    this.Hide();
                    ds.Show();
                }
                else
                {
                    MessageBox.Show(" Wrong Username or password ");
                }
                Con.Close();
            }
        }

        private void BtneyeShow_Click(object sender, EventArgs e)
        {
            if (TxtPassword.PasswordChar=='*')
            {
                BtneyeHide.BringToFront();
                TxtPassword.PasswordChar = '\0';
            }
        }

        private void BtneyeHide_Click(object sender, EventArgs e)
        {
            if (TxtPassword.PasswordChar == '\0')
            {
                BtneyeShow.BringToFront();
                TxtPassword.PasswordChar = '*';

            }

        }
    }
}
