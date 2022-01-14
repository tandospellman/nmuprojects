<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustRegister.aspx.cs" Inherits="AutoClinicWeb.CustRegister" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Register Customer</title>
	<link rel="icon" type="image/ico" href="images/logos/autoclinic.png" />

	<meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1 shrink-to-fit=no" />

	<link rel="stylesheet" href="Content/bootstrap.min.css" />
	<link rel="stylesheet" href="css/main_css.css" />

	<script src="Scripts/jquery-3.0.0.min.js"></script>
	<script src="Scripts/bootstrap.min.js"></script>
	<script src="Scripts/popper.min.js"></script>

	<!-- Jquery Script -->
    <script type="text/javascript" src="jquery/jquery.js" ></script>

	<!-- Scrollbar Custom CSS -->
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css">

	<!-- Font Awesome JS -->
	<script defer src="https://use.fontawesome.com/releases/v5.0.13/js/solid.js" integrity="sha384-tzzSw1/Vo+0N5UhStP3bvwWPq+uvzCMfrN1fEFe+xBmv1C/AtVX5K0uZtmcHitFZ" crossorigin="anonymous"></script>
	<script defer src="https://use.fontawesome.com/releases/v5.0.13/js/fontawesome.js" integrity="sha384-6OIrr52G08NpOFSZdxxz1xdNSndlD4vdcf/q2myIUVO0VsqaGHJsB0RaBE01VTOY" crossorigin="anonymous"></script>
</head>
<body>
	<form id="form1" runat="server">
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
								<a href="ReceptionistEditBooking.aspx">View Bookings</a>
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
						<button type="button" id="sidebarCollapse" class="btn btn-info" hidden="hidden" >
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
				<div id="regForm">
					<!-- Progress Bar -->
					<div class="progBar">
                        <ul id="progressBar" class="list-unstyled">
						    <li class="active">Personal Details</li>
						    <li>Address Details</li>
						    <li>Vehicle Details</li>
					    </ul>
					</div>

                    <!-- Personal Details -->
                    <fieldset>
                        <h2 class="fsTitle">Create your account</h2>
                        <h3 class="fsSubtitle">This is step 1</h3>
                        <div>
                            <!-- First Name -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtFirstName" Text="First Name"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtFirstName"></asp:TextBox>
                            </div>
                            <!-- Surname -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtSurname" Text="Surname"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtSurname"></asp:TextBox>
                            </div>
                            <!-- Gender -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="cmbGender" Text="Gender"></asp:Label>
                                <asp:DropDownList runat="server" CssClass="textBox" ID="cmbGender">
                                    <asp:ListItem Text="Select a Gender..."></asp:ListItem>
                                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <!-- Date of Birth -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtDOB" Text="Date of Birth"></asp:Label>
                                <asp:TextBox TextMode="Date" runat="server" ID="txtDOB" CssClass="textBox"></asp:TextBox>
                            </div>
                            <!-- ID Number -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtIDNum" Text="ID Number"></asp:Label>
                                <asp:TextBox runat="server" ID="txtIDNum" CssClass="textBox"></asp:TextBox> <!-- pattern="[0-9]{13}" -->
                            </div>
                            <!-- Phone Number -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtPhoneNum" Text="Phone Number"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtPhoneNum" TextMode="Phone"></asp:TextBox> <!-- pattern="[0-9]{3}-[0-9]{3}-[0-9]{4}" -->
                            </div>
                            <!-- Email Address -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtEmailAdd" Text="Email Address"></asp:Label>
                                <asp:TextBox runat="server" ID="txtEmailAdd" CssClass="textBox" TextMode="Email"></asp:TextBox>
                            </div>
                        </div>

                        <!-- Navigation Buttons -->
                        <div>
                            <asp:Button ID="btnNext1" CssClass="mainButton" runat="server" Text="Next" />
                        </div>
                    </fieldset>

                    <!-- Address Details -->
                    <fieldset>
                        <h2 class="fsTitle">Enter your address details</h2>
                        <h3 class="fsSubtitle">This is step 2</h3>
                        <div>
                            <!-- Address Line 1 -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtAddLine1" Text="Address Line 1"></asp:Label>
                                <asp:TextBox runat="server" CssClass=" next textBox" ID="txtAddLine1"></asp:TextBox>
                            </div>
                            <!-- Address Line 2 -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtAddLine2" Text="Address Line 2"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtAddLine2"></asp:TextBox>
                            </div>
                            <!-- Suburb -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtSuburb" Text="Suburb"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtSuburb"></asp:TextBox>
                            </div>
                            <!-- City -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtCity" Text="City"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtCity"></asp:TextBox>
                            </div>
                            <!-- Province -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtProvince" Text="Province"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtProvince"></asp:TextBox>
                            </div>
                            <!-- Postal Code -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtPostalCode" Text="Postal Code"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtPostalCode"></asp:TextBox>
                            </div>
                        </div>

                        <!-- Navigation Buttons -->
                        <div>
                            <asp:Button ID="btnNext2" CssClass="next mainButton" runat="server" Text="Next" />
                            <asp:Button ID="btnPrevious1" CssClass="previous mainButton" runat="server" Text="Previous" />
                        </div>
                    </fieldset>

                    <!-- Vehicle Details -->
                    <fieldset>
                        <h2 class="fsTitle">Enter you vehicle details</h2>
                        <h3 class="fsSubtitle">This is step 3</h3>
                        <div>
                            <!-- Registration Number -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtRegNum" Text="Registration Number"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtRegNum"></asp:TextBox>
                            </div>
                            <!-- VIN Number -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtVINNum" Text="VIN Number"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtVINNum"></asp:TextBox>
                            </div>
                            <!-- Make -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControl="txtMake" Text="Make"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtMake"></asp:TextBox>
                            </div>
                            <!-- Model -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtModel" Text="Model"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtModel"></asp:TextBox>
                            </div>
                            <!-- Year -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtYear" Text="Year"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtYear"></asp:TextBox>
                            </div>
                            <!-- Colour -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtColour" Text="Colour"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtColour"></asp:TextBox>
                            </div>
                            <!-- Engine Type -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="cmbEngineType" Text="Engine Type"></asp:Label>
                                <asp:DropDownList runat="server" CssClass="textBox" ID="cmbEngineType">
                                    <asp:ListItem Text="Select Engine Type..."></asp:ListItem>
                                    <asp:ListItem Text="Diesel" Value="Diesel"></asp:ListItem>
                                    <asp:ListItem Text="Electric" Value="Electric"></asp:ListItem>
                                    <asp:ListItem Text="Hybrid" Value="Hybrid"></asp:ListItem>
                                    <asp:ListItem Text="Petrol" Value="Petrol"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <!-- Transmission Type -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="cmbTransmissionType" Text="Transmission Type"></asp:Label>
                                <asp:DropDownList runat="server" CssClass="textBox" ID="cmbTransmissionType">
                                    <asp:ListItem Text="Select Transmission Type..."></asp:ListItem>
                                    <asp:ListItem Text="Automatic" Value="Automatic"></asp:ListItem>
                                    <asp:ListItem Text="Manual" Value="Manual"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <!-- Mileage -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtMileage" Text="Mileage"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtMileage"></asp:TextBox>
                            </div>
                            <!-- Last Service Date -->
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtLastServiceDate" Text="Last Service Date"></asp:Label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtLastServiceDate" TextMode="Date"></asp:TextBox>
                            </div>
                        </div>

                        <!-- Navigation Buttons -->
                        <div>
                            <asp:Button ID="btnPrevious2" CssClass="next mainButton" runat="server" Text="Next" />
                            <asp:Button ID="btnSubmit" CssClass="submit mainButton" runat="server" Text="Submit" />
                        </div>
                    </fieldset>
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
