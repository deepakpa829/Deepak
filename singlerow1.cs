using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restorent_Ex
{
    class RestorentDataLayer
    {
        private string connection_string;

        public RestorentDataLayer()
        {
            connection_string = @"Data Source=BLT1053\SQLEXPRESS2014;Initial Catalog=cor;Integrated Security=True";
        }

        // set restorent data
        public Restorent SetResrorentDetails()
        {
            Restorent rs = new Restorent();
            Console.WriteLine("Enter Id:");
            rs.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter restorent name:");
            rs.Rname = Console.ReadLine();

            Console.WriteLine("Enter location:");
            rs.Rlocation = Console.ReadLine();

            Console.WriteLine("Enter rating 1-5:");
            rs.Rating = int.Parse(Console.ReadLine());

            return rs;

        }

        // to insert data
        public  void ToInsertRestorentDetails(Restorent r)
        {
            
            
            string query = "insert into Reaustaurant values('"+r.id+"','" + r.Rname + "','" + r.Rlocation + "','" + r.Rating + "')";
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    Console.WriteLine("{0} Rows inserted", command.ExecuteNonQuery());
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        // to return List of restorents 
        public  List<Restorent> ToSelectRestorentDetails()
        {
            List<Restorent> rlist = new List<Restorent>();
            string query = "select * from Reaustaurant";
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader sdr = command.ExecuteReader();
                    

                    
                    while (sdr.Read())
                    {
                        Restorent r = new Restorent();
                        r.id = sdr.GetInt32(0);
                        r.Rname = sdr.GetString(1);
                        r.Rlocation = sdr.GetString(2);
                        r.Rating = sdr.GetInt32(3);

                        rlist.Add(r);
                       
                    }

                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return rlist;
        }

        // to delete data
        public void ToDeleteRestorentDetails()
        {
            Console.WriteLine("Restorent Name or Reg No  ..? ");
            string r_name_no = Console.ReadLine();

            string query = "delete from Reaustaurant where rname = '" + r_name_no + "' or id = '" + r_name_no + "'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    Console.WriteLine("{0} Rows Deleted", command.ExecuteNonQuery());
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        // to display restorent list
        public void ShowRList(List<Restorent> rlist)
        {
            foreach (Restorent r in rlist)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", r.id,r.Rname,r.Rlocation,r.Rating);
            }
        }
        //....


        // to search by rname or rid
        public List<Restorent> ToSearchBy()
        {
            
            List<Restorent> rlist = new List<Restorent>();

            Console.WriteLine("Enter  Id:");
            string r_name = Console.ReadLine();
            
            string query = "select * from Reaustaurant where id = '" + r_name + "' or rname = '"+r_name+"'";
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader sdr = command.ExecuteReader();



                    while (sdr.Read())
                    {
                        Restorent r = new Restorent();
                        r.id = sdr.GetInt32(0);
                        r.Rname = sdr.GetString(1);
                        r.Rlocation = sdr.GetString(2);
                        r.Rating = sdr.GetInt32(3);
                        rlist.Add(r);

                    }

                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return rlist;
        }


    }
}
