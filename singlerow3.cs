using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restorent_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            RestorentDataLayer rdl = new RestorentDataLayer();
            /*Restorent r = rdl.SetResrorentDetails();
            rdl.ToInsertRestorentDetails(r);
           Console.WriteLine("List of restorents:\n\n");
            rdl.ShowRList(rdl.ToSelectRestorentDetails());*/
            rdl.ShowRList(rdl.ToSearchBy());
            Console.Read();
        }
                     
    }
}
