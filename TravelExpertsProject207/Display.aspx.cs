//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClassLibrary;

namespace TravelExpertsProject207
{
    public partial class Display : System.Web.UI.Page
    {

        int PackageId = 0;
        CustomerData ObjCData;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PackageName"] != null)
            {
                lblpckname.Text = Session["PackageName"].ToString();
            }
        }
        bool SaveData(int IdPack)
        {
            if (Session["_CustomerId"] != null)
            {
                int CusId = Convert.ToInt16(Session["_CustomerId"]);
                Bookingdetails.BookingDate = DateTime.Now;
                Bookingdetails.Bookingnumber = "TR33";
                Bookingdetails.TravelerCount = Convert.ToInt16(Session["TravelCount"]);
                Bookingdetails.TripTypeId = "B";
                Bookingdetails.PackageId = (int)Session["_PackageId"];
                ObjCData = new CustomerData();
                bool pass = ObjCData.SaveBookingDetailsAfterLogin(CusId);

                if (pass)
                {
                    return true;
                }
            }
            return false;
        }
        protected void linkpackagecontinue_Click(object sender, EventArgs e)
        {
            Session["TravelCount"] = DropDownList1.Text;
            if (Session["login_user"] != null)
            {
                if (SaveData(PackageId) == true)
                    Response.Redirect("Customer.aspx");
            }
            else
            {
                Response.Redirect("Register.aspx");
            }

        }

        

    }
}