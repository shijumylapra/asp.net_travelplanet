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
    public partial class Confrmation : System.Web.UI.Page
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


            // Session["login_user"]


            if (Session["_CustomerId"] != null)
            {

                CustomerData.GetRecordsPackages(Convert.ToInt32(Session["_CustomerId"]));

                lblFirstname.Text = CustomersDetails.CusFirstName;
                lblLastName.Text = CustomersDetails.CusLastName; ;
                lblPostal.Text = CustomersDetails.CustPostal;
                lblcountry.Text = CustomersDetails.CusCountry;
                lblhome0.Text = CustomersDetails.CusBusPhone;
                lblemailcus.Text = CustomersDetails.CustEmail;


                //lblid.Text = Session["_PackageId"].ToString();

                lconfdesc.Text = GetBookingDetails.PackageDesc;
                lconfstart.Text = Convert.ToString(GetBookingDetails.PkgStartDate);
                lconfend.Text = Convert.ToString(GetBookingDetails.PkgEndDate);
                lconfprice.Text = Convert.ToString(GetBookingDetails.PkgBasePrice);
                lblBookingNumber.Text = Convert.ToString(GetBookingDetails.Bookingnumber);
                lblbookingdate.Text = Convert.ToDateTime(GetBookingDetails.BookingDate).ToString("dd/MMM/yyyy");
                lbltravelcount.Text = Convert.ToString(GetBookingDetails.TravelerCount);

                lbltotalprice.Text = Math.Round(Convert.ToDouble(GetBookingDetails.PkgBasePrice), 2).ToString();
            }

 

        }
    }
}