using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApDataOperations
{
    public partial class WebFormdata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                
            }
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOlayer ad = new ADOlayer();
            int Id = Convert.ToInt32(Id1.Text);
            string Sname = Sname1.Text;
            ad.UpdateRecord(Id, Sname);
            var t = ad.Getallrecords();
            GridView1.DataSource = t;
            GridView1.Dispose();

            ADOlayer ado = new ADOlayer();
            var stlist = ado.Getallrecords();
            GridView1.DataSource = stlist;
            GridView1.DataBind();

            
        }
    }
}