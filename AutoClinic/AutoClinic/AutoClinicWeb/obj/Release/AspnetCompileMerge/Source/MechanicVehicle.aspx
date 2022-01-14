<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MechanicVehicle.aspx.cs" Inherits="AutoClinicWeb.Mechanic3" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main_css.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="wholePage">
           <div id="menu">
                <asp:ImageButton ID="menuIcon" CssClass="collapsible" runat="server" ImageUrl="~/images/icons/menu.png"/>  Menu
                
                <div id="menuContent">
                    <ul>
                        <li>
                            <asp:ImageButton ID="bookingsIcon"  CssClass="icon" ImageUrl="~/images/icons/bookings.png" runat="server" />  Bookings
                        </li>
                        <li>
                            <asp:ImageButton ID="jobsIcon" CssClass="icon" ImageUrl="~/images/icons/jobs.png" runat="server" />  Jobs
                        </li>
                        <li>
                            <asp:ImageButton ID="quotesIcon" CssClass="icon" ImageUrl="~/images/icons/quotes.png" runat="server" />  Quotes
                        </li>
                        <li>
                            <asp:ImageButton ID="myAccountIcon" CssClass="icon" ImageUrl="~/images/icons/myaccount.png" runat="server" />  My Account
                        </li>
                        <li>
                            <asp:ImageButton ID="helpIcon" CssClass="icon" ImageUrl="~/images/icons/help.png" runat="server" />  Help
                        </li>
                        <li>
                            <asp:ImageButton ID="logOutIcon" CssClass="icon" ImageUrl="~/images/icons/logout.png" runat="server" />  Log Out
                        </li>
                    </ul>
                </div>
           </div>

            <div id="pageHeading">
                <h1>Manage Customer Vehicles</h1>
            </div>

            <div id="searchbox">
                <div>
                    <asp:Label runat="server" Text="Search by: "></asp:Label>
                    <asp:DropDownList ID="customerSearchOptions" runat="server"></asp:DropDownList>
                </div>
                <div>
                    <asp:TextBox ID="txtSearch" CssClass="textBox" runat="server" Width="259px"></asp:TextBox>
                    <asp:Button ID="btnSearch" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Search" Width="88px" />
                </div>
            </div>

            <div id="resultsTable">
                <asp:DataGrid runat="server" ID="dgvCustomerList" Width="355px"></asp:DataGrid>
            </div>

            <div id="bottomButtons">
                <asp:Button ID="btnNew" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Add New Vehicle" />
                <asp:Button ID="btnView" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="View Vehicle Details" />
                <asp:Button ID="btnUpdate" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text ="Update Vehicle Details" />
            </div>

            <div class="footer">
                <asp:Label ID="lblLoggedInAs" runat="server" Text="Logged in as "></asp:Label>
                <asp:Image id="logo" ImageUrl="~/images/logos/autoclinic.png" runat="server" AlternateText="AutoClinic.Exe Logo" />
            </div>
        </div>
    </form>
</body>
</html>
