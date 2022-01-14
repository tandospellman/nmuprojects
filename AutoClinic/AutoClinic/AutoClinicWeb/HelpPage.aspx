<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelpPage.aspx.cs" Inherits="AutoClinicWeb.HelpPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Help</title>
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
    <form id="frmHelpPage" runat="server">
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
				<h1>Help Page</h1>

				<!-- Page Body -->
				<div id="regForm" style="position:relative">
                    <div id="regForm" style="position:relative; text-align:left">
                        <!-- List For Help-->
                        <div>
                            <ol style="color:white">
                                <!-- Booking Help-->
                                <li><a href="#editBooking">Editting a Booking</a></li>
                                <li><a href="#createBooking">Create a new Booking</a></li>
                                <li><a href="#updateBooking">Update a Booking</a></li>
                                <li><a href="#viewBooking">View Bookings</a></li>
                                <li><a href="#viewBookingCustomer">View Booking of a Customer</a></li>
                                <li><a href="#viewBookingVehicle">View Booking for a Vehicle</a></li>
                                <!-- Job Help-->
                                <li><a href="#editJob">Editting a Job</a></li>
                                <li><a href="#createJob">Create a new Job</a></li>
                                <li><a href="#updateJob">Update a Job</a></li>
                                <li><a href="#assignMechanic">Assign a Mechanic to a Job</a></li>
                                <li><a href="#viewJob">View Jobs</a></li>
                                <li><a href="#viewJobMechanic">View Jobs for a Specified Mechanic</a></li>
                                <!-- Quote Help -->
                                <li><a href="#createQuote">Creating a new Quote</a></li>
                                <li><a href="#viewQuotes">View Quotes</a></li>
                            </ol>
                        </div>
                        <!-- Helps -->
                        <div>
                            <h3 id="editBooking">Edit Bookings</h3>
                            <img src="../images/Screenshots/Edit Booking Default.png" alt="EditBookingDefault" width="1000px" />
                            <p style="color:white">The Default page when Clicking on Add/Update Booking. Can choose whether to create a new booking or edit an already existing one.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="createBooking">Create Booking</h3>
                            <img src="../images/Screenshots/Edit Booking Add.png" alt="EditBookingAdd" width="1000px" />
                            <p style="color:white">To add a new Booking all the displayed fields need to have valid data entered and then the Add Booking button needs to be Clicked.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="updateBooking">Update a Booking</h3>
                            <img src="../images/Screenshots/Edit Booking Update.png" alt="UpdateBooking" width="1000px" />
                            <p style="color:white">When the user wishes to update a booking they can select the booking that they wish to Update and then fill in the required fields and Click the Update Booking button.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="viewBooking">View All Bookings</h3>
                            <img src="../images/Screenshots/View Booking All.png" alt="ViewAllBooking" width="1000px" />
                            <p style="color:white">When the user wants to see all the current bookings they just need to select the View All option from the Drop-Down List</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="viewBookingCustomer">View Booking of a Customer</h3>
                            <img src="../images/Screenshots/View Booking Customer.png" alt="ViewBookingCustomer" width="1000px" />
                            <p style="color:white">When the user wishes to view the Booking/s of a specific Customer they need to select the View by Customer Option first, then select the name of the Customer from the next Drop-Down List.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="viewBookingVehicle">View Booking of a Vehicle</h3>
                            <img src="../images/Screenshots/View Booking Vehicle.png" alt="ViewBookingVehicle" width="1000px" />
                            <p style="color:white">When the user wishes to view the Booking/s of a specific Vehicle they need to select the View by Vehicle Option first, then select the ID of the Vehicle from the next Drop-Down List.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                         <div>
                            <h3 id="editJob">Editting a Job</h3>
                            <img src="../images/Screenshots/Edit Job Default.png" alt="EditJob" width="1000px" />
                            <p style="color:white">A user will be presented with Three options when landing on this page: Add New Job, Update a Job, and Assign a Mechanic.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="createJob">Create a new Job</h3>
                            <img src="../images/Screenshots/Edit Job Add.png" alt="EditJobAdd" width="1000px" />
                            <p style="color:white">Once the user has selected Add New Job they will be required to fill in all the displayed fields, and click the Add Job button once done.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="updateJob">Updating a Job</h3>
                            <img src="../images/Screenshots/Edit Job Update.png" alt="EditJobUpdate" width="1000px" />
                            <p style="color:white">Once the user has selected Update a Job they will select the JobID of the job they wish to update, then fill in the remaining fields and click the Update Selected Job button.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="assignMechanic">Assign a Mechanic to a Job</h3>
                            <img src="../images/Screenshots/Edit Job Assign Mechanic.png" alt="EditJobAssignMechanic" width="1000px" />
                            <p style="color:white">Once the user has selected Assign Mechanic they will have to select the JobID and then the Mechnic name followed by clicking the Assign Mechanic to Job button.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="viewJob">View All Jobs</h3>
                            <img src="../images/Screenshots/View Job All.png" alt="ViewJobAll" width="1000px" />
                            <p style="color:white">The user will select View All from the Drop-Down List and a Grid will display all the currently active jobs.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="viewJobMechanic">View Jobs for a Specified Mechanic</h3>
                            <img src="../images/Screenshots/View Job Mechanic.png" alt="ViewJobMechanic" width="1000px" />
                            <p style="color:white">The user will select View Mechanic then follow up by selecting the name of the Mechanic which will display all the Jobs they are working on.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="createQuote">Create a new Quote</h3>
                            <img src="../images/Screenshots/Create Quote.png" alt="CreateQuote" width="1000px" />
                            <p style="color:white">For the user to create a new Quote they will have to fill in the displayed fields and click the Create Quote button.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
                        </div>
                        <div>
                            <h3 id="viewQuotes">View all active Quotes</h3>
                            <img src="../images/Screenshots/View Quotes All.png" alt="ViewQuoteAll" width="1000px" />
                            <p style="color:white">The user can select to View All from the Drop-Down List, which will display a Grid of all the quotes.</p>
                            <a href="#top" style="color:white"><u>Back To Top.</u></a>
                            <br />
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
