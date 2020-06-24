using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
namespace AirTrafficAndTicketManagement
{
    class DataBase
    {
        public static SqlConnection conn = new SqlConnection();

        public bool connectionTest()
        {

            try
            {
                conn.ConnectionString = "Data Source=DESKTOP-NTSPRDK\\SQLEXPRESS;Initial Catalog=ATC and Ticket;Integrated Security=True";
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool loginTest(string uName, string uPass)
        {
            conn.ConnectionString = "Data Source=DESKTOP-NTSPRDK\\SQLEXPRESS;Initial Catalog=ATC and Ticket;Integrated Security=True";
            string s = null, s1 = null;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT user_name,password FROM userlogin", conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["user_name"].ToString();
                    s1 = reader["password"].ToString();

                }

                s = s.Substring(0, uName.Length);
                s1 = s1.Substring(0, uPass.Length);
                if (uName == s && uPass == s1)
                {

                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }


            }
            catch (Exception)
            {
                conn.Close();
                return false;

            }

        }
        public bool ATCloginTest(string uName, string uPass)
        {
            conn.ConnectionString = "Data Source=DESKTOP-NTSPRDK\\SQLEXPRESS;Initial Catalog=ATC and Ticket;Integrated Security=True";
            string s = null, s1 = null;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT user_name,password FROM ATClogin", conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    s = reader["user_name"].ToString();
                    s1 = reader["password"].ToString();

                }

                s = s.Substring(0, uName.Length);
                s1 = s1.Substring(0, uPass.Length);
                if (uName == s && uPass == s1)
                {

                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }


            }
            catch (Exception)
            {
                conn.Close();
                return false;

            }

        }
        public void ticketManegment()
        {
            string name = null, CO = null, flight = null, passport = null, sfrom = null, sto = null, date = null, picture = null, cabin = null, adult = null, children = null, infants = null, seat = null, totalCost = null, flightName = null, ticketNumber = null;
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
                    name = storeString[0];
                    CO = storeString[1];
                    flight = storeString[2];
                    passport = storeString[3];
                    sfrom = storeString[4];
                    sto = storeString[5];
                    date = storeString[6];
                    picture = storeString[7];
                    cabin = storeString[8];
                    adult = storeString[9];
                    children = storeString[10];
                    infants = storeString[11];
                    seat = storeString[12];
                    totalCost = storeString[13];
                    flightName = storeString[14];
                    ticketNumber = storeString[15];
                    sr.Close();

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }
            /*if (File.Exists(@"..\" + "temp.txt"))
            {
                File.Delete(@"..\" + "temp.txt");
            }*/
            try
            {
                conn.ConnectionString = "Data Source=DESKTOP-NTSPRDK\\SQLEXPRESS;Initial Catalog=ATC and Ticket;Integrated Security=True";
                SqlCommand command = new SqlCommand("insert into TicketInfo (sname,careof,flight,passportNo,sfrom,sto,sdate,picture,cabin,adult,children,infants,seat,totalCost,flightName,ticketNumber) Values (@sname,@careof,@flight,@passportNo,@sfrom,@sto,@sdate,@picture,@cabin,@adult,@children,@infants,@seat,@totalCost,@flightName,@ticketNumber)", conn);
                command.Parameters.AddWithValue("@sname", name);
                command.Parameters.AddWithValue("@careof", CO);
                command.Parameters.AddWithValue("@flight", flight);
                command.Parameters.AddWithValue("@passportNo", passport);
                command.Parameters.AddWithValue("@sfrom", sfrom);
                command.Parameters.AddWithValue("@sto", sto);
                command.Parameters.AddWithValue("@sdate", date);
                command.Parameters.AddWithValue("@picture", picture);
                command.Parameters.AddWithValue("@cabin", cabin);
                command.Parameters.AddWithValue("@adult", adult);
                command.Parameters.AddWithValue("@children", children);
                command.Parameters.AddWithValue("@infants", infants);
                command.Parameters.AddWithValue("@seat", seat);
                command.Parameters.AddWithValue("@totalCost", totalCost);
                command.Parameters.AddWithValue("@flightName", flightName);
                command.Parameters.AddWithValue("@ticketNumber", ticketNumber);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                //Console.WriteLine("naaaaaaaaaaaaaaa     " + e);
                conn.Close();


            }
        }
        public void update(string name, int num, string cabin)
        {
            //Console.WriteLine(name +"     "+num +"      "+cabin);
            try
            {

                conn.ConnectionString = "Data Source=DESKTOP-NTSPRDK\\SQLEXPRESS;Initial Catalog=ATC and Ticket;Integrated Security=True";
                conn.Open();

                if (cabin == "First Class")
                {
                    SqlCommand command = new SqlCommand("update ATCFlightList set AvailableSeatForFirstClass=@first where [Flight Name]=@value", conn);
                    command.Parameters.AddWithValue("@first", num);
                    command.Parameters.AddWithValue("@value", name);
                    command.ExecuteNonQuery();
                    conn.Close();

                }
                else if (cabin == "Business Class")
                {
                    SqlCommand command = new SqlCommand("update ATCFlightList set AvailableSeatForBusinessClass=@first where [Flight Name]=@value", conn);
                    command.Parameters.AddWithValue("@first", num);
                    command.Parameters.AddWithValue("@value", name);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    SqlCommand command = new SqlCommand("update ATCFlightList set AvailableSeatForEconomyClass=@first where [Flight Name]=@value", conn);
                    command.Parameters.AddWithValue("@first", num);
                    command.Parameters.AddWithValue("@value", name);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch(Exception e)
            {
                //Console.WriteLine("aaaaaaaaaaaaaaaaaaaa       "+e);
                conn.Close();
            }

        }

    }
}

