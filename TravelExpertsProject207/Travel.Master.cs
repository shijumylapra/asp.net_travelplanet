//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsProject207
{
    public partial class Travel : System.Web.UI.MasterPage
    {
        public Label labelusername
        {
            get
            {
                return this.Labelusername;
            }
        }
        public LinkButton linklogin
        {
            get
            {
                return this.LinkUserLogin;
            }
        }
        public LinkButton linklogout
        {
            get
            {
                return this.LinkUserlogout;
            }
        }
        public Label labelcart
        {
            get
            {
                return this.lblcart;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkButton100_Click(object sender, EventArgs e)
        {
            Session["login_user"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}
//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II