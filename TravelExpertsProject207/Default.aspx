<%@ Page Title="" Language="C#" MasterPageFile="~/Travel.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TravelExpertsProject207.Default" %>
<%@ MasterType VirtualPath="~/Travel.Master" %>
<%@ Import Namespace="System.Data" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/style.css" rel="stylesheet" />
    <link href="assetcss/css/styleasset.css" rel="stylesheet" />
    <link href="woodcss/css/responsive.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!--================Home Banner Area =================-->
        <section class="home_banner_area">
            <div class="banner_inner">
				<div class="container">
					<div class="row">
						<div class="col-lg-8">
							<div class="banner_content">
								<h2>British Virgin Islands Vacation Packages</h2>
								<p>Explore The British Virgin Islands in private cabins on a week long catamaran cruise aboard our Lagoon 620 or Ipanema 58 with captain, hostess and food included.</p>
								 <a class="banner_btn" >Coming Soon!</a>  
							</div>
						</div>
						<div class="col-lg-4">
							<div class="home_right_box">
								<h1>Call Us 24/7</h1>
                                <h1>1-800-900-1431</h1>
							</div>
						</div>
					</div>
				</div>
            </div>
        </section>
        <!--================End Home Banner Area =================-->
 
    
     <!--================== Blog section =====================-->
  <div id="blog" class="blog">
      <div class="container">
          <div class="row">
            <div class="col-sm">
                <div class="blog-item-box">
                <figure class="blog-item">
                    <div class="image">
                      <img src="images/sample18.jpg" alt="sample74"/>

                      <i class="fa fa-clock-o" aria-hidden="true" style="left: 12px; top: 7px"></i>
                      <div class="date"><span class="day">
                          <asp:Label ID="Label1" runat="server" Text="7"></asp:Label></span><span class="month">Nov</span></div>
                    </div>
                    <figcaption>

                      <h5><asp:Label ID="lbl_AN1" runat="server" Text=""></asp:Label> </h5>
                      <p><asp:Label ID="lbl_AD1" runat="server" Text=""></asp:Label></p>
                      
                        &nbsp;<asp:LinkButton ID="Linkselect1"  class="read-more" runat="server" OnClick="Linkselect1_Click">Select</asp:LinkButton>&nbsp;&nbsp;
                        
                      <asp:Label ID="lbl_AID1" runat="server" Visible="False"></asp:Label>
                        
                    </figcaption>
                  </figure>
                </div>
            </div>
            <div class="col-sm">
              <div class="blog-item-box">
                <figure class="blog-item">
                    <div class="image">
                      <img src="images/sample17.jpg" alt="sample87"/>
                      <i class="fa fa-clock-o" aria-hidden="true"></i>
                      <div class="date"><span class="day">11</span>
                        <span class="month">Nov</span></div>
                    </div>
                    <figcaption>
                     <h5>  <asp:Label ID="lbl_AN2" runat="server" Text=""></asp:Label> </h5>
                      <p>  <asp:Label ID="lbl_AD2" runat="server" Text=""></asp:Label> </p>
                        <asp:LinkButton ID="Linkselect2" class="read-more"  runat="server" OnClick="Linkselect2_Click">Select</asp:LinkButton>&nbsp;&nbsp;
                        <asp:Label ID="lbl_AID2" runat="server" Visible="False"></asp:Label>

        

                    </figcaption>
                  </figure>
                </div>
            </div>
            <div class="col-sm">
              <div class="blog-item-box">
                <figure class="blog-item">
                    <div class="image">
                      <img src="images/sample120.jpg" alt="sample84"/>
                      <i class="fa fa-clock-o" aria-hidden="true"></i>
                      <div class="date"><span class="day">16</span><span class="month">Nov</span></div>
                    </div>
                    <figcaption>
                       
                      <h5> <asp:Label ID="lbl_AN3" runat="server" Text=""></asp:Label> </h5>
                      <p> <asp:Label ID="lbl_AD3" runat="server" Text=""></asp:Label></p>
                        <asp:LinkButton ID="Linkselect3" class="read-more"  runat="server" OnClick="Linkselect3_Click">Select</asp:LinkButton>&nbsp;&nbsp;
                        <asp:Label ID="lbl_AID3" runat="server" Text="Label" Visible="False"></asp:Label>

                    </figcaption>
                  </figure>
              </div>
            </div>
          </div>
        </div>
  </div>

        <!--================== Blog section =====================-->
  <div id="blog" class="blog">
      <div class="container">
          <div class="row">
            <div class="col-sm">
                <div class="blog-item-box">
                <figure class="blog-item">
                    <div class="image">
                      <img src="images/sample13.jpg" alt="sample74"/>

                      <i class="fa fa-clock-o" aria-hidden="true" style="left: 12px; top: 7px"></i>

                      <div class="date"><span class="day">16</span><span class="month">Nov</span></div>
                    </div>
                    <figcaption>

                      <h5><asp:Label ID="lbl_AN4" runat="server" Text=""></asp:Label> </h5>
                      <p><asp:Label ID="lbl_AD4" runat="server" Text=""></asp:Label></p>
                      
                        &nbsp;<asp:LinkButton ID="LinkButton1"  class="read-more" runat="server" OnClick="Linkselect1_Click">Select</asp:LinkButton>&nbsp;&nbsp;
                        
                      <asp:Label ID="lbl_AID4" runat="server" Visible="False"></asp:Label>
                        
                    </figcaption>
                  </figure>
                </div>
            </div>
            <div class="col-sm">
              <div class="blog-item-box">
                <figure class="blog-item">
                    <div class="image">
                      <img src="images/sample14.jpg" alt="sample87"/>
                      <i class="fa fa-clock-o" aria-hidden="true"></i>
                      <div class="date"><span class="day">22</span>
                        <span class="month">Nov</span></div>
                    </div>
                    <figcaption>
                     <h5>  <asp:Label ID="lbl_AN5" runat="server" Text=""></asp:Label> </h5>
                      <p>  <asp:Label ID="lbl_AD5" runat="server" Text=""></asp:Label> </p>
                        <asp:LinkButton ID="LinkButton2" class="read-more"  runat="server" OnClick="Linkselect2_Click">Select</asp:LinkButton>&nbsp;&nbsp;
                        <asp:Label ID="lbl_AID5" runat="server" Visible="False"></asp:Label>

        

                    </figcaption>
                  </figure>
                </div>
            </div>
            <div class="col-sm">
              <div class="blog-item-box">
                <figure class="blog-item">
                    <div class="image">
                      <img src="images/sample12.jpg" alt="sample84"/>
                      <i class="fa fa-clock-o" aria-hidden="true"></i>
                      <div class="date"><span class="day">28</span><span class="month">Nov</span></div>
                    </div>
                    <figcaption>
                       
                      <h5> <asp:Label ID="lbl_AN6" runat="server" Text=""></asp:Label> </h5>
                      <p> <asp:Label ID="lbl_AD6" runat="server" Text=""></asp:Label></p>
                        <asp:LinkButton ID="LinkButton3" class="read-more"  runat="server" OnClick="Linkselect3_Click">Select</asp:LinkButton>&nbsp;&nbsp;
                        <asp:Label ID="lbl_AID6" runat="server" Text="Label" Visible="False"></asp:Label>

                    </figcaption>
                  </figure>
              </div>
            </div>
          </div>
        </div>
  </div>
</asp:Content>
