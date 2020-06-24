using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AirTrafficAndTicketManagement
{
    class DataBase
    {
        public static SqlConnection conn = new SqlConnection();

        
        public static void Main(string[] args)
        {
            conn.ConnectionString = "Data Source=DESKTOP-NTSPRDK\\SQLEXPRESS;Initial Catalog=ATC and Ticket;Integrated Security=True";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM userlogin", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //s = reader[0].ToString;
                    
                        Console.WriteLine(reader["user_name"]+"   "+reader["password"]);

                        
                }
                conn.Close();

            }
            catch (Exception)
            {
                

            }
            conn.Close();
            Console.ReadLine();
        }
       
    }
}

