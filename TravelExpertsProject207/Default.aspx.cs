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
    public partial class Default : System.Web.UI.Page
    {
        int PackageId = 0;
 
        protected void Linkselect1_Click(object sender, EventArgs e)
        {
            PackageId = int.Parse(lbl_AID1.Text);
            Session["_PackageId"] = PackageId;
            Session["PackageName"] = lbl_AN1.Text;
            Response.Redirect("Display.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void BtnSelect_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {


        }

        protected void Linkpack1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }


        protected void LinkButton6_Click(object sender, EventArgs e)
        {



        }
        protected void Linkselect2_Click(object sender, EventArgs e)
        {
            PackageId = int.Parse(lbl_AID2.Text);
            Session["_PackageId"] = PackageId;
            Session["PackageName"] = lbl_AN2.Text;
            Response.Redirect("Display.aspx");
        }

        protected void Linkselect3_Click(object sender, EventArgs e)
        {
            PackageId = int.Parse(lbl_AID3.Text);
            Session["_PackageId"] = PackageId;
            Session["PackageName"] = lbl_AN3.Text;
            Response.Redirect("Display.aspx");

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Label1.Text = ListPackages[i].PkgName money.amount, money.type;
                //Label2.Text = istPackages[i].PkgDesc;
                List<PackageonLoad> ListPackages = new List<PackageonLoad>();
                ListPackages = CustomerData.GetPackagesDetailsLoad();

                for (var i = 0; i < ListPackages.Count; i++)
                {
                    if (i == 0)
                    {
                        lbl_AN1.Text = ListPackages[i].PkgName;
                        lbl_AD1.Text = ListPackages[i].PkgDesc;
                        lbl_AID1.Text = ListPackages[i].PackageId.ToString();

                    }
                    else if (i == 1)
                    {
                        lbl_AN2.Text = ListPackages[i].PkgName;
                        lbl_AD2.Text = ListPackages[i].PkgDesc;
                        lbl_AID2.Text = ListPackages[i].PackageId.ToString();

                    }
                    else if (i == 2)
                    {
                        lbl_AN3.Text = ListPackages[i].PkgName;
                        lbl_AD3.Text = ListPackages[i].PkgDesc;
                        lbl_AID3.Text = ListPackages[i].PackageId.ToString();
                    }
                    else if (i == 3)
                    {
                        lbl_AN4.Text = ListPackages[i].PkgName;
                        lbl_AD4.Text = ListPackages[i].PkgDesc;
                        lbl_AID4.Text = ListPackages[i].PackageId.ToString();
                    }
                    else if (i == 4)
                    {
                        lbl_AN5.Text = ListPackages[i].PkgName;
                        lbl_AD5.Text = ListPackages[i].PkgDesc;
                        lbl_AID5.Text = ListPackages[i].PackageId.ToString();
                    }
                    else if (i == 5)
                    {
                        lbl_AN6.Text = ListPackages[i].PkgName;
                        lbl_AD6.Text = ListPackages[i].PkgDesc;
                        lbl_AID6.Text = ListPackages[i].PackageId.ToString();
                    }
                }
                //LblDate1.Text = string.Format("{0} : {1}", "From", PackagesList.PkgStartDate.ToLongDateString());
                //lbldateto1.Text = string.Format("{0} : {1}", "To", PackagesList.PkgEndDate.ToLongDateString());


                if (Session["_CustomerId"] != null)
                {
                    int sessID = Convert.ToInt16(Session["_CustomerId"]);
                    List<int> DataPackage = new List<int>();

                    DataPackage = CustomerData.UserPackageList(sessID);

                    for (int i = 0; i < DataPackage.Count; i++) // Loop through List with for
                    {
                        int y = DataPackage[i];
                        if (y == Convert.ToInt16(lbl_AID1.Text))
                        {
                            Linkselect1.Visible = false;
                        }
                        else if (y == Convert.ToInt16(lbl_AID2.Text))
                        {
                            Linkselect2.Visible = false;
                        }
                        else if (y == Convert.ToInt16(lbl_AID3.Text))
                        {
                            Linkselect3.Visible = false;
                        }
                    }

                }

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
}