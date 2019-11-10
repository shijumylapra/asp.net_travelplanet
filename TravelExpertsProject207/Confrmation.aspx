<%@ Page Title="" Language="C#" MasterPageFile="~/Travel.Master" AutoEventWireup="true" CodeBehind="Confrmation.aspx.cs" Inherits="TravelExpertsProject207.Confrmation" %>
<%@ MasterType VirtualPath="~/Travel.Master" %>
<%@ Import Namespace="System.Data" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
#packages {
    font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
    border-collapse: collapse;
    width: 100%;
}

#packages td, #packages th {
    border: 1px solid #ddd;
    padding: 8px;
}

#packages tr:nth-child(even) {
    background-color: darkslategray;
}

#packages tr:hover {
    background-color: cornsilk;
}

#packages th {
    padding-top: 12px;
    padding-bottom: 12px;
    text-align: left;
    background-color: cadetblue;
    color: white;
}

.auto-style4 {
    width: 194px;
}


.auto-style5 {
    width: 97%;
}

.auto-style6 {
    width: 371px;
}

#customers {
    font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
    border-collapse: collapse;
    width: 100%;
}

    #customers td, #customers th {
        border: 1px solid #ddd;
        padding: 8px;
    }

    #customers tr:nth-child(even) {
        background-color: greenyellow;
    }

    #customers tr:hover {
        background-color: darksalmon;
    }

    #customers th {
        padding-top: 12px;
        padding-bottom: 12px;
        text-align: left;
        background-color: #4CAF50;
        color: white;
    }

.auto-style4 {
    width: 194px;
}


.auto-style5 {
    width: 97%;
}

.auto-style6 {
    width: 310px;
}


.auto-style7 {
    width: 90px;
}

.auto-style8 {
    width: 114px;
}

.auto-style9 {
    width: 114px;
    height: 27px;
}

.auto-style10 {
    width: 90px;
    height: 27px;
}

.auto-style11 {
    height: 27px;
}
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <!--================Home Banner Area =================-->
        <section class="banner_area">
            <div class="banner_inner d-flex align-items-center">
            	<div class="overlay bg-parallax" data-stellar-ratio="0.9" data-stellar-vertical-offset="0" data-background=""></div>
				<div class="container">
					<div class="banner_content text-center">
						<h2>CONFIRMATION </h2>
						<div class="page_link">
							<a href="Default.aspx">Home</a>
							 
						</div>
					</div>
				</div>
            </div>
        </section>
        <!--================End Home Banner Area =================-->
      <!--================Portfolio Details Area =================-->
        <section class="portfolio_details_area p_120">
        	<div class="container">
        		<div class="portfolio_details_inner">
					<div class="row">
						<div class="col-md-6">
							<div class="left_img">
								<img class="img-fluid" src="images/project-details-1.jpg" alt="">
							</div>
						</div>
						<div class="col-md-6">
							<div class="portfolio_right_text">
								<h4>Your details have been saved successfully</h4>
								<p>Here is your Personal information</p>
                                <table id="customers" class="auto-style5" style="border-style: double; border-color: #808000">
                    <tr>
                        <td class="auto-style4">First Name</td>
                        <td class="auto-style6">
                            <asp:Label ID="lblFirstname" runat="server" Text="null"></asp:Label>
                        </td>
                        
                    </tr>
                    <tr>
                        <td class="auto-style4">Last Name</td>
                        <td class="auto-style6">
                            <asp:Label ID="lblLastName" runat="server" Text="null"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">City</td>
                        <td id="lblCity" class="auto-style6">lbl</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Postal Code</td>
                        <td class="auto-style6">
                            <asp:Label ID="lblPostal" runat="server" Text="null"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Country</td>
                        <td class="auto-style6">
                            <asp:Label ID="lblcountry" runat="server" Text="null"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Home Phone</td>
                        <td class="auto-style6">
                            <asp:Label ID="lblhome0" runat="server" Text="null"></asp:Label>
                        </td>
                    </tr>
                      
                    <tr>
                        <td class="auto-style4">Email</td>
                        <td class="auto-style6">
                            <asp:Label ID="lblemailcus" runat="server" Text="null"></asp:Label>
                        </td>
                    </tr>
                    </table>
							</div>
						</div>
					</div>

       				<h4>Here is your Package Details</h4>
                     <table  id="packages" style="border-style: double; border-color: #336699">
                     <tr>
                         <th class="auto-style8">Booking Number</th>
                         <th class="auto-style7">Booking Date</th>
                        <th class="auto-style7">Travel Count</th>
                        <th>Package Description</th>
                        <th>StartDate</th>
                        <th>EndDate</th>
                        <th>Price</th>
                      </tr>
                         <tr>
                              <td class="auto-style8">
                                 <asp:Label ID="lblBookingNumber" runat="server" Text="null"></asp:Label>
                             </td>
                              <td class="auto-style7">
                                 <asp:Label ID="lblbookingdate" runat="server" Text="null"></asp:Label>
                             </td>
                              <td class="auto-style7">
                                 <asp:Label ID="lbltravelcount" runat="server" Text="null"></asp:Label>
                             </td>
                            
                             <td>
                                 <asp:Label ID="lconfdesc" runat="server" Text="null"></asp:Label>
                             </td>
                             <td>
                                 <asp:Label ID="lconfstart" runat="server" Text="null"></asp:Label>
                             </td>
                             <td>
                                 <asp:Label ID="lconfend" runat="server" Text="null"></asp:Label>
                             </td>
                             <td>
                                 <asp:Label ID="lconfprice" runat="server" Text="null"></asp:Label>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style9"></td>
                             <td class="auto-style10"></td>
                             <td class="auto-style10"></td>
                             <td class="auto-style11">
                                 &nbsp;</td>
                             <td class="auto-style11">
                                 &nbsp;</td>
                             <td>
                                 <asp:Label ID="Label1" runat="server" Text="Total Price"></asp:Label>
                             </td>
                             <td>
                                 <asp:Label ID="lbltotalprice" runat="server"></asp:Label>
                             </td>
                         </tr>
                    </table>
                   

        		</div>
        	</div>
        </section>
        <!--================End Portfolio Details Area =================-->

      
  <div>


      <asp:Label ID="lblid" runat="server" Visible="False"></asp:Label>

  </div>
</asp:Content>
