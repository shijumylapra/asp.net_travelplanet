//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Threading;
using System.Web.UI.WebControls;
using WebClassLibrary;
using System.Text.RegularExpressions;

namespace TravelExpertsProject207
{
    public partial class Register : System.Web.UI.Page
    {
        int packId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
          

            lblerror.Text = "";
            if (Session["_PackageId"] != null)
            {
                packId = (int)Session["_PackageId"];
                CustomerData.GetPackage(Convert.ToInt32(packId));
                lblPackageText.Text = PackagesList.PkgName;
                lblPackageText2.Text = PackagesList.PkgDesc;
            }



        }
        private bool canadianZipCode(string zipCode)
        {
            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";

            var validZipCode = true;
            if (!Regex.Match(zipCode, _caZipRegEx).Success)
            {
                validZipCode = false;
            }
            return validZipCode;
        }
        void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtPassword2.Text = "";
            txtPassword1.Text = "";
            txtPostalcode.Text = "";
        }
        public bool IsPasswordsEqual(string password1, string password2)
        {
            if (password1.Equals(password2))
            {
                return true;
            }

            return false;
        }

        //public void IsNull()
        //{
        //    if (txtFirstName.Text.Length == 0 )
        //    {
        //        lblerror.Text = "First Name should not be empty";
        //    }
        //    else if (txtCity.Text.Length == 0)
        //    {
        //        lblerror.Text = "City should not be empty";
        //    }
        //    if (txtContact.Text.Length == 0)
        //    {
        //        lblerror.Text = "Contact Number should not be empty";
        //    }
        //    if (txtPostalcode.Text.Length == 0)
        //    {
        //        lblerror.Text = "Postal Code should not be empty";
        //    }

        //}

        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^\(?\d{3}\)?[\s\-]?\d{3}\-?\d{4}$").Success;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFirstName.Text=="")
                {
                    lblerror.Text = "First Name should not be empty";
                    return;
                }

                if (txtContact.Text == "")
                {
                    lblerror.Text = "Please enter you Contact Number";
                    return;
                }
                if (txtPostalcode.Text == "")
                {
                    lblerror.Text = "Please enter you Posta Code";
                    return;
                }
                if (txtEmail.Text == "")
                {
                    lblerror.Text = "Please provide your Email";
                    return;
                }
                

                if (!IsPasswordsEqual(txtPassword1.Text, txtPassword2.Text))
                {
                    lblerror.Text = "The password and confirmation password do not match";
                    return;
                }
                else if (canadianZipCode(txtPostalcode.Text.Trim()) == false)
                {
                    lblerror.Text = "Postal Code is not a valid format";
                    return;
                }
                else if (IsPhoneNumber(txtContact.Text.Trim()) == false)
                {
                    lblerror.Text = "Phone Number is not a valid format";
                    return;
                }
                {


                    CustomerData ObjCData;
                    //  int PKID = int.Parse(lblPackageId.Text);
                    CustomersDetails.CusFirstName = txtFirstName.Text.Trim().ToUpper();
                    CustomersDetails.CusLastName = txtLastName.Text.Trim().ToUpper();
                    CustomersDetails.CusCity = txtCity.Text.Trim();
                    CustomersDetails.CustPostal = txtPostalcode.Text.Trim();
                    CustomersDetails.CusCountry = txtCountry.Text.Trim();
                    CustomersDetails.CusBusPhone = txtContact.Text.Trim();
                    CustomersDetails.CustEmail = txtEmail.Text.Trim();
                    Users.UserName = txtEmail.Text.Trim();
                    Users.UserPassword = txtPassword2.Text.Trim();
                    Users.CusPackageId = packId;
                    CustomersDetails.AgentId = 1;

                    Bookingdetails.BookingDate = DateTime.Now;
                    Bookingdetails.Bookingnumber = "TB34S";
                    Bookingdetails.TravelerCount = Convert.ToInt16(Session["TravelCount"]);

                    Bookingdetails.TripTypeId = "B";
                    Bookingdetails.PackageId = packId;
                    ObjCData = new CustomerData();

                    int pass = ObjCData.SaveCustomerDetails();

                    if (pass > 0)
                    {

                        string firstname = txtFirstName.Text.Trim();
                        Session["_firstname"] = firstname;
                        string lastname = txtLastName.Text.Trim();
                        Session["_lastname"] = lastname;
                        string city = txtCity.Text.Trim();
                        Session["_City"] = city;
                        string postal = txtPostalcode.Text.Trim();
                        Session["_postal"] = postal;
                        string country = txtCountry.Text.Trim();
                        Session["_country"] = country;
                        string phone = txtContact.Text.Trim();
                        Session["_phone"] = phone;
                        string email = txtEmail.Text.Trim();
                        Session["_email"] = email;

                        string CustomerId = Convert.ToString(pass);
                        Session["_CustomerId"] = pass;

                        //string message = "Your details have been saved successfully.";
                        //string script = "window.onload = function(){ alert('";
                        //script += message;
                        //ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                        try
                        {
                            Response.Redirect("Confrmation.aspx", false);
                        }
                        catch (ThreadAbortException ex)
                        {
                            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "alert('" + ex.ToString() + "');", true);

                        }



                        //ScriptManager.RegisterStartupScript(this.Page, GetType(), "YourUniqueScriptKey", "alert('Record Saved');", true);
                    }
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "alert('" + ex.ToString() + "');", true);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "confirm", "" +
            //"document.body.onload = function(){" +
            //  "if(confirm('Do you want to Clear All fields it ..!!')==false)" +
            //    "{" +
            //       "document.getElementById('myTextBox').value='';" +
            //    "}" +
            //  "}", true);
        }

        protected void Button2_Click1(object sender, EventArgs e)
        { 
        }
    }
}
//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II