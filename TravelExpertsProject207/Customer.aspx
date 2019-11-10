<%@ Page Title="" Language="C#" MasterPageFile="~/Travel.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="TravelExpertsProject207.Customer" %>
 
<%@ MasterType VirtualPath="~/Travel.Master" %>
<%@ Import Namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

.feature-area
{
    background-color: #222;
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
						<h2>PACKAGE DETAILS</h2>
						<div class="page_link">
							<a href="Default.aspx">Home</a>
							 
						</div>
					</div>
				</div>
            </div>
        </section>
        <!--================End Home Banner Area =================-->
    <!-- Start top-course Area -->
			<section class="top-course-area section-gap" id="top-course">
				<div class="container">
					<div class="row d-flex justify-content-center">
						<div class="menu-content pb-70 col-lg-9">
							<div class="title text-center">
						 		</div>
                            <br />
                            <br />
						        </div>
					        </div>											
					    <div class="row">
				    </div>
				</div>	
			</section>
			<!-- End top-course Area -->
							

    		<!-- Start feature Area -->
			<section class="feature-area">
				<div class="container-fluid">
					<div class="row justify-content-center align-items-center">
						<div class="col-lg-3 feat-img no-padding">
							<img class="img-fluid" src="images/cus1.jpg" alt="">
						</div>
						<div class="col-lg-3 no-padding feat-txt" style="left: 0px; top: 0px; width: 95%">
	    				<H2>
                                <asp:Label ID="Label1" runat="server" Text="WELCOME" ForeColor="#CCCC00"></asp:Label>
                            </H2>
                            <H2> <asp:Label ID="LBLCUSTOMERWELCOME" runat="server" Width="500px" ForeColor="#CCCC00"></asp:Label> </H2>
							</div>
						<div class="col-lg-3 feat-img no-padding">
							<img class="img-fluid" src="images/Cus2.jpg" alt="">							
						</div>
						<div class="col-lg-3 no-padding feat-txt" style="left: 0px; top: 0px; width: 96%">


						    <H2><asp:Label ID="Label2" runat="server" Text="TOTAL TRIP PRICE" ForeColor="#CCCC00"></asp:Label></H2>
                            <H2> <asp:Label ID="LBLTOTLAPRICE" runat="server" Width="500px" ForeColor="#CCCC00"></asp:Label> </H2>
							</div>

					</div>
				</div>	
			</section>
			<!-- End feature Area -->
 



   <div>


       <table class="w-100">
           <tr>
               <td>
                   <!-- Start schedule Area -->
			<section class="schedule-area section-gap" id="schedule">
				<div class="container">
					<div class="row d-flex justify-content-center">
						 <h4>Here is your Package Details </h4>
					</div>						
					<div class="row">
						<div class="table-wrap col-lg-12" style="left: 0px; top: 0px">
					 <asp:DataGrid ID="DataGrid1" runat="server" PageSize="5" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" CssClass="auto-style1" Width="1100px" ShowFooter="True">  
                     <Columns>  
                        
                        <asp:BoundColumn DataField="BookingNo" HeaderText="BOOKING NO:"> <ItemStyle Width="100px"></ItemStyle></asp:BoundColumn>  
                        <asp:BoundColumn DataField="BookingDate" HeaderText="BOOK DATE"> <ItemStyle Width="100px"></ItemStyle></asp:BoundColumn>  
                        <asp:BoundColumn DataField="TravelerCount" HeaderText="TRAVEL COUNT"> <ItemStyle Width="100px"></ItemStyle></asp:BoundColumn>  
                        <asp:BoundColumn DataField="PackageName" HeaderText="PACKAGE NAME" ItemStyle-Width="150"><ItemStyle></ItemStyle></asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="START DATE" DataField="PkgStartDate"> <ItemStyle Width="100px"></ItemStyle></asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="END DATE" DataField="PkgEndDate"> <ItemStyle Width="100px"></ItemStyle></asp:BoundColumn>  
                        <asp:BoundColumn    DataField="PkgBasePrice" HeaderText="PRICE"> <ItemStyle Width="100px"></ItemStyle></asp:BoundColumn>  
                        <asp:BoundColumn DataField="PackageDesc" HeaderText="DESCRIPTION"> <ItemStyle Width="200px"></ItemStyle></asp:BoundColumn>  
                         
                    
                        <asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" HeaderText="Edit"> </asp:EditCommandColumn>  
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"> </asp:ButtonColumn>  
                    </Columns>  
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />  
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />  
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages" />  
                    <AlternatingItemStyle BackColor="White" />  
                    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />  
                    <HeaderStyle BackColor="#000066" Font-Bold="True" ForeColor="White" /> </asp:DataGrid>

						</div>
					</div>
				</div>	
			</section>
			<!-- End schedule Area -->

               </td>
           </tr>
       </table>


   </div>
     
     
         
</asp:Content>
