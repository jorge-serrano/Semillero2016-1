using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["User"].Equals(""))
            //{
                Response.Redirect("Index.aspx");
        //    }
        //    else
        //        Response.Write(Session["User"].ToString());
        }
    }
}