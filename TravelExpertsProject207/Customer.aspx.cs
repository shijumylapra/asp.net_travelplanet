//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using WebClassLibrary;

namespace TravelExpertsProject207
{
    public partial class Customer : System.Web.UI.Page
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
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

                if (!Page.IsPostBack)
                {
                    BindData();

                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "alert('" + ex.ToString() + "');", true);

            }

            //if (!IsPostBack)
            //{
            //    bindData();
            //}
        }

        public void BindData()
        {
            LBLCUSTOMERWELCOME.Text = string.Format("{0}{1}{2} ", CustomersDetails.CusFirstName, " ", CustomersDetails.CusLastName);

            if (Session["_CustomerId"] != null)
            {
                 
                    

               con = Connection.GetConnection();
                cmd.CommandText = "select [Packages].[PkgName]as PackageName,[Packages].[PackageId],[Packages].[PkgStartDate]," +
                    "[Packages].[PkgEndDate],[Packages].[PkgDesc] as PackageDesc,round([Packages].[PkgBasePrice],2)  AS PkgBasePrice," +
                    "[Bookings].[BookingDate],[Bookings].[BookingNo],[Bookings].[TravelerCount]," +
                    "[Customers].[CustFirstName],[Customers].[CustLastName],[Customers].[CustCity]," +
                    "[Customers].[CustCountry],[Customers].[CustBusPhone],[Customers].[CustEmail]," +
                    "[Customers].[CustPostal] from[dbo].[Customers] inner join[dbo].[Bookings] on " +
                    "[dbo].[Customers].[CustomerId] = [dbo].[Bookings].[CustomerId] inner join[dbo].[Packages] " +
                    "on [dbo].[Packages].[PackageId] = [dbo].[Bookings].[PackageId] where [Bookings].[CustomerId] = " + Convert.ToInt32(Session["_CustomerId"]) + " ";
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Open();
                cmd.ExecuteNonQuery();

                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();

                CustomerData.GetRecordsPackages(Convert.ToInt32(Session["_CustomerId"]));
                double num = (double)GetBookingDetails.TotalPrice;
                string str = num.ToString("$ 0.00");
                LBLTOTLAPRICE.Text = str.ToString();

                con.Close();

            }

            //if (Session["_CustomerId"] != null)
            //{
            //    try
            //    {



            //        GridPackage.DataSource = CustomerData.GetRecordsPackages(Convert.ToInt32(Session["_CustomerId"]));
            //        GridPackage.DataBind();
            //       // lbltotalprice.Text = Convert.ToString(GetBookingDetails.TotalPrice);
            //        //GridPackage.DataSource = CustomerData.GetCustomerPackageRecords(Convert.ToInt32(Session["_CustomerId"]));
            //        GridPackage.DataBind();
            //    }
            //    catch (System.Data.SqlClient.SqlException ex)
            //    {
            //        ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "alert('" + ex.ToString() + "');", true);

            //    }
            //}

        }
        private string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numbers = "0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < 2; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            for (int i = 2; i < 6; i++)
            {
                stringChars[i] = numbers[random.Next(numbers.Length)];
            }
            for (int i = 6; i < 8; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
        protected void Grid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            //Grid.CurrentPageIndex = e.NewPageIndex;
            //BindData();
        }
    }
}