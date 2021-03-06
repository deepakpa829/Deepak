﻿using System;
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
            try { 
            string constr = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Dee; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string querystr = "select * from Student ";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        
    }
}
