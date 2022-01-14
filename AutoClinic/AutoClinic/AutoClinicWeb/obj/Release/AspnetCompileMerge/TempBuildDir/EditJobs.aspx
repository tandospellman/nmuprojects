<%@ Page Language="C#" AutoEventWireup="True" Inherits="AutoClinicWeb.EditJobs" Codebehind="EditJobs.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Jobs</title>
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
    <form id="frmEditJobs" runat="server">
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
				<h1>Edit Job</h1>

				<!-- Page Body -->
				<div id="regForm" style="position:relative">
                    <div>
                        <!-- Option buttons -->
                        <asp:Button ID="btnCreateNew" CssClass="mainButton" runat="server" Text="Add New Job" OnClick="btnCreateNew_Click" />
                        <asp:Button ID="btnUpdateJob" CssClass="mainButton" runat="server" Text="Update a Job" OnClick="btnUpdateBooking_Click" />
                        <asp:Button ID="btnAssignMechanic" CssClass="mainButton" runat="server" Text="Assign a Mechanic" OnClick="btnAssignMechanic_Click" />
                        <br />
                        <br />
                        <!-- Elements needed to add a job -->
                        <div id="divAddJob" runat="server">
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="ddlVehicle" Text="Vechicle Number:"></asp:Label>
                                <asp:DropDownList ID="ddlVehicle" CssClass="textBox" runat="server"></asp:DropDownList>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="ddlBooking" Text="Booking Number:"></asp:Label>
                                <asp:DropDownList ID="ddlBooking" CssClass="textBox" runat="server"></asp:DropDownList>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtDateIn" Text="Date In:"></asp:Label>
                                <asp:TextBox CssClass="textBox" ID="txtDateIn" runat="server" TextMode="Date"></asp:TextBox>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtNotes" Text="Notes:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtNotes" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="ddlPaymentType" Text="Payment Type:"></asp:Label>
                                <asp:DropDownList ID="ddlPaymentType" CssClass="textBox" runat="server">
                                    <asp:ListItem>Select a Payment Type:</asp:ListItem>
                                    <asp:ListItem>EFT</asp:ListItem>
                                    <asp:ListItem>Cash</asp:ListItem>
                                    <asp:ListItem>Credit</asp:ListItem>
                                    <asp:ListItem>Check</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="chkPayed" Text="Payment Made:"></asp:Label>
                             <asp:CheckBox ID="chkPayed" CssClass="textBox" runat="server" />
                            </div>
                            <div>
                                <asp:Button ID="btnAdd" CssClass="mainButton" runat="server" Text="Add Job" OnClick="btnAdd_Click" />                           
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
                        <!-- fields to update job -->
                        <div id="divUpdateJob" runat="server" style="display:inline-block"> 
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="ddlJobID" Text="Job ID:"></asp:Label>
                                 <asp:DropDownList ID="ddlJobID" CssClass="textBox" runat="server">
                                        <asp:ListItem Text="Select an option:"></asp:ListItem>
                                 </asp:DropDownList>
                                <asp:Label ID="lblJobID" runat="server" AssociatedControlID="ddlJobID" Text=""></asp:Label>
                            </div>                                             
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtDateOut" Text="Date Completed:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtDateOut" runat="server" TextMode="Date"></asp:TextBox>
                                <asp:Label ID="lblDateOut" runat="server" AssociatedControlID="txtDateOut" Text=""></asp:Label>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="txtNotesUp" Text="Notes:"></asp:Label>
                                <asp:TextBox CssClass="textBox" id="txtNotesUp" runat="server" TextMode="MultiLine" ></asp:TextBox>
                                <asp:Label ID="lblNotes" runat="server" AssociatedControlID="txtNotesUp" Text=""></asp:Label>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="chkPaymentStatusUp" Text="Payment Made:"></asp:Label>
                             <asp:CheckBox ID="chkPaymentStatusUp" CssClass="textBox" runat="server" />
                                <asp:Label ID="lblPaymentStatus" runat="server" AssociatedControlID="chkPaymentStatusUp" Text=""></asp:Label>
                            </div>
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="chkJobStatus" Text="Job Completed:"></asp:Label>
                             <asp:CheckBox ID="chkJobStatus" CssClass="textBox" runat="server" />
                                <asp:Label ID="lblStatus" runat="server" AssociatedControlID="chkJobStatus" Text=""></asp:Label>
                            </div>                           
                        </div>
                        <div>
                            <asp:Button ID="btnUpdateSelectedJob" CssClass="mainButton" runat="server" Text="Update Selected Job" OnClick="btnUpdateSelectedJob_Click" />
                            <br />
                            <asp:Label ID="lblUpdateSuccess" runat="server" AssociatedControlID="btnUpdateSelectedJob" Text=" " ForeColor="White"></asp:Label>
                        </div>
                        <!-- fields to assign a mchanic -->
                        <div id="divAssignMech" runat="server" style="display:inline-block"> 
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="ddlJobIDMech" Text="Job ID:"></asp:Label>
                                 <asp:DropDownList ID="ddlJobIDMech" CssClass="textBox" runat="server">
                                        <asp:ListItem Text="Select the Job ID:"></asp:ListItem>
                                 </asp:DropDownList>
                            </div>                                             
                            <div class="inputContainer">
                                <asp:Label runat="server" AssociatedControlID="ddlMechanicToJob" Text="Mechanic:"></asp:Label>
                                 <asp:DropDownList ID="ddlMechanicToJob" CssClass="textBox" runat="server">
                                        <asp:ListItem Text="Select a Mechanic:"></asp:ListItem>
                                 </asp:DropDownList>
                            </div>   
                        </div>
                        <div>
                            <asp:Button ID="btnAssignMechJob" CssClass="mainButton" runat="server" Text="Assign Mechanic to Job" OnClick="btnAssignMechJob_Click" />
                            <br />
                            <asp:Label ID="lblSuccessAssign" runat="server" AssociatedControlID="btnAssignMechJob" Text=" " ForeColor="White"></asp:Label>
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
