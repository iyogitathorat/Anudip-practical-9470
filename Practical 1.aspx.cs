using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yogita__Thorat
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            string str = "yogita satish thorat";
            int x = 7;
            DateTime d = DateTime.Parse("23-may-1998");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Response.Write(o);
                Response.Write("<br>");





            }
        }

    }
}
   
