using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsProject207
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["login_user"] != null)
            {
                Master.linklogin.Visible = false;
                Master.linklogout.Visible = true;
                Master.labelusername.Visible = true;
                Master.labelusername.Text = string.Format("{0}{1}", "", Session["login_user"]);
                // Session.Clear();
                // Session.RemoveAll();
            }
        }
    }
}