using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApDataOperations
{
    public class ADOlayer
    {

        string constr = "";
        public ADOlayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;

        }
        public DataSet Getallrecords()
        {
            DataSet ds1 = new DataSet();
            string selquery = "select * from Student ";
            try
            {
               using(SqlConnection con=new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds1);
                }
            }
            catch(Exception ex)
            {

            }
            return ds1;
        }
       
        public void UpdateRecord(int Id,string Sname)
        {
            DataSet ds = new DataSet();
            try
            {
                using(SqlConnection con=new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Sname", Sname);
                    cmd.CommandText = "UpdateRecords";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch(Exception ex)
            { }
        }
        /*public void InsertRecord(string Id1, string Sname)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Id", Id1);
                    cmd.Parameters.AddWithValue("@Sname", Sname);
                    cmd.CommandText = "InsertRecords";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch (Exception ex)
            { }
        }*/
        


    }
}