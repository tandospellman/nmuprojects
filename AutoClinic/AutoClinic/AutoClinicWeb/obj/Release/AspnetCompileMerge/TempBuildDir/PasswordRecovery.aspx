<%@ Page Language="C#" AutoEventWireup="True" Inherits="AutoClinicWeb.PasswordRecovery" Codebehind="PasswordRecovery.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
        <title>Password Reset</title>
        <link rel="icon" type="image/ico" href="images/logos/autoclinic.png" />

	    <meta charset="utf-8" />
	    <meta name="viewport" content="width=device-width, initial-scale=1 shrink-to-fit=no" />

	    <link rel="stylesheet" href="Content/bootstrap.min.css" />
	    <link rel="stylesheet" href="css/main_css.css" />

	    <script src="Scripts/jquery-3.0.0.min.js"></script>
	    <script src="Scripts/bootstrap.min.js"></script>
	    <script src="Scripts/popper.min.js"></script>
    </head>
    <body>
        <form id="form1" runat="server">
            <div class="wrapper">
                <!-- Page Content -->
                <div>
                    <!-- Static Navbar -->
                    <nav class="navbar navbar-expand-lg">
                        <div class="container-fluid">
                            <!-- Top Navbar -->
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
											    <span>Login</span>
										    </a>
									    </div>
								    </li>
                                </ul>
                            </div>
                        </div>
                    </nav>

                    <div id="divEmail">
                         <!--Heading-->
                        <div class="pageHeading">
                            <h1>Forgot password?</h1>
                        </div>
                        <p style="color: white;">Enter the email you registered with and we will send you a link to reset your password.</p>
                        <!-- Email Address -->
                        <div class="loginInputContainer">
                            <label for="txtEmail" runat="server">Email:</label>
                            <asp:TextBox runat="server" CssClass="textBox" ID="txtEmail" TextMode="Email"></asp:TextBox>
                            <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqEmail" ControlToValidate="txtEmail" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </div>

                        <!-- Send button -->
                        <div>
                            <br />
                            <asp:Button ID="btnSend" CssClass="mainButton" runat="server" Text="Send Email" OnClick="btnSend_Click"/>
                            <br />
                            <asp:Label ID="lblNotFound" runat="server" AssociatedControlID="btnSend" Text=" " ForeColor="Red"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </body>
</html>