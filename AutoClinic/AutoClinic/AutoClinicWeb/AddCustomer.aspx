﻿<%@ Page Language="C#" AutoEventWireup="true" Inherits="AutoClinicWeb.AddCustomer" CodeBehind="AddCustomer.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Customer</title>
    <link rel="icon" type="image/ico" href="images/logos/autoclinic.png" />

	<meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1 shrink-to-fit=no" />

	<link rel="stylesheet" href="Content/bootstrap.min.css" />
	<link rel="stylesheet" href="css/main_css.css" />

    <!-- Jquery Script -->
    <script type="text/javascript" src="jquery/jquery.js" ></script>

	<script src="Scripts/jquery-3.0.0.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
	<script src="Scripts/popper.min.js"></script>

	
	<!-- Scrollbar Custom CSS -->
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css">

	<!-- Font Awesome JS -->
	<script defer src="https://use.fontawesome.com/releases/v5.0.13/js/solid.js" integrity="sha384-tzzSw1/Vo+0N5UhStP3bvwWPq+uvzCMfrN1fEFe+xBmv1C/AtVX5K0uZtmcHitFZ" crossorigin="anonymous"></script>
	<script defer src="https://use.fontawesome.com/releases/v5.0.13/js/fontawesome.js" integrity="sha384-6OIrr52G08NpOFSZdxxz1xdNSndlD4vdcf/q2myIUVO0VsqaGHJsB0RaBE01VTOY" crossorigin="anonymous"></script>
</head>
<body>
    <form id="frmAddCustomer" runat="server">
         <div class="wrapper">
			<!-- Sidebar -->
			<nav class="sidebar" id="sidebar">
				<div class="sidebarHeader">
					<h2>Menu</h2>
				</div>

				<!-- Sidebar Contents -->
				<ul class="list-unstyled components">
					<!-- Home -->
					<li>
						<a href="#">Home</a>
					</li>
					<!-- Customers -->
					<li>
						<a href="#customersSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Customers</a>
						<ul class="collapse list-unstyled" id="customersSubMenu">
							<li>
								<a href="RegisterCustomer.aspx">Register New Customer</a>
							</li>
							<li>
								<a href="CustomerEnquiries.aspx">Customer Enquiries</a>
							</li>
							<li>
								<a href="VehicleDetails.aspx">Manage Customer Vehicles</a>
							</li>
						</ul>
					</li>

					<!-- Bookings -->
					<li>
						<a href="#bookingsSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Bookings</a>
						<ul class="collapse list-unstyled" id="bookingsSubMenu">
							<li>
								<a href="ReceptionistBookings.aspx">Add New Booking</a>
							</li>
							<li>
								<a href="ViewBookings.aspx">View Bookings</a>
							</li>
						</ul>
					</li>

					<!-- Jobs -->
					<li>
						<a href="#jobsSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Jobs</a>
					</li>

					<!-- Quotes -->
					<li>
						<a href="#quotesSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Quotes</a>
					</li>

					<!-- Invoices -->
					<li>
						<a href="ReceptionistQuoutes.aspx" >Invoices</a>
					</li>
					<!-- My Account -->
					<li>
						<a href= "MyAccount.aspx" >My Account</a>
					</li>
					<!-- Help -->
					<li>
						<a href="#">Help</a>
					</li>
					<!-- Contact Us -->
					<li>
						<a href="ContactUs.aspx">Contact Us</a>
					</li>
					<!-- Logout -->
					<li>
						<a href="LoginPage.aspx">Logout</a>
					</li>
				</ul>
			</nav>
            <!-- Page Content -->
			<div class="content" id="content">
				<!-- Static Navbar -->
				<nav class="navbar navbar-expand-lg">
					<div class="container-fluid">
						<!-- Menu Button -->
						<button type="button" id="sidebarCollapse" class="btn btn-info" hidden="hidden">
							<i class="fas fa-align-left"></i>
							<span>Menu</span>
						</button>
						<button class="btn btn-dark d-inline-block d-lg-none ml-auto" type="button" data-toggle="collapse"
							data-target="#navbarSupportedContents" aria-controls="navbarSupportedContents" aria-expanded="false"
							aria-label="Toggle navigation">
							<i class="fas fa-align-justify"></i>
						</button>

						<!-- Navbar -->
						<div class="collapse navbar-collapse" id="navbarSupportedContents">
							<ul class="navbar-nav ml-auto">
								<li class="nav-item navItems">
									<div class="navIconContainer">
										<a class="nav-link" href="#">
											<img src="images/icons/help.png" class="navbarIcon" id="btnHelp" alt="Help Icon" />
											<span>Help</span>
										</a>
									</div>
								</li>
								<li class="nav-item navItems">
									<div class="navIconContainer">
										<a class="nav-link" href="ContactUs.aspx">
											<img src="images/icons/message.png" class="navbarIcon" id="btnMessage" alt="Contact Us Icon" />
											<span>Contact Us</span>
										</a>
									</div>
								</li>
								<li class="nav-item navItems">
									<div class="navIconContainer">
										<a class="nav-link" href="LoginPage.aspx">
											<img src="images/icons/logout.png" class="navbarIcon" id="btnLogout" alt="Logout Icon" />
											<span>Logout</span>
										</a>
									</div>
								</li>
							</ul>
						</div>
					</div>
				</nav>

				<!-- Heading -->
				<h1>Register Customer</h1>

				<!-- Page Body -->
				<div id="regForm" style="position:relative">
                    <!-- Fields for adding customer -->
                    <div runat="server" id="divUpdateCustomer">
                        <!-- Customer Information -->
                        <div runat="server" id="divCustomerInfo">
                            <h3 style="text-align:left; padding-bottom: 2em;">Customer Details</h3>
                            <!-- First Name -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtFirstName" Text="First Name:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtFirstName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqFirstName" ControlToValidate="txtFirstName" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </div>
                            <!-- Surname -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtSurname" Text="Surname:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtSurname" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqSurname" ControlToValidate="txtSurname" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </div>
                            <!-- Phone Number -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtPhoneNo" Text="Phone Number:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtPhoneNo" runat="server" TextMode="Phone"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqPhoneNo" ControlToValidate="txtPhoneNo" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </div>
                            <!-- Email -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtEmail" Text="Email Address:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqEmail" ControlToValidate="txtEmail" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <!-- Vehicle Info  -->
                        <div runat="server" id="divVehicleInfo">
                            <h3 style="text-align:left; padding-bottom: 2em;">Vehicle Details</h3>
                            <!-- Registration Number -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtRegNo" Text="Vehicle Registration:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtRegNo" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqRegNo" ControlToValidate="txtRegNo" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </div>
                            <!-- Make -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtMake" Text="Make:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtMake" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqMake" ControlToValidate="txtMake" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </div>
                            <!-- Model -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtModel" Text="Model:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtModel" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqModel" ControlToValidate="txtModel" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </div>
                            <!-- Year -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtYear" Text="Year:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtYear" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqYear" ControlToValidate="txtYear" ErrorMessage="*"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <!-- Update Button -->
                        <div>
                            <asp:Button ID="btnVehicleInfo" CssClass="mainButton" runat="server" Text="Vehicle Details" OnClick="btnVehicleInfo_Click"/>
                            <asp:Button ID="btnCustomerInfo" CssClass="mainButton" runat="server" Text="Customer Details" OnClick="btnCustomerInfo_Click"/>
                            <br />
                            <asp:Button ID="btnRegister" CssClass="mainButton" runat="server" Text="Register Customer" OnClick="btnRegister_Click"/>
                            <asp:Label ID="lblRegistrationSuccess" runat="server" AssociatedControlID="btnRegister" Text=" " ForeColor="White"></asp:Label>
                        </div>
                    </div>
				</div>
			</div>
		</div>
    </form>
    <!-- Sidebar code found on https://bootstrapious.com/p/bootstrap-sidebar -->

	<!-- jQuery CDN - Slim version (=without AJAX) -->
	<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
	<!-- Popper.JS -->
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js" integrity="sha384-cs/chFZiN24E4KMATLdqdvsezGxaGsi4hLGOzlXwp5UZB1LY//20VyM2taTB4QvJ" crossorigin="anonymous"></script>
	<!-- Bootstrap JS -->
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js" integrity="sha384-uefMccjFJAIv6A+rW+L4AHf99KvxDjWSu1z9VI8SKNVmz4sk7buKt/6v9KI65qnm" crossorigin="anonymous"></script>
	<!-- jQuery Custom Scroller CDN -->
	<script src="https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.concat.min.js"></script>

	<script type="text/javascript">
		$(document).ready(function () {
			$("#sidebar").mCustomScrollbar({
				theme: "minimal"
			});

			$('#sidebarCollapse').on('click', function () {
				$('#sidebar, #content').toggleClass('active');
				$('.collapse.in').toggleClass('in');
				$('a[aria-expanded=true]').attr('aria-expanded', 'false');
			});
		});
	</script>
</body>
</html>