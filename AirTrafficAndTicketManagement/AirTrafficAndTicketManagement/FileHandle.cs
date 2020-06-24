using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AirTrafficAndTicketManagement
{
    public class FileHandle
    {
        public List<string> seatList = new List<string>();
        int ticketNumber = 0;
        public bool seatCheck(string flightName)
        {
            //Console.WriteLine(startupPath);


            try
            {
                //string path = @"..\" + flightName + ".txt";
                if (!File.Exists(@"..\" + flightName + ".txt"))
                {
                    File.Create(@"..\" + flightName + ".txt");
                    /*StreamWriter sw = new StreamWriter(@"..\" + flightName + ".txt");
                    sw.WriteLine("");
                    sw.Close();*/

                }
                using (StreamReader sr = new StreamReader(@"..\" + flightName + ".txt"))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        seatList.Add(line);
                    }
                    sr.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;

            }

        }
        public void seatFill(string flightName, List<string> seat)
        {
            string path = @"..\" + flightName + ".txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                // File.Close

            }
            using (StreamWriter sw = new StreamWriter(@"..\" + flightName + ".txt", true))
            {
                for (int i = 0; i < seat.Count; i++)
                {
                    sw.WriteLine(seat[i]);
                }
                sw.Close();
            }

        }
        public void storeInfo(string name, string CO, string flight, string passport, string sfrom, string sto, string date, string picture, string cabin, int adult, int children, int infants)
        {
            try
            {

                using (StreamReader sr = new StreamReader(@"..\" + "ticketNumber.dat"))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ticketNumber = Int32.Parse(line);
                    }
                    sr.Close();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
            }
            ticketNumber++;
            using (StreamWriter sw = new StreamWriter(@"..\" + "ticketNumber.dat"))
            {

                sw.WriteLine(ticketNumber);
                sw.Close();
            }
            string destinationPath = @"..\photos\";
            File.Copy(@picture, destinationPath + ticketNumber + ".JPG");
            
            using (StreamWriter sw = new StreamWriter(@"..\" + "temp.txt", true))
            {

                sw.WriteLine(name);
                sw.WriteLine(CO);
                sw.WriteLine(flight);
                sw.WriteLine(passport);
                sw.WriteLine(sfrom);
                sw.WriteLine(sto);
                sw.WriteLine(date);
                sw.WriteLine(destinationPath + ticketNumber + ".JPG");
                sw.WriteLine(cabin);
                sw.WriteLine(adult);
                sw.WriteLine(children);
                sw.WriteLine(infants);
                sw.Close();
            }

        }
        public void storeInfo(string seat, int totalCost, string flightName)
        {
            try
            {

                using (StreamReader sr = new StreamReader(@"..\" + "ticketNumber.dat"))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ticketNumber = Int32.Parse(line);
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {

            }
            ticketNumber++;
            using (StreamWriter sw = new StreamWriter(@"..\" + "temp.txt", true))
            {

                sw.WriteLine(seat);
                sw.WriteLine(totalCost);
                sw.WriteLine(flightName);
                sw.WriteLine(ticketNumber);
                sw.Close();
            }
            using (StreamWriter sw = new StreamWriter(@"..\" + "ticketNumber.dat"))
            {

                sw.WriteLine(ticketNumber);
                sw.Close();
            }

        }
    }
}
