//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsProject207
{
    public partial class LogoutUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Labellogout.Text = Convert.ToString(Session["login_user"]);
            Master.labelcart.Text = "0";
            Session.Clear();
            Session.RemoveAll();
        }
    }
}