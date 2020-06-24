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
    public partial class LoginBox : Form
    {
        public LoginBox()
        {
            InitializeComponent();
        }
        public int take {
            get; set;
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            if(DB.connectionTest())
            {
                OptionMenu Op = new OptionMenu();
                if (take == 1)
                {
                    if (DB.loginTest(textBoxUserName.Text, textBoxPassword.Text))
                    {
                        TicketManagement obj = new TicketManagement();  
                        this.Hide();
                        obj.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Op.take = 0;
                        MessageBox.Show("Wrong User Name or Password");
                    }
                }
                if(take==2)
                {
                    if (DB.ATCloginTest(textBoxUserName.Text, textBoxPassword.Text))
                    {
                        FlightControl obj = new FlightControl();
                        this.Hide();
                        obj.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Op.take = 0;
                        MessageBox.Show("Wrong User Name or Password");
                    }
                }
            
            }
            else
            {
                MessageBox.Show("Database Connection Error");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserName.Clear();
            textBoxPassword.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            OptionMenu Op = new OptionMenu();
            this.Hide();
            Op.ShowDialog();
            this.Close();
        }
    }
}
