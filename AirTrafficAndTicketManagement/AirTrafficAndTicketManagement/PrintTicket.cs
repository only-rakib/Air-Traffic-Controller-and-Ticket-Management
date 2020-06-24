using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AirTrafficAndTicketManagement
{
    public partial class PrintTicket : Form
    {
        public PrintTicket()
        {


            InitializeComponent();

            List<string> storeString = new List<string>();
            try
            {

                using (StreamReader sr = new StreamReader(@"..\" + "temp.txt"))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        storeString.Add(line);

                    }
                    textBox2.Text = storeString[0];
                    textBoxCO.Text = storeString[1];
                    textBoxFlight.Text = storeString[2];
                    textBoxPassport.Text = storeString[3];
                    textBoxFrom.Text = storeString[4];
                    textBoxTo.Text = storeString[5];
                    textBoxDate.Text = storeString[6];
                    textBoxpicture.Hide();
                    textBoxpicture.Text = storeString[7];
                    textBoxCabin.Text = storeString[8];
                    textBoxAdult.Text = storeString[9];
                    textBoxChildren.Text = storeString[10];
                    textBoxInfants.Text = storeString[11];
                    textBoxSeat.Text = storeString[12];
                    textBoxTotalCost.Text = storeString[13];
                    textBoxFlightName.Text = storeString[14];
                    textBoxTicketNumber.Text = storeString[15];
                    pictureBox2.Image = Image.FromFile(storeString[7]);


                    sr.Close();
                    if (File.Exists(@"..\" + "temp.txt"))
                    {
                        File.Delete(@"..\" + "temp.txt");
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }

        }

        private void PrintTicket_Load(object sender, EventArgs e)
        {
           
        }
        Bitmap memoryImage;
        

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
 
        private void Print_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            e.Graphics.DrawImage(memoryImage, 0, 0); 


        }

        private void Print_Click_1(object sender, EventArgs e)
        {
            CaptureScreen();
            //printDocument1.Print();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"..\" + "temp.txt"))
            {
                File.Delete(@"..\" + "temp.txt");
            }
            OptionMenu obj = new OptionMenu();
            this.Hide();
            obj.ShowDialog();
            this.Close();
        }
    }
}
