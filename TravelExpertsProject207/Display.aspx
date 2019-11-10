<%@ Page Title="" Language="C#" MasterPageFile="~/Travel.Master" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="TravelExpertsProject207.Display" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
      .blog-view-box {
    background: #3a0057 none repeat scroll 0 0;
    border-radius: 15px;
    color: #fff;
    margin-top: -15px;
    padding: 15px 110px;
}
.blog-view-box .media-body {
    vertical-align: middle;
}
.blog-view-box .media-body h3 {
    font-weight: 600;
    letter-spacing: 1px;
}
.blog-box {
    background: #000 none repeat scroll 0 0;
    color: #fff;
    padding: 45px 110px;
    border-radius: 15px 15px 0 0;
}
.blog-box p::before {
    content: url("../images/icons/left-quotes-sign.png");
    left: 0;
    position: absolute;
    top: 0;
}
.blog-box p::after {
    content: url("../images/icons/left-quotes-sign.png");
    right: 0;
    position: absolute;
    bottom:  0;
    transform: scaleX(-1);
}
.blog-box > p {
    padding: 0 40px;
    position: relative;
}
.blog-box > p {
    font-size: 18px;
    font-style: italic;
    letter-spacing: 2px;
    line-height: 30px;
    padding: 0 40px;
    position: relative;
    text-align: center;
    padding-top: 10px;
    padding-bottom: 10px;
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
						<h2>PACKAGES</h2>
						<div class="page_link">
							<a href="Default.aspx">Home</a>
							 
						</div>
					</div>
				</div>
            </div>
        </section>
         <div class="container">
        		<div class="main_title"><br /><br />
        			<h2></h2>
        		   		</div>
        	 
        	</div>
        <!--================End Home Banner Area =================-->
         <!-----blog slider----->
            <!--blog trainer block-->
            <section class="blog-block-slider">
                <div class="blog-block-slider-fix-image">
                    <div id="myCarousel2" class="carousel slide" data-ride="carousel">
                        <div class="container">
                           
                            <div class="carousel-inner" role="listbox">
                                <div class="item active">
                                    <div class="blog-box">
                                        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/sara1.jpg" Height="432px" Width="741px" />
                                      </div>
                                    <div class="blog-view-box">
                                        <div class="media">
                                            <div class="media-left">
                                                
                                            </div>
                                            <div class="media-body">
                                                <h3>
                                                    <asp:Label ID="lblpckname" runat="server"></asp:Label>
                                                </h3>
                                                <h5 class="blog-rev">Travel Count        <asp:DropDownList ID="DropDownList1" runat="server">
                                                        <asp:ListItem>1</asp:ListItem>
                                                        <asp:ListItem>2</asp:ListItem>
                                                        <asp:ListItem>3</asp:ListItem>
                                                        <asp:ListItem>4</asp:ListItem>
                                                        <asp:ListItem>5</asp:ListItem>
                                                        <asp:ListItem>6</asp:ListItem>
                                                        <asp:ListItem>7</asp:ListItem>
                                                        <asp:ListItem>8</asp:ListItem>
                                                        <asp:ListItem>9</asp:ListItem>
                                                        <asp:ListItem>10</asp:ListItem>
                                                    </asp:DropDownList><br /><br /><h5>
                                &nbsp;<asp:LinkButton ID="linkpackagecontinue"  class="main_btn"  runat="server" OnClick="linkpackagecontinue_Click" BorderStyle="Double">Continue</asp:LinkButton> <br />

  
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                           
                            </div>
                        </div>
                    </div>
                </div>
                 
            </section>
    <br />
    <br />
     <br />
</asp:Content>
