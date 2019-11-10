//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClassLibrary;
using System.Web.Security;


namespace TravelExpertsProject207
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_user"] != null)
            {
                Response.Redirect("Customer.aspx");
            }
        }
        protected void BtnLoginSave_Click(object sender, EventArgs e)
        {

            Users ObjUser = new Users();
            if (Page.IsPostBack)
            {
                Users.UserName = TextUserName.Text.Trim();
                Users.UserPassword = TextPassword.Text.Trim();

                CustomerData CusData = new CustomerData();

                if (CusData.IsLoggedIn() > 0)
                {
                     


                    Session.Clear();
                    Session.RemoveAll();



                    Session["login_user"] = TextUserName.Text.Trim();
                    string CustomerId = Convert.ToString(Users.CustomerId);
                    Session["_CustomerId"] = CustomerId;
                    Response.Redirect("~/Customer.aspx");

 

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "alert('" + "Invalid User Name or Password" + "');", true);

                }
            }
        }
    }
}
//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II