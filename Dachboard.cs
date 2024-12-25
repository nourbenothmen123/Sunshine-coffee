using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetCoffee1
{
    public partial class Dachboard : Form
    {
        

        public Dachboard()
        {
            InitializeComponent();
        }
        
       

        private void Dachboard_Load(object sender, EventArgs e)
        {

        
        /*
        public Dachboard(string user)
        {
            InitializeComponent();
            if(user=="Guest")
            {
                BtnMngItems.Hide();
                BtnMngUsers.Hide(); 

            }
            else if(user=="Admin")
            {
                BtnMngItems.Show();
                BtnMngUsers.Show();

            }
        */

        }
        
        private void BtnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();

        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            //show form in panel
            PlaceOrder pl = new PlaceOrder();
            pl.TopLevel = false;
            PnlContent.Controls.Add(pl);
            pl.BringToFront();
            pl.Show();
          
        }
  

        private void BtnMngUsers_Click(object sender, EventArgs e)
        {
            //show form in panel
            ManageUsers Mu = new ManageUsers();
            Mu.TopLevel = false;
            PnlContent.Controls.Add(Mu);
            Mu.BringToFront();
            Mu.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMngItems_Click(object sender, EventArgs e)
        {
            //show form in panel
            ManageItems Mi = new ManageItems();
            Mi.TopLevel = false;
            PnlContent.Controls.Add(Mi);
            Mi.BringToFront();
            Mi.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
