<%@ Page Language="C#" AutoEventWireup="true" Inherits="AutoClinicWeb.LoginPage" CodeBehind="LoginPage.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
        <title>Login</title>
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
                                </ul>
                            </div>
                        </div>
                    </nav>

                    <!--Heading-->
                    <div class="pageHeading">
                        <h1>Login</h1>
                    </div>

                    <div>
                        <!-- AutoClinic Logo -->
                        <div class="d-flex justify-content-center logoContainer">
                            <img src="images/logos/autoclinic.png" class="img-fluid w-75 p-3" alt="AutoClinic.Exe Logo" />
                        </div>

                        <!-- Login Fields -->
                        <div class="elementsContainer justify-content-center">
                            <!-- Error Label -->
                            <div id="divErrorLabel" runat="server" visible="true">
                                <asp:Label runat="server" ID="lblerrorLabel" ForeColor="Red" Text=" "></asp:Label>
                            </div>

                            <!-- Username -->
                            <div class="loginInputContainer">
                                <label runat="server" for="txtUsername" >Username</label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtUsername" ></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator runat="server" ID="reqUsername" ControlToValidate="txtUsername" ErrorMessage="Please enter username!" CssClass="errorMessage"></asp:RequiredFieldValidator>
                            </div>

                            <!-- Password -->
                            <div class="loginInputContainer">
                                <label for="txtPassword" runat="server">Password</label>
                                <asp:TextBox runat="server" CssClass="textBox" ID="txtPassword" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator CssClass="errorMessage" runat="server" ID="reqPassword" ControlToValidate="txtPassword" ErrorMessage="Please enter password!"></asp:RequiredFieldValidator>
                            </div>
                            
                            <!-- Customer ID -->
                            <asp:TextBox runat="server" CssClass="textBox" ID="txtCustomerID" Visible="False"></asp:TextBox>
                            <!-- Employee ID -->
                            <asp:TextBox runat="server" CssClass="textBox" ID="txtEmployeeID" Visible="False"></asp:TextBox>

                            <!-- Remember Username -->
                            <div class="loginPageText">
                                <asp:CheckBox ID="chkRememberMe" CssClass="textBox form-check-input" runat="server" Text="Remember username" />
                            </div>
                            <br />
                            <br />
                            <br />
                            <!-- Login Button -->
                            <div>
                                <asp:Label ID="lblLogin" runat="server" AssociatedControlID="btnLogin" Text=" " ForeColor="Red"></asp:Label>
                                <br />
                                <asp:Button ID="btnLogin" runat="server" Text="Log in" CssClass="mainButton" OnClick="btnLogin_Click" />
                            </div>
                            <!-- Forgot Password -->
                            <div class="loginPageText lnkButton" >
                                <a id="lnkForgottenPassword" style="" href="ResetPassword.aspx" >Forgotten your password?</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </body>
</html>