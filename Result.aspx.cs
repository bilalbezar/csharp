using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPQueryString
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<b>Name: </b>" + Request.QueryString["name"] + "<br>" );
            Response.Write("<b>Age: </b>" + Request.QueryString["age"] + "<br>");
            Response.Write("<b>City: </b>" + Request.QueryString["city"] + "<br>");
        }
    }
}