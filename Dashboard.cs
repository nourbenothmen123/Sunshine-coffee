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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        public Dashboard(string user)
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
        }
    }
}
