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
    public partial class FlightControl : Form
    {
        /*SqlCommandBuilder scb;
        SqlDataAdapter sda;
        DataTable dt;*/
        public FlightControl()
        {
            InitializeComponent();
        }

        private void FlightControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTC_and_TicketDataSet.ATCFlightList' table. You can move, or remove it, as needed.
            this.aTCFlightListTableAdapter.Fill(this.aTC_and_TicketDataSet.ATCFlightList);

        }

        private void aTCFlightListBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.aTCFlightListTableAdapter.Update(this.aTC_and_TicketDataSet);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                aTCFlightListBindingSource.EndEdit();
                aTCFlightListTableAdapter.Update(this.aTC_and_TicketDataSet);
                MessageBox.Show("Successfully Saved");
            }
            catch
            {
                MessageBox.Show("Unsuccessfull Attempt");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-NTSPRDK\\SQLEXPRESS;Initial Catalog=ATC and Ticket;Integrated Security=True";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                object cell = row.Cells["cell_del"].Value;
                if (cell == "Yes")
                {
                    if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        try
                        {
                            conn.Open();
                            //Console.WriteLine(row.Cells[1].Value.ToString());
                            if (File.Exists(@"..\" + row.Cells[1].Value.ToString() + ".txt"))
                            {
                                
                                File.Delete(@"..\" + row.Cells[1].Value.ToString() + ".txt");

                            }
                            SqlCommand cmd = new SqlCommand("Delete from ATCFlightList where [Flight Name]= @Flight_Name",conn);//if any space in database column then use [column name]
                            cmd.Parameters.AddWithValue("@Flight_Name", row.Cells[1].Value.ToString());

                            cmd.ExecuteNonQuery();
                            conn.Close();
                            this.aTCFlightListTableAdapter.Fill(this.aTC_and_TicketDataSet.ATCFlightList);//Update grid after delete
                           
                        }
                        catch (Exception ex)
                        {
                            conn.Close();
                            Console.WriteLine(ex);
                        }

                    }

                }

            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            OptionMenu obj = new OptionMenu();
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }
    }
}
