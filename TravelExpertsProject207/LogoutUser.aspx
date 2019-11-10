<%@ Page Title="" Language="C#" MasterPageFile="~/Travel.Master" AutoEventWireup="true" CodeBehind="LogoutUser.aspx.cs" Inherits="TravelExpertsProject207.LogoutUser" %>
<%@ MasterType VirtualPath="~/Travel.Master" %>
<%@ Import Namespace="System.Data" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <!--================Home Banner Area =================-->
        <section class="banner_area">
            <div class="banner_inner d-flex align-items-center">
            	<div class="overlay bg-parallax" data-stellar-ratio="0.9" data-stellar-vertical-offset="0" data-background=""></div>
				<div class="container">
					<div class="banner_content text-center">
						<h2>LOG OUT</h2>
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
								<img class="img-fluid" src="images/logout.jpg" alt="">
							</div>
						</div>
						<div class="col-md-6">
							<div class="portfolio_right_text">
                                <h3> Thank you</h3>
								<h4> 
                                    <asp:Label ID="Labellogout" runat="server" Text="Label"></asp:Label>
                                </h4>
								<h3> You have been successfully logged out!" </h3>
              
							</div>
						</div>
					</div>
         		</div>
        	</div>
        </section>
        <!--================End Portfolio Details Area =================-->

      
  <div>


      <asp:Label ID="lblid" runat="server" Visible="False"></asp:Label>

  </div>
</asp:Content>
