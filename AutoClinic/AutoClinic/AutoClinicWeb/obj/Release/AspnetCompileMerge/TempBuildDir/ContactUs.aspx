<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="AutoClinicWeb.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Us</title>

    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main_css.css" />

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <nav class="navbar navbar-expand-lg" style="background-color: #09101E;">
                        <div class="collapse navbar-collapse" id="topLinks">
                            <ul class="navbar-nav ml-auto">
                               <li class="nav-item">
                                   <asp:HyperLink runat="server" CssClass="nav-link" NavigateUrl="LoginPage.aspx" Text="Log In"></asp:HyperLink>
                               </li>
                               <li class="nav-item">
                                   <a class="nav-link" href="#">Help</a>
                               </li>
                            </ul>
                        </div>
                    </nav>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <h1>Have some questions?</h1>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="d-flex justify-content-center">
                        <img src="images/icons/message.png" class="img-fluid w-50 p-3" alt="Message Icon" />
                    </div>
                </div>

                <div class="col">
                    <div class="row">
                        <div class="form-group">
                            <div class="col-xs-4">
                                <label for="txtFirstName">First Name</label>
                                <input type="text" class="form-control  w-auto p-3" id="txtFirstName" aria-describedby=""/>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="form-group">
                            <div class="col-xs-6">
                                <label for="txtLastName">Last Name</label>
                                <input type="text" class="form-control w-auto p-3" id="txtLastName" aria-describedby=""/>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-6">
                            <div class="form-group">
                                <label for="txtEmail">Email Address</label>
                                <input type="email" class="form-control w-auto p-3" id="txtEmail" aria-describedby=""/>
                            </div> 
                        </div>
                    </div>
                    
                    <div class="row">
                        <div class="form-group">
                            <div class="col-xs-6">
                                <label for="txtQuestions">Questions</label>
                                <textarea class="form-control w-auto p-3" id="txtQuestions"></textarea>
                            </div> 
                        </div>
                    </div>
                    <div class="row">
                        <button type="submit" class="btn btn-primary mainButton w-auto p-3">Submit</button>
                    </div>
                </div>
            </div>

            <div class="row">
                <label id="lblContactDetails">27 Chamberlain Road,<br />Berea, East London, 5241<br />
                    <br /> enquries@autoclinicexe.co.za<br />043 145 3225</label>
            </div>
            <div class="row">
                <img src="images/logos/autoclinic.png" class="img-fluid w-25 p-3" alt="AutoClinic.Exe Logo" />
            </div>
        </div>
    </form>
</body>
</html>
