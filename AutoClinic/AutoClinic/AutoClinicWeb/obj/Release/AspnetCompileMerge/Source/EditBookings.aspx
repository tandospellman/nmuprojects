<%@ Page Language="C#" AutoEventWireup="True" Inherits="AutoClinicWeb.EditBookings" CodeBehind="EditBookings.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Booking</title>
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
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css"/>

	<!-- Font Awesome JS -->
	<script defer src="https://use.fontawesome.com/releases/v5.0.13/js/solid.js" integrity="sha384-tzzSw1/Vo+0N5UhStP3bvwWPq+uvzCMfrN1fEFe+xBmv1C/AtVX5K0uZtmcHitFZ" crossorigin="anonymous"></script>
	<script defer src="https://use.fontawesome.com/releases/v5.0.13/js/fontawesome.js" integrity="sha384-6OIrr52G08NpOFSZdxxz1xdNSndlD4vdcf/q2myIUVO0VsqaGHJsB0RaBE01VTOY" crossorigin="anonymous"></script>
</head>
<body style="overflow:scroll;">
    <form id="frmEditBooking" runat="server">
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
						<a href="Dashboard.aspx">Home</a>
					</li>
					<!-- Customers -->
					<li>
						<a href="#customersSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Customers</a>
						<ul class="collapse list-unstyled" id="customersSubMenu">
							<li>
								<a href="AddCustomer.aspx">Register New Customer</a>
							</li>
							<li>
								<a href="ViewCustomers.aspx">View Customers</a>
							</li>
							<li>
								<a href="EditCustomer.aspx">Update Customers</a>
							</li>
						</ul>
					</li>

                     <!-- Customers Actions -->
					<li>
						<a href="#customerActionsSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Customer Actions</a>
						<ul class="collapse list-unstyled" id="customerActionsSubMenu">
							<li>
								<a href="CustManageCehicles.aspx">Customer Manage Vehicle</a>
							</li>
							<li>
								<a href="CustEnquiries.aspx">View Quote</a>
							</li>
							<li>
								<a href="CustServiceHistory.aspx">Customer Service History</a>
							</li>
                            <li>
						        <a href= "MyAccount.aspx" >My Account</a>
					        </li>
						</ul>
					</li>

					<!-- Bookings -->
					<li>
						<a href="#bookingsSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Bookings</a>
						<ul class="collapse list-unstyled" id="bookingsSubMenu">
							<li>
								<a href="EditBookings.aspx">Add/Update Booking</a>
							</li>
							<li>
								<a href="ViewBookings.aspx">View Bookings</a>
							</li>
						</ul>
					</li>

					<!-- Jobs -->
					<li>
						<a href="#jobsSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Jobs</a>
                        <ul class="collapse list-unstyled" id="jobsSubMenu">
							<li>
								<a href="EditJobs.aspx">Add/Update Job</a>
							</li>
							<li>
								<a href="ViewJobs.aspx">View Jobs</a>
							</li>
						</ul>
					</li>
                    <!-- Mechanics -->
					<li>
						<a href="#mechanicsSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Mechanics</a>
                        <ul class="collapse list-unstyled" id="mechanicsSubMenu">
							<li>
								<a href="EditMechanic.aspx">Add/Update Mechanic</a>
							</li>
							<li>
								<a href="ViewMechanics.aspx">View Mechanics</a>
							</li>
						</ul>
					</li>

					<!-- Quotes -->
					<li>
						<a href="#quotesSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Quotes</a>
                        <ul class="collapse list-unstyled" id="quotesSubMenu">
							<li>
								<a href="EditQuote.aspx">Add Quote</a>
							</li>
							<li>
								<a href="ViewQuote.aspx">View Quote</a>
							</li>
						</ul>
					</li>

                    <!-- Vehicles -->
					<li>
						<a href="#vehiclesSubMenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Vehicles</a>
                        <ul class="collapse list-unstyled" id="vehiclesSubMenu">
							<li>
								<a href="AddVehicle.aspx">Add a Vehicle</a>
							</li>
							<li>
								<a href="EditVehicle.aspx">Update Vehicle</a>
							</li>
                            <li>
								<a href="ViewVehicles.aspx">View Vehicles</a>
							</li>
						</ul>
					</li>

                    <!-- Reports -->
					<li>
						<a href="ReportsPage.aspx">Reports</a>
					</li>

					<!-- Help -->
					<li>
						<a href="HelpPage.aspx">Help</a>
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
				<h1>Edit Booking</h1>

				<!-- Page Body -->
				<div id="regForm" style="position:relative">
                    <div>
                        <!-- Option buttons -->
                        <asp:Button ID="btnCreateNew" CssClass="mainButton" runat="server" Text="Add New Booking" OnClick="btnCreateNew_Click" />
                        <asp:Button ID="btnUpdateBooking" CssClass="mainButton" runat="server" Text="Update a Booking" OnClick="btnUpdateBooking_Click" />
                        <br />
                        <!-- Selecting a specific booking -->
                        <asp:DropDownList AutoPostBack="true" ID="ddlSelectBooking" CssClass="textBox" runat="server" OnSelectedIndexChanged="ddlSelectBooking_SelectedIndexChanged">
                            <asp:ListItem>Select a booking:</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <!-- Display for specific booking -->
                        <asp:GridView ID="dgvBookings" runat="server" AlternatingRowStyle-CssClass="gridAltRow" RowStyle-CssClass="gridRow" HeaderStyle-CssClass="gridHeader" CssClass="gridSearchTable" OnSelectedIndexChanged="dgvBookings_SelectedIndexChanged"></asp:GridView> 
                        <!-- Fields for adding a new booking -->
                        <div id="divNewBooking" runat="server" style="display:inline-block"> 
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="ddlCustomer" Text="Customer Name:"></asp:Label>
                                 <asp:DropDownList ID="ddlCustomer" CssClass="textBox" runat="server">
                                        <asp:ListItem Text="Select an option:"></asp:ListItem>
                                    </asp:DropDownList>
                            </div>                      
                            <div class="inputContainer">
                              <asp:Label runat="server" AssociatedControlID="ddlVehicle" Text="Vehicle Number:"></asp:Label>
                                  <asp:DropDownList ID="ddlVehicle" CssClass="textBox" runat="server">
                                       <asp:ListItem Text="Select an option:"></asp:ListItem>
                                    </asp:DropDownList>
                            </div>
                            <div class="inputContainer">
                              <asp:Label runat="server" AssociatedControlID="ddlService" Text="Service Type:"></asp:Label>
                                   <asp:DropDownList ID="ddlService" CssClass="textBox" runat="server">
                                       <asp:ListItem Text="Select an option:"></asp:ListItem>
                                    </asp:DropDownList>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtDateIn" Text="Date In:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtDateIn" runat="server" TextMode="Date"></asp:TextBox>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtComment" Text="Comment:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtComment" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="chkArrived" Text="Arrived:"></asp:Label>
                             <asp:CheckBox ID="chkArrived" CssClass="textBox" runat="server" />
                            </div>
                            <div>
                                <asp:Button ID="btnAdd" CssClass="mainButton" runat="server" Text="Add Booking" OnClick="btnAdd_Click" />                           
                            </div>
                        </div>
                        <div>
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="lblSuccess" runat="server" AssociatedControlID="btnAdd" Text=" " ForeColor="White"></asp:Label>
                            <br />
                            <asp:Button ID="btnContinue" CssClass="mainButton" runat="server" Text="Continue" OnClick="btnContinue_Click" />
                        </div>
                        <!-- Fields for updating a new booking -->
                        <div id="divUpdateBooking" runat="server" style="display:inline-block"> 
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="ddlCustomerUp" Text="Customer Name:"></asp:Label>
                                 <asp:DropDownList ID="ddlCustomerUp" CssClass="textBox" runat="server">
                                        <asp:ListItem Text="Select an option:"></asp:ListItem>
                                 </asp:DropDownList>
                                <asp:Label ID="lblCustomer" runat="server" AssociatedControlID="ddlCustomerUp" Text=""></asp:Label>
                            </div>                      
                            <div class="inputContainer">
                              <asp:Label runat="server" AssociatedControlID="ddlVehicleUp" Text="Vehicle Number:"></asp:Label>
                                  <asp:DropDownList ID="ddlVehicleUp" CssClass="textBox" runat="server">
                                       <asp:ListItem Text="Select an option:"></asp:ListItem>
                                    </asp:DropDownList>
                                <asp:Label ID="lblVehicle" runat="server" AssociatedControlID="ddlVehicleUp" Text=""></asp:Label>
                            </div>
                            <div class="inputContainer">
                              <asp:Label runat="server" AssociatedControlID="ddlServiceUp" Text="Service Type:"></asp:Label>
                                   <asp:DropDownList ID="ddlServiceUp" CssClass="textBox" runat="server">
                                       <asp:ListItem Text="Select an option:"></asp:ListItem>
                                    </asp:DropDownList>
                                <asp:Label ID="lblService" runat="server" AssociatedControlID="ddlServiceUp" Text=""></asp:Label>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtDateInUp" Text="Date In:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtDateInUp" runat="server" TextMode="Date"></asp:TextBox>
                                <asp:Label ID="lblDateIn" runat="server" AssociatedControlID="txtDateInUp" Text=""></asp:Label>
                            </div>

                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtDateOutUp" Text="Date Out:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtDateOutUp" runat="server" TextMode="Date"></asp:TextBox>
                                <asp:Label ID="lblDateOut" runat="server" AssociatedControlID="txtDateOutUp" Text=""></asp:Label>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtCommentUp" Text="Comment:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtCommentUp" runat="server" TextMode="MultiLine"></asp:TextBox>
                                <asp:Label ID="lblComment" runat="server" AssociatedControlID="txtCommentUp" Text=""></asp:Label>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="chkArrivedUp" Text="Arrived:"></asp:Label>
                             <asp:CheckBox ID="chkArrivedUp" CssClass="textBox" runat="server" />
                                <asp:Label ID="lblArrived" runat="server" AssociatedControlID="chkArrivedUp" Text=""></asp:Label>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="chkActiveUp" Text="Active:"></asp:Label>
                             <asp:CheckBox ID="chkActiveUp" CssClass="textBox" runat="server" />
                                <asp:Label ID="lblActive" runat="server" AssociatedControlID="chkActiveUp" Text=""></asp:Label>
                            </div>                           
                        </div>
                        <div>
                            <asp:Button ID="btnUpdate" CssClass="mainButton" runat="server" Text="Update Booking" OnClick="btnUpdate_Click" />  
                            <br />
                            <asp:Label ID="lblUpdateSuccess" runat="server" AssociatedControlID="btnUpdate" Text=" " ForeColor="White"></asp:Label>
                        </div>
                    </div>
                    <div>

                    </div>

                    <div>

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
