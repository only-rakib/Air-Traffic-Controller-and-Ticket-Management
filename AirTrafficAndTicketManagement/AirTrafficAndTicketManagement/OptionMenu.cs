using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTrafficAndTicketManagement
{
    public partial class OptionMenu : Form
    {
        public OptionMenu()
        {
            InitializeComponent();
        }

        private void OptionMenu_Load(object sender, EventArgs e)
        {

        }
        public int take { get; set; } 
        private void buttonATC_Click(object sender, EventArgs e)
        {
            LoginBox login = new LoginBox();
            login.take = 2;
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            LoginBox login = new LoginBox();
            login.take = 1;
            this.Hide();
            login.ShowDialog();
            this.Close();

        }
    }
}
