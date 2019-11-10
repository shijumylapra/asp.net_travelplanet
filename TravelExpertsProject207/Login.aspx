<%@ Page Title="" Language="C#" MasterPageFile="~/Travel.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TravelExpertsProject207.Login" %>
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
						<h2>LOGIN</h2>
						<div class="page_link">
							<a href="Default.aspx">Home</a>
							 
						</div>
					</div>
				</div>
            </div>
        </section>
        <!--================End Home Banner Area =================-->
    <div class="container">
        		<div class="main_title"><br /><br />
        			<h2></h2>
        		   		</div>
        	 
        	</div>
     <!--================Login Area =================-->
 
       <section class="appointment-area">
        <div class="container">

            <div class="appointment-inner" style="left: 0px; top: 1px">
                <div class="row">
                    <div class="col-sm-12 col-lg-5 offset-lg-1">
               
                          <h3>Sign In to my Account</h3>
              
                                <div class="form-group">
                                <label for="name">Username</label>
                                <asp:TextBox ID="TextUserName"   AutoCompleteType="disabled"  class="form-control" placeholder="name@email.com" runat="server"></asp:TextBox>
                                </div>
                            
                                <div class="form-group">
                                <label for="name">Password</label>
                                                    
                                 <asp:Label ID="lblPackageId" Visible="false" runat="server" Text="Label"></asp:Label>
                                 <asp:TextBox ID="TextPassword"  AutoCompleteType="disabled"  class="form-control" placeholder="********" runat="server"></asp:TextBox>
                                </div>
                                <asp:Button ID="BtnLoginSave" class="main_btn" runat="server" OnClick="BtnLoginSave_Click" Text="Sign in" />&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:HyperLink ID="HyperLink1" runat="server">Forgot password?</asp:HyperLink>&nbsp;&nbsp;&nbsp;
                                
                                 
                         <asp:Label ID="lblerrorlogin" runat="server" Text=" " Font-Names="Castellar" Font-Size="Large" ForeColor="Blue" Width="400px"></asp:Label>
    
                        &nbsp;
                        &nbsp;
                         &nbsp; &nbsp;
                    </div>
                    <div class="col-lg-5">
                        <div class="appointment-form">
                             &nbsp;
                             &nbsp;
                             <img class="card-img rounded-0" src="images/login1.jpg" alt="">
                        </div>
                    </div>
                </div>

            </div>


        </div>
    </section>
     
</asp:Content>
