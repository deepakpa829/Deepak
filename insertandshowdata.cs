using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdonetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            insert();
            Show();
        }
         public static void Show()
         {
             try
             {
                 string con = @"Data Source=BLT1053\SQLEXPRESS2014;Initial Catalog=cor;Integrated Security=True";

                 using (SqlConnection sc = new SqlConnection(con))
                 {
                     string query = "Select * from Reaustaurant";
                     sc.Open();
                     SqlCommand cmd = new SqlCommand(query, sc);
                     SqlDataReader reader = cmd.ExecuteReader();
                     while (reader.Read())
                     {
                         Console.WriteLine("{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                     }
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
         }
     

        public static void insert()
        {
            string con = @"Data Source=BLT1053\SQLEXPRESS2014;Initial Catalog=cor;Integrated Security=True";
            try
            {
                using (SqlConnection sq1 = new SqlConnection(con))
                {
                    string query1 = "insert into Reaustaurant values('Samrat','Delhi',5)";
                    sq1.Open();
                    SqlCommand cmd = new SqlCommand(query1, sq1);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        

    }    
}

        
   
    

