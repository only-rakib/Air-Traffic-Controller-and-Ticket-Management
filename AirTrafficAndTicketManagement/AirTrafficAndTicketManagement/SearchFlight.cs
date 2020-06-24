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
using System.IO;
namespace AirTrafficAndTicketManagement
{
    public partial class SearchFlight : Form
    {
        /*public SearchFlight()
        {
            InitializeComponent();


        }*/
        string seat = null;
        List<int> seatPerClick = new List<int>();
        List<showPlaneforFinalList> final = new List<showPlaneforFinalList>();
        List<OnlyStore> storeFlight = new List<OnlyStore>();
        //OnlyStore obj = new OnlyStore();
        public int costPerSeat = 0;
        string flightName = null;
        public int adult = 0;
        public int children = 0;
        public int infants = 0;
        public int totalTickets = 0;
        int clickTicket = 1;
        public string name, CO, flight, passport, sfrom, sto, date, cabin, flight1;

        OnlyStore[] obj = new OnlyStore[100];

        public SearchFlight(string start, string destination, string date, string cabin)
        {
            InitializeComponent();
            for (int k = 0; k < 100; k++)
            {
                seatPerClick.Add(0);
                obj[k] = new OnlyStore();

            }

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=DESKTOP-NTSPRDK\\SQLEXPRESS;Initial Catalog=ATC and Ticket;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM ATCFlightList", conn);
                SqlDataReader reader = command.ExecuteReader();
                int ses = 0;
                while (reader.Read())
                {
                    obj[ses].flightname = reader["Flight Name"].ToString();
                    obj[ses].from = reader["From"].ToString().Substring(0, start.Length);
                    obj[ses].to = reader["To"].ToString().Substring(0, destination.Length);
                    obj[ses].araivalDate = reader["Date"].ToString().Substring(0, date.Length);
                    obj[ses].departureTime = reader["Departure Time"].ToString();
                    obj[ses].araivalTime = reader["Araival Time"].ToString();
                    obj[ses].araivalDate = reader["Araival Date"].ToString();
                    obj[ses].availableseatForFirstClass = reader["AvailableSeatForFirstClass"].ToString();
                    obj[ses].availableseatForBusinessClass = reader["AvailableSeatForBusinessClass"].ToString();
                    obj[ses].availableseatForEconomyClass = reader["AvailableSeatForEconomyClass"].ToString();
                    obj[ses].CostOfFirstClass = reader["Cost of First Class"].ToString();
                    obj[ses].CostOfBusinessClass = reader["Cost of Business Class"].ToString();
                    obj[ses].CostOfEconomyClass = reader["Cost of Economy Class"].ToString();

                    //storeFlight.Add(obj);
                    ses++;
                }
                conn.Close();
                int n = ses;
                List<int> indx = new List<int>();

                for (int j = 0; j < n; j++)
                {
                    if (obj[j].from == start && obj[j].to == destination && obj[j].araivalDate == date)
                    {

                        indx.Add(j);

                    }

                }

                showPlaneforFinalList[] FL = new showPlaneforFinalList[indx.Count];
                for (int suru = 0; suru < indx.Count; suru++)
                {
                    FL[suru] = new showPlaneforFinalList();
                }
                for (int i = 0; i < indx.Count; i++)
                {

                    FL[i].Flight_Name = obj[indx[i]].flightname;
                    FL[i].Araival_Time = obj[indx[i]].araivalTime;
                    //flightName = FL.Flight_Name;
                    if (cabin == "First Class")
                    {
                        FL[i].Available_Seat = obj[indx[i]].availableseatForFirstClass;
                        FL[i].Cost = obj[indx[i]].CostOfFirstClass;

                    }
                    else if (cabin == "Business Class")
                    {
                        FL[i].Available_Seat = obj[indx[i]].availableseatForBusinessClass;
                        FL[i].Cost = obj[indx[i]].CostOfBusinessClass;

                    }
                    else
                    {
                        FL[i].Available_Seat = obj[indx[i]].availableseatForEconomyClass;
                        FL[i].Cost = obj[indx[i]].CostOfEconomyClass;

                    }
                }
                //dataGridView1.DataSource = final;
                //dataGridView1.Rows.Add(obj[0]);
                dataGridView1.DataSource = FL;

            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Database Connection Error");

            }
        }

        List<string> seatNumber = new List<string>();
        private void buttonA3_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[0] == 0)
                {
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonA3.Text);
                    seatNumber.Add(buttonA3.Text);
                    clickTicket++;
                    buttonA3.BackColor = Color.Green;
                    seatPerClick[0] = 1;
                    seat += " " + buttonA3.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonA4_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[1] == 0)
                {
                    seatNumber.Add(buttonA4.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonA4.Text);
                    clickTicket++;
                    buttonA4.BackColor = Color.Green;
                    seatPerClick[1] = 1;
                    seat += " " + buttonA4.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonA5_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[2] == 0)
                {
                    seatNumber.Add(buttonA5.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonA5.Text);
                    clickTicket++;
                    seatPerClick[2] = 1;
                    buttonA5.BackColor = Color.Green;
                    seat += " " + buttonA5.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonA6_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[3] == 0)
                {
                    seatNumber.Add(buttonA6.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonA6.Text);
                    clickTicket++;
                    seatPerClick[3] = 1;
                    buttonA6.BackColor = Color.Green;
                    seat += " " + buttonA6.Text;

                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[4] == 0)
                {
                    seatNumber.Add(buttonB3.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonB3.Text);
                    clickTicket++;
                    seatPerClick[4] = 1;
                    buttonB3.BackColor = Color.Green;
                    seat += " " + buttonB3.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonB4_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[5] == 0)
                {
                    seatNumber.Add(buttonB4.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonB4.Text);
                    clickTicket++;
                    seatPerClick[5] = 1;
                    buttonB4.BackColor = Color.Green;
                    seat += " " + buttonB4.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonB5_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[6] == 0)
                {
                    seatNumber.Add(buttonB5.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonB5.Text);
                    clickTicket++;
                    seatPerClick[6] = 1;
                    buttonB5.BackColor = Color.Green;
                    seat += " " + buttonB5.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonB6_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[7] == 0)
                {
                    seatNumber.Add(buttonB6.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonB6.Text);
                    clickTicket++;
                    seatPerClick[7] = 1;
                    buttonB6.BackColor = Color.Green;
                    seat += " " + buttonB6.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonB7_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[8] == 0)
                {
                    seatNumber.Add(buttonB7.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonB7.Text);
                    clickTicket++;
                    seatPerClick[8] = 1;
                    buttonB7.BackColor = Color.Green;
                    seat += " " + buttonB7.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonA7_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[9] == 0)
                {
                    seatNumber.Add(buttonA7.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonA7.Text);
                    clickTicket++;
                    seatPerClick[9] = 1;
                    buttonA7.BackColor = Color.Green;
                    seat += " " + buttonA7.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[10] == 0)
                {
                    seatNumber.Add(buttonC1.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonC1.Text);
                    clickTicket++;
                    seatPerClick[10] = 1;
                    buttonC1.BackColor = Color.Green;
                    seat += " " + buttonC1.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[11] == 0)
                {
                    seatNumber.Add(buttonC2.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonC2.Text);
                    clickTicket++;
                    seatPerClick[11] = 1;
                    buttonC2.BackColor = Color.Green;
                    seat += " " + buttonC2.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[12] == 0)
                {
                    seatNumber.Add(buttonC1.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonC3.Text);
                    clickTicket++;
                    seatPerClick[12] = 1;
                    buttonC3.BackColor = Color.Green;
                    seat += " " + buttonC3.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonC4_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[13] == 0)
                {
                    seatNumber.Add(buttonC4.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonC4.Text);
                    clickTicket++;
                    seatPerClick[13] = 1;
                    buttonC4.BackColor = Color.Green;
                    seat += " " + buttonC4.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonC5_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[14] == 0)
                {
                    seatNumber.Add(buttonC5.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonC5.Text);
                    clickTicket++;
                    seatPerClick[14] = 1;
                    buttonC5.BackColor = Color.Green;
                    seat += " " + buttonC5.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonC6_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[15] == 0)
                {
                    seatNumber.Add(buttonC6.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonC6.Text);
                    clickTicket++;
                    seatPerClick[15] = 1;
                    buttonC6.BackColor = Color.Green;
                    seat += " " + buttonC6.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonD1_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[16] == 0)
                {
                    seatNumber.Add(buttonD1.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonD1.Text);
                    clickTicket++;
                    seatPerClick[16] = 1;
                    buttonD1.BackColor = Color.Green;
                    seat += " " + buttonD1.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonD2_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[17] == 0)
                {
                    seatNumber.Add(buttonD2.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonD2.Text);
                    clickTicket++;
                    seatPerClick[17] = 1;
                    buttonD2.BackColor = Color.Green;
                    seat += " " + buttonD2.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonD3_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[18] == 0)
                {
                    seatNumber.Add(buttonD3.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonD3.Text);
                    clickTicket++;
                    seatPerClick[18] = 1;
                    buttonD3.BackColor = Color.Green;
                    seat += " " + buttonD3.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonD4_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[19] == 0)
                {
                    seatNumber.Add(buttonD4.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonD4.Text);
                    clickTicket++;
                    seatPerClick[19] = 1;
                    buttonD4.BackColor = Color.Green;
                    seat += " " + buttonD4.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonD5_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[20] == 0)
                {
                    seatNumber.Add(buttonD5.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonD5.Text);
                    clickTicket++;
                    seatPerClick[20] = 1;
                    buttonD5.BackColor = Color.Green;
                    seat += " " + buttonD5.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonD6_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[21] == 0)
                {
                    seatNumber.Add(buttonD6.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonD6.Text);
                    clickTicket++;
                    seatPerClick[21] = 1;
                    buttonD6.BackColor = Color.Green;
                    seat += " " + buttonD6.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonF1_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[22] == 0)
                {
                    seatNumber.Add(buttonF1.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonF1.Text);
                    clickTicket++;
                    seatPerClick[22] = 1;
                    buttonF1.BackColor = Color.Green;
                    seat += " " + buttonF1.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[23] == 0)
                {
                    seatNumber.Add(buttonF2.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonF2.Text);
                    clickTicket++;
                    seatPerClick[23] = 1;
                    buttonF2.BackColor = Color.Green;
                    seat += " " + buttonF2.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonF3_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[24] == 0)
                {
                    seatNumber.Add(buttonF3.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonF3.Text);
                    clickTicket++;
                    seatPerClick[24] = 1;
                    buttonF3.BackColor = Color.Green;
                    seat += " " + buttonF3.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonF4_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[25] == 0)
                {
                    seatNumber.Add(buttonF4.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonF4.Text);
                    clickTicket++;
                    seatPerClick[25] = 1;
                    buttonF4.BackColor = Color.Green;
                    seat += " " + buttonF4.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonF5_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[26] == 0)
                {
                    seatNumber.Add(buttonF5.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonF5.Text);
                    clickTicket++;
                    seatPerClick[26] = 1;
                    buttonF5.BackColor = Color.Green;
                    seat += " " + buttonF5.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonF6_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[27] == 0)
                {
                    seatNumber.Add(buttonF6.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonF6.Text);
                    clickTicket++;
                    seatPerClick[27] = 1;
                    buttonF6.BackColor = Color.Green;
                    seat += " " + buttonF6.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[28] == 0)
                {
                    seatNumber.Add(buttonE1.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonE1.Text);
                    clickTicket++;
                    seatPerClick[28] = 1;
                    buttonE1.BackColor = Color.Green;
                    seat += " " + buttonE1.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonE2_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[29] == 0)
                {
                    seatNumber.Add(buttonE2.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonE2.Text);
                    clickTicket++;
                    seatPerClick[29] = 1;
                    buttonE2.BackColor = Color.Green;
                    seat += " " + buttonE2.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonE3_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[30] == 0)
                {
                    seatNumber.Add(buttonE3.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonE3.Text);
                    clickTicket++;
                    seatPerClick[30] = 1;
                    buttonE3.BackColor = Color.Green;
                    seat += " " + buttonE3.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonE4_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[31] == 0)
                {
                    seatNumber.Add(buttonE4.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonE4.Text);
                    clickTicket++;
                    seatPerClick[31] = 1;
                    buttonE4.BackColor = Color.Green;
                    seat += " " + buttonE4.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonE5_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[32] == 0)
                {
                    seatNumber.Add(buttonE5.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonE5.Text);
                    clickTicket++;
                    seatPerClick[32] = 1;
                    buttonE5.BackColor = Color.Green;
                    seat += " " + buttonE5.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonE6_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[33] == 0)
                {
                    seatNumber.Add(buttonE6.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonE6.Text);
                    clickTicket++;
                    seatPerClick[33] = 1;
                    buttonE6.BackColor = Color.Green;
                    seat += " " + buttonE6.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void tableLayoutPanelBusiness_Paint(object sender, PaintEventArgs e)
        {
            /*FileHandle obj = new FileHandle();
            obj.seatFill(flightName, buttonA1.Text);*/
        }



        private void buttonB2_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[34] == 0)
                {
                    seatNumber.Add(buttonB2.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonB2.Text);
                    clickTicket++;
                    seatPerClick[34] = 1;
                    buttonB2.BackColor = Color.Green;
                    seat += " " + buttonB2.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[35] == 0)
                {
                    seatNumber.Add(buttonB1.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonB1.Text);
                    clickTicket++;
                    seatPerClick[35] = 1;
                    buttonB1.BackColor = Color.Green;
                    seat += " " + buttonB1.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"..\" + "temp.txt"))
            {
                File.Delete(@"..\" + "temp.txt");
            }
            TicketManagement objj = new TicketManagement();
            this.Hide();
            objj.ShowDialog();
            this.Close();
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[36] == 0)
                {
                    seatNumber.Add(buttonA2.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonA2.Text);
                    clickTicket++;
                    seatPerClick[36] = 1;
                    buttonA2.BackColor = Color.Green;
                    seat += " " + buttonA2.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            if (clickTicket <= totalTickets)
            {
                if (seatPerClick[37] == 0)
                {
                    seatNumber.Add(buttonA1.Text);
                    //FileHandle obj = new FileHandle();
                    //obj.seatFill(flightName, buttonA1.Text);
                    clickTicket++;
                    seatPerClick[37] = 1;
                    buttonA1.BackColor = Color.Green;
                    seat += " " + buttonA1.Text;
                }
                else
                {
                    MessageBox.Show("You hav already select the seat");
                }
            }
            else
            {
                MessageBox.Show("Already select all the seat");
            }
        }
        
        private void button1ViewSeat_Click(object sender, EventArgs e)
        {

            //DataGridViewRow row = this.dataGridView1.SelectedRows.;
            
            FileHandle obj = new FileHandle();
            bool status = obj.seatCheck(flightName);
            List<string> seatList = new List<string>();
            if (status == false)
            {
                MessageBox.Show("Error file Loading");
            }
            else
            {
                seatList.Clear();
                for (int k = 0; k < obj.seatList.Count; k++)
                {
                    seatList.Add(obj.seatList[k]);
                }
            }

            this.buttonPurchase.Show();
            
           
            if (cabin == "First Class")
            {
                for (int i = 0; i < seatList.Count; i++)
                {
                    if (buttonA1.Text == seatList[i])
                    {
                        buttonA1.BackColor = Color.Red;
                        seatPerClick[37] = 4;
                    }
                    else if (buttonA2.Text == seatList[i])
                    {
                        buttonA2.BackColor = Color.Red;
                        seatPerClick[36] = 4;
                    }
                    else if (buttonB1.Text == seatList[i])
                    {
                        buttonB1.BackColor = Color.Red;
                        seatPerClick[35] = 4;
                    }
                    else if (buttonB2.Text == seatList[i])
                    {
                        buttonB2.BackColor = Color.Red;
                        seatPerClick[34] = 4;
                    }
                }
                tableLayoutPanelFirstClass.Show();
            }
            else if (cabin == "Business Class")
            {
                for (int i = 0; i < seatList.Count; i++)
                {
                    if (buttonA3.Text == seatList[i])
                    {
                        buttonA3.BackColor = Color.Red;
                        seatPerClick[0] = 4;
                    }
                    else if (buttonA4.Text == seatList[i])
                    {
                        buttonA4.BackColor = Color.Red;
                        seatPerClick[1] = 4;
                    }
                    else if (buttonA5.Text == seatList[i])
                    {
                        buttonA5.BackColor = Color.Red;
                        seatPerClick[2] = 4;
                    }
                    else if (buttonA6.Text == seatList[i])
                    {
                        buttonA6.BackColor = Color.Red;
                        seatPerClick[3] = 4;
                    }
                    else if (buttonA7.Text == seatList[i])
                    {
                        buttonA7.BackColor = Color.Red;
                        seatPerClick[9] = 4;
                    }
                    else if (buttonB3.Text == seatList[i])
                    {
                        buttonB3.BackColor = Color.Red;
                        seatPerClick[4] = 4;
                    }
                    else if (buttonB4.Text == seatList[i])
                    {
                        buttonB4.BackColor = Color.Red;
                        seatPerClick[5] = 4;
                    }
                    else if (buttonB5.Text == seatList[i])
                    {
                        buttonB5.BackColor = Color.Red;
                        seatPerClick[6] = 4;
                    }
                    else if (buttonB6.Text == seatList[i])
                    {
                        buttonB6.BackColor = Color.Red;
                        seatPerClick[7] = 4;
                    }
                    else if (buttonB7.Text == seatList[i])
                    {
                        buttonB7.BackColor = Color.Red;
                        seatPerClick[8] = 4;
                    }
                }
                tableLayoutPanelBusiness.Show();
            }
            else
            {
                
                for (int i = 0; i < seatList.Count; i++)
                {
                    if (buttonC1.Text == seatList[i])
                    {
                        buttonC1.BackColor = Color.Red;
                        seatPerClick[10] = 4;
                    }
                    else if (buttonC2.Text == seatList[i])
                    {
                        buttonC2.BackColor = Color.Red;
                        seatPerClick[11] = 4;
                    }
                    else if (buttonC3.Text == seatList[i])
                    {
                        buttonC3.BackColor = Color.Red;
                        seatPerClick[12] = 4;
                    }
                    else if (buttonC4.Text == seatList[i])
                    {
                        buttonC4.BackColor = Color.Red;
                        seatPerClick[13] = 4;
                    }
                    else if (buttonC5.Text == seatList[i])
                    {
                        buttonC5.BackColor = Color.Red;
                        seatPerClick[14] = 4;
                    }
                    else if (buttonC6.Text == seatList[i])
                    {
                        buttonC6.BackColor = Color.Red;
                        seatPerClick[15] = 4;
                    }
                    else if (buttonD1.Text == seatList[i])
                    {
                        buttonD1.BackColor = Color.Red;
                        seatPerClick[16] = 4;
                    }
                    else if (buttonD2.Text == seatList[i])
                    {
                        buttonD2.BackColor = Color.Red;
                        seatPerClick[17] = 4;
                    }
                    else if (buttonD3.Text == seatList[i])
                    {
                        buttonD3.BackColor = Color.Red;
                        seatPerClick[18] = 4;
                    }
                    else if (buttonD4.Text == seatList[i])
                    {
                        buttonD4.BackColor = Color.Red;
                        seatPerClick[19] = 4;
                    }
                    else if (buttonD5.Text == seatList[i])
                    {
                        buttonD5.BackColor = Color.Red;
                        seatPerClick[20] = 4;
                    }
                    else if (buttonD6.Text == seatList[i])
                    {
                        buttonD6.BackColor = Color.Red;
                        seatPerClick[21] = 4;
                    }
                    else if (buttonE1.Text == seatList[i])
                    {
                        buttonE1.BackColor = Color.Red;
                        seatPerClick[28] = 4;
                    }
                    else if (buttonE2.Text == seatList[i])
                    {
                        buttonE2.BackColor = Color.Red;
                        seatPerClick[29] = 4;
                    }
                    else if (buttonE3.Text == seatList[i])
                    {
                        buttonE3.BackColor = Color.Red;
                        seatPerClick[30] = 4;
                    }
                    else if (buttonE4.Text == seatList[i])
                    {
                        buttonE4.BackColor = Color.Red;
                        seatPerClick[31] = 4;
                    }
                    else if (buttonE5.Text == seatList[i])
                    {
                        buttonE5.BackColor = Color.Red;
                        seatPerClick[32] = 4;
                    }
                    else if (buttonE6.Text == seatList[i])
                    {
                        buttonE6.BackColor = Color.Red;
                        seatPerClick[33] = 4;
                    }
                    else if (buttonF1.Text == seatList[i])
                    {
                        buttonF1.BackColor = Color.Red;
                        seatPerClick[22] = 4;
                    }
                    else if (buttonF2.Text == seatList[i])
                    {
                        buttonF2.BackColor = Color.Red;
                        seatPerClick[23] = 4;
                    }
                    else if (buttonF3.Text == seatList[i])
                    {
                        buttonF3.BackColor = Color.Red;
                        seatPerClick[24] = 4;
                    }
                    else if (buttonF4.Text == seatList[i])
                    {
                        buttonF4.BackColor = Color.Red;
                        seatPerClick[25] = 4;
                    }
                    else if (buttonF5.Text == seatList[i])
                    {
                        buttonF5.BackColor = Color.Red;
                        seatPerClick[26] = 4;
                    }
                    else if (buttonF6.Text == seatList[i])
                    {
                        buttonF6.BackColor = Color.Red;
                        seatPerClick[27] = 4;
                    }
                }
                tableLayoutPanelEconomyClass.Show();
            }
        }
        int totalCost = 0;
        int totalseat = 0;
        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            if (clickTicket < totalTickets)
            {
                MessageBox.Show("Select remain seat");
            }
            else
            {
                FileHandle obj1 = new FileHandle();
                obj1.seatFill(flightName, seatNumber);
                obj1.storeInfo(seat, totalCost, flightName);
                DataBase DB = new DataBase();
                if (flightName != null)
                {
                    DB.update(flightName, totalseat - totalTickets, cabin);
                    DB.ticketManegment();
                    PrintTicket print = new PrintTicket();
                    this.Hide();
                    print.ShowDialog();
                    this.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            flightName = row.Cells["Flight_Name"].Value.ToString();
            textBox2.Text = flightName;
            costPerSeat = Int32.Parse(row.Cells["Cost"].Value.ToString());
            totalCost = (costPerSeat * adult) + (children * (costPerSeat - (costPerSeat * (25 / 100)))) + (infants * (costPerSeat - (costPerSeat * (50 / 100))));
            textBoxTotalCost.Text = totalCost.ToString();
            totalseat = Convert.ToInt32(row.Cells["Available_Seat"].Value.ToString());
            if (totalseat < totalTickets)
            {
                button1ViewSeat.Hide();
                textBoxUnavailable.Show();
            }
            else
            {
                textBoxUnavailable.Hide();
                button1ViewSeat.Show();
            }
            
        }


    }


}


