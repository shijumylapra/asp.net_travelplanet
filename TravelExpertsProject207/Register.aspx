<%@ Page Title="" Language="C#" MasterPageFile="~/Travel.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" ViewStateMode="Disabled" Inherits="TravelExpertsProject207.Register" %>

 
<%@ MasterType VirtualPath="~/Travel.Master" %>
<%@ Import Namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script type="text/javascript">
function clearOnConfirm() {
    if (confirm("Are you sure you want to continue?")) {
        document.getElementById("<%=txtFirstName.ClientID %>").value = '';
        document.getElementById("<%=txtLastName.ClientID %>").value = ''
        document.getElementById("<%=txtCity.ClientID %>").value = ''
        document.getElementById("<%=txtEmail.ClientID %>").value = ''

        return true;
    } else {
        return false;
    }
}
</script>
        <style type="text/css">

        * Appointment Area css
======================================================================= */
.appointment-area .appointment-form {
  position: relative;
  z-index: 1; }
  .appointment-area .appointment-form label {
    display: block;
    color: #33363e;
    font-size: 16px;
    font-family: "Playfair Display", serif;
    margin-bottom: 10px; }
  .appointment-area .appointment-form input {
    display: block;
    width: 100%;
    border: 1px solid #e8edf1;
    height: 50px;
    padding: 0 15px; }
    .appointment-area .appointment-form input:focus {
      -webkit-box-shadow: none;
      -moz-box-shadow: none;
      box-shadow: none; }
  .appointment-area .appointment-form textarea {
    display: block;
    width: 100%;
    border: 1px solid #e8edf1;
    padding: 15px 15px;
    height: 150px;
    margin-bottom: 50px; }
  .appointment-area .appointment-form .form-group {
    margin-bottom: 25px; }
.appointment-area form {
  margin-top: 24px;
  display: inline-block;
  width: 100%; }
.appointment-area .card {
  border: none;
  border-radius: 0; }
  .appointment-area .card .card-header {
    border-radius: 0;
    border: none;
    background-color: #fff; }
  .appointment-area .card .card-header:first-child {
    border-radius: 0; }
  .appointment-area .card .btn-link.collapsed {
    border-bottom: 1px solid #e9ecef;
    font-weight: 400;
    color: #1d1d1d;
    font-size: 16px;
    width: 100%;
    text-align: left;
    box-shadow: none;
    white-space: normal;
    transition: all 300ms linear 0s; }
    .appointment-area .card .btn-link.collapsed:hover {
      text-decoration: none; }
    @media (max-width: 1199px) {
      .appointment-area .card .btn-link.collapsed {
        font-size: 14px; } }
  .appointment-area .card .card-body {
    font-weight: 300;
    font-size: 14px;
    line-height: 27px;
    background: #f7f7f7; }
  .appointment-area .card .card-header {
    padding: 0; }
  .appointment-area .card .btn-link {
    font-weight: 400;
    color: #1d1d1d;
    font-size: 16px;
    width: 100%;
    text-align: left;
    padding: 25px 0;
    white-space: normal;
    transition: all 300ms linear 0s; }
    .appointment-area .card .btn-link:hover {
      text-decoration: none; }
    @media (max-width: 1199px) {
      .appointment-area .card .btn-link {
        font-size: 14px; } }
.appointment-area h3 {
  font-size: 24px;
  color: #33363e;
  text-transform: capitalize;
  margin-bottom: 35px; }
.appointment-area .appointment-inner {
  padding: 65px 0;
  box-shadow: 3.517px -8.285px 30px 0px rgba(12, 58, 132, 0.15);
  background: #fff;
  z-index: 11;
  position: relative; }
  @media (max-width: 991px) {
    .appointment-area .appointment-inner {
      padding: 65px 30px; } }

@media (max-width: 1199px) {
  .appointment-inner .accordion {
    margin-bottom: 50px; } }
.appointment-area .card h5 .btn.collapsed::after {
  content: "\e61a";
  font-family: 'themify';
  font-style: normal;
  font-weight: normal;
  font-variant: normal;
  text-transform: none;
  line-height: 1;
  right: 6px;
  position: absolute;
  top: 30px; }
  @media (max-width: 600px) {
    .appointment-area .card h5 .btn.collapsed::after {
      display: none; } }

.appointment-area .card h5 .btn::after {
  content: "\e622";
  font-family: 'themify';
  font-style: normal;
  font-weight: normal;
  font-variant: normal;
  text-transform: none;
  line-height: 1;
  right: 6px;
  position: absolute;
  top: 30px; }
  @media (max-width: 600px) {
    .appointment-area .card h5 .btn::after {
      display: none; } }

/*---------------------------------------------------- */
    </style>

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
     <!--================Furniture Area =================-->
        
        	<div class="container">
        		<div class="main_title"><br /><br />
        			<h2>Customer Registration</h2>
        		   		</div>
        	</div>
        
        <!--================End Furniture Area =================-->
 
     <!--================Impress Area =================-->
        <section class="impress_area p_120">
        	<div class="container">
        		<div class="impress_inner text-center">
					<h4> <asp:Label ID="lblPackageText" runat="server" Font-Size="XX-Large"></asp:Label>  </h4>
        		     <h3> <asp:Label ID="lblPackageText2" runat="server" Font-Size="X-Large"></asp:Label> </h3>
					<a class="main_btn" href="#">&nbsp;Details</a>
        		</div>
        	</div>
        </section>
        <!--================End Impress Area =================-->
        
        
           <!--================ appointment Area Starts =================-->
    <section class="appointment-area">
        <div class="container">

            <div class="appointment-inner" style="left: 0px; top: 1px">
                <div class="row">
                    <div class="col-sm-12 col-lg-5 offset-lg-1">
 
                          <h3>Register Here</h3>
                          <asp:TextBox ID="txtFirstName" AutoCompleteType="disabled"  class="form-control" runat="server" placeholder="First Name" ></asp:TextBox> 
            
                            <div class="form-group">
                              </div>
                          <asp:TextBox ID="txtLastName" AutoCompleteType="disabled"  class="form-control" runat="server" placeholder="Last Name" required="required" ></asp:TextBox>

                <div class="form-group">
                    </div>
                                <div class="form-group">
                                  <asp:TextBox ID="txtCity" AutoCompleteType="disabled"    class="form-control" runat="server" placeholder="City" required="required" ></asp:TextBox>
                                </div>

                         
                <div class="form-group">
                <asp:TextBox ID="txtPostalcode"   AutoCompleteType="disabled"  class="form-control" runat="server" placeholder="Postal Code" required="required" ></asp:TextBox>
                </div>
                            
                    <div class="form-group">
                      <asp:TextBox ID="txtCountry"   AutoCompleteType="disabled"  class="form-control" runat="server" placeholder="Country" required="required" ></asp:TextBox>
                    </div>

                            <div class="form-group">
                            <asp:TextBox ID="txtContact"   AutoCompleteType="disabled"  class="form-control" runat="server" placeholder="Contact Number" required="required" ></asp:TextBox>
                            </div>

                                    <div class="form-group">
                                    <asp:TextBox ID="txtEmail" AutoCompleteType="disabled"  TextMode="Email" class="form-control" runat="server" placeholder="Email Address" required="required" ></asp:TextBox>
                                    </div>

                            <div class="form-group">
                            <asp:TextBox ID="txtPassword1" TextMode="Password" AutoCompleteType="disabled"  class="form-control" runat="server" placeholder="Password" required="required" ></asp:TextBox>
                            </div>
 
                            <div class="form-group">
                            <asp:TextBox ID="txtPassword2"  TextMode="Password" AutoCompleteType="disabled"  class="form-control" runat="server" placeholder="Confirm Password" required="required" ></asp:TextBox>
                            </div>
                  
                                    
                        <asp:Button ID="Button1" class="main_btn" runat="server" OnClick="Button1_Click" Text="Save Data" />&nbsp&nbsp
                        <asp:Button ID="Button2" class="main_btn" runat="server" Text="Clear" Width="172px" onclientclick="return clearOnConfirm()  " OnClick="Button2_Click1" /><br /><br />

                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblerror" runat="server" Text=" dddd" Font-Names="Castellar" Font-Size="Large" ForeColor="Blue" Width="400px"></asp:Label>
                      </div>
                    <div class="col-lg-5">
                        <div class="appointment-form">
                             <img class="card-img rounded-0" src="img/blog/home-blog/home-blog-1.jpg" alt="">
                        </div>
                    </div>
                </div>

            </div>


        </div>
    </section>
    <!--================ appointment Area End =================-->

        

</asp:Content>
