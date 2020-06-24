using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AirTrafficAndTicketManagement
{
    public partial class TicketManagement : Form
    {
        string sourcePath=null;
        Image file;
        public TicketManagement()
        {
            InitializeComponent();
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void TicketManagement_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(comboBoxChoose.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxChoose.Text);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            
            if (f.ShowDialog() == DialogResult.OK)
            {
                
                file = Image.FromFile(f.FileName);
                pictureBox1.Image = file;
                sourcePath = f.FileName;
            }
            

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //DataBase Db = new DataBase();
            
            bool flag = false;
            if(textBoxName.Text =="" || textBoxCO.Text =="")
            {
                MessageBox.Show("Name or CareOf is empty");
                flag = true;
            }

            if (comboBoxFrom.Text == comboBoxTo.Text )
            {
                MessageBox.Show("Arriaval and Destination is same");
                flag = true;
            }
            else if(comboBoxFrom.Text == "" || comboBoxTo.Text =="")
            {
                MessageBox.Show("Select Arriaval and Destination");
                flag = true;
            }
            int adult = 0;
            int children = 0;
            int infants = 0;
            if(sourcePath == null)
            {
                MessageBox.Show("Picture is empty");
                flag = true;
            }
            if (comboBoxAdult.Text == "" || comboBoxChildren.Text == "" || comboBoxInfants.Text == "")
            {
                MessageBox.Show("Select The Number of Tickets");
                flag = true;
            }

            else if (comboBoxAdult.Text == "More" && comboBoxChildren.Text != "More" && comboBoxInfants.Text != "More")
            {
                try
                {
                    adult = Int32.Parse(textBoxAdult.Text);
                    children = Int32.Parse(comboBoxChildren.Text);
                    infants =Int32.Parse(comboBoxInfants.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Number Format");
                    flag = true;
                }
            }
            else if (comboBoxAdult.Text == "More" && comboBoxChildren.Text == "More" && comboBoxInfants.Text != "More")
            {
                try
                {
                    adult = Int32.Parse(textBoxAdult.Text);
                    children = Int32.Parse(textBoxChildren.Text);
                    infants=Int32.Parse(comboBoxInfants.Text);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Number Format");
                    flag = true;
                }

            }
            else if (comboBoxAdult.Text == "More" && comboBoxChildren.Text == "More" && comboBoxInfants.Text == "More")
            {
                try
                {
                    adult = Int32.Parse(textBoxAdult.Text);
                    children = Int32.Parse(textBoxChildren.Text);
                    infants=Int32.Parse(textBoxInfants.Text);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Number Format");
                    flag = true;
                }
            }
            else if (comboBoxAdult.Text == "More" && comboBoxChildren.Text != "More" && comboBoxInfants.Text == "More")
            {
                try
                {
                    adult = Int32.Parse(textBoxAdult.Text);
                    children = Int32.Parse(comboBoxChildren.Text);
                    infants = Int32.Parse(textBoxInfants.Text);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Number Format");
                    flag = true;
                }
            }
            else if (comboBoxAdult.Text != "More" && comboBoxChildren.Text == "More" && comboBoxInfants.Text == "More")
            {
                try
                {
                    adult = Int32.Parse(comboBoxAdult.Text);
                    children = Int32.Parse(textBoxChildren.Text);
                    infants=Int32.Parse(textBoxInfants.Text);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Number Format");
                    flag = true;
                }
            }
            else if (comboBoxAdult.Text != "More" && comboBoxChildren.Text != "More" && comboBoxInfants.Text == "More")
            {
                try
                {
                    adult = Int32.Parse(comboBoxAdult.Text);
                    children = Int32.Parse(comboBoxChildren.Text);
                    infants= Int32.Parse(textBoxInfants.Text);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Number Format");
                    flag = true;
                }
            }
            else if (comboBoxAdult.Text != "More" && comboBoxChildren.Text == "More" && comboBoxInfants.Text != "More")
            {
                try
                {
                    adult = Int32.Parse(comboBoxAdult.Text);
                    children = Int32.Parse(textBoxChildren.Text);
                    infants=Int32.Parse(comboBoxInfants.Text);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Number Format");
                    flag = true;
                }
            }

            else
            {

                try {
                    adult = Int32.Parse(comboBoxAdult.Text);
                    children = Int32.Parse(comboBoxChildren.Text);
                    infants=Int32.Parse(comboBoxInfants.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Number Format");
                    flag = true;
                }

            }
            if(flag==false)
            {
                if(comboBoxChoose.Text == "International")
                {
                    if(textBoxPassport.Text == "")
                    {
                        MessageBox.Show("Passport is empty");
                    }
                    else
                    {
                        SearchFlight flight = new SearchFlight(comboBoxFrom.Text, comboBoxTo.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBoxSelectCabin.Text);
                        flight.totalTickets = adult + children + infants;
                        flight.adult = adult;
                        flight.children = children;
                        flight.infants = infants;
                        flight.Name = textBoxName.Text;
                        flight.CO = textBoxCO.Text;

                        flight.passport = textBoxPassport.Text;
                        flight.flight1 = comboBoxChoose.Text;
                        flight.sfrom = comboBoxFrom.Text;
                        flight.sto = comboBoxTo.Text;
                        flight.date = dateTimePicker1.Text;
                        flight.cabin = comboBoxSelectCabin.Text;
                        FileHandle obj1 = new FileHandle();
                        obj1.storeInfo(textBoxName.Text,textBoxCO.Text, comboBoxChoose.Text, textBoxPassport.Text, comboBoxFrom.Text, comboBoxTo.Text, dateTimePicker1.Text, sourcePath, comboBoxSelectCabin.Text,adult,children,infants);
                        this.Hide();
                        flight.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    SearchFlight flight = new SearchFlight(comboBoxFrom.Text, comboBoxTo.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBoxSelectCabin.Text);
                    flight.totalTickets = adult + children + infants;
                    flight.adult = adult;
                    flight.children = children;
                    flight.infants = infants;
                    flight.Name = textBoxName.Text;
                    flight.CO = textBoxCO.Text;

                    flight.passport = textBoxPassport.Text;
                    flight.flight1 = comboBoxChoose.Text;
                    flight.sfrom = comboBoxFrom.Text;
                    flight.sto = comboBoxTo.Text;
                    flight.date = dateTimePicker1.Text;
                    flight.cabin = comboBoxSelectCabin.Text;
                   
                    FileHandle obj1 = new FileHandle();
                    obj1.storeInfo(textBoxName.Text, textBoxCO.Text, comboBoxChoose.Text,"N/A", comboBoxFrom.Text, comboBoxTo.Text, dateTimePicker1.Text,sourcePath, comboBoxSelectCabin.Text, adult, children, infants);

                    this.Hide();
                    flight.ShowDialog();
                    this.Close();
                }
                
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
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

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoose.Text == "Domestic")
            {
                textBoxPassport.Hide();
                labelPassport.Hide();
                comboBoxFrom.Items.Clear();
                comboBoxTo.Items.Clear();
                comboBoxFrom.Items.AddRange(new string[] { "Dhaka", "Chittagong", "Sylhet", "Bagerhat", "Barishal", "Cox's Bazar", "Ishwardi ", "Jessore", "Rajshahi", "Saidpur" });
                comboBoxTo.Items.AddRange(new string[] { "Dhaka", "Chittagong", "Sylhet", "Bagerhat", "Barishal", "Cox's Bazar", "Ishwardi ", "Jessore", "Rajshahi", "Saidpur" });
            }
            else if (comboBoxChoose.Text == "International")
            {
                comboBoxFrom.Items.Clear();
                comboBoxTo.Items.Clear();
                comboBoxFrom.Items.AddRange(new string[] { "Afganistan", "Bangladesh", "Barmuda", "Canada", "India", "Pakistan", "Malayshia", "Srilanka", "UAE", "USA" });
                comboBoxTo.Items.AddRange(new string[] { "Afganistan", "Bangladesh", "Barmuda", "Canada", "India", "Pakistan", "Malayshia", "Srilanka", "UAE", "USA" });
                textBoxPassport.Show();
                labelPassport.Show();

                //Connect Combobox with Database
            }
            else
            {
                MessageBox.Show("Choose valid option");

            }

        }
        bool ok1,ok2,ok3 = false;
        private void comboBoxAdult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAdult.Text == "More")
            {
                label7.Show();
                textBoxAdult.Show();
                ok1 = true;
            }
            else
            {
                ok1 = false;
                if (ok1 == false && ok2 == false && ok3 == false)
                {
                    label7.Hide();
                }
                textBoxAdult.Hide();
            }
        }

        private void comboBoxSelectCabin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectCabin.Text == "")
            {
                MessageBox.Show("Select Cabin");
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(10);
        }

        private void comboBoxChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChildren.Text == "More")
            {
                ok2 = true;
                label7.Show();
                textBoxChildren.Show();
            }
            else
            {
                ok2 = false;
                if (ok1 == false && ok2 == false && ok3 == false)
                {
                    label7.Hide();
                }
                textBoxChildren.Hide();
            }
        }

        private void comboBoxInfants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInfants.Text == "More")
            {
                ok3 = true;
                label7.Show();
                textBoxInfants.Show();
            }
            else
            {
                ok3 = false;
                if (ok1==false && ok2==false && ok3==false)
                {
                    label7.Hide();
                }
                textBoxInfants.Hide();
                
            }
        }
    }
}
