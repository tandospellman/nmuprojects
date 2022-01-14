<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="AutoClinicWeb.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Password</title>

    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main_css.css" />

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <!-- Top Links -->
            <div class="row">
                <div class="col">
                    <nav class="navbar navbar-expand-lg">
                        <div class="collapse navbar-collapse" id="topLinks">
                            <ul class="navbar-nav ml-auto">
                                <li class="nav-item">
                                    <a class="nav-link" href="#">Help</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="ContactUs.aspx">Contact Us</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="LoginPage.aspx">Log In</a>
                                </li>
                            </ul>
                        </div>
                    </nav>
                </div>
            </div>

            <!-- Page Heading -->
            <div class="row">
                <div class="col">
                    <h1>Reset Password</h1>
                </div>
            </div>

            <!-- Page Body -->
            <div class="row">
                <!-- Logo -->
                <div class="col">
                    <div class="d-flex justify-content-center">
                        <img src="images/logos/autoclinic.png" class="img-fluid w-75 p-3" alt="AutoClinic.Exe Logo" />
                    </div>
                </div>
                
                <!-- Reset Information -->
                <div class="col form-group">
                    <div class="row">
                        <label>
                            Create a new password. <br />Then re-enter password to confirm your new password.
                        </label>
                    </div>
                    <div class="row">
                        <label for="txtPassword">New Password</label>
                        <input type="password" class="form-control textBox w-auto p-3" id="txtPassword" />
                    </div>
                    <div class="row">
                        <label for="txtConfirmPassword">Confirm New Password</label>
                        <input type="password" class="form-control textBox w-auto p-3" id="txtConfirmPassword" />
                    </div>
                    <!-- Reset Buttons -->
                    <div class="row">
                        <button type="submit" class="btn mainButton w-auto p-3">Confirm</button>
                        <button type="submit" class="btn secondaryButton w-auto p-3">Cancel</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
