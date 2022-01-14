<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MechanicSchedule.aspx.cs" Inherits="AutoClinicWeb.Mechanic1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main_css.css"" />
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
                <h1>Mechanic Daily Schedule</h1>
            </div>

            <div id="searchbox">
                <div>
                    <asp:Label runat="server" Text="Search by: "></asp:Label>
                    <asp:DropDownList ID="customerSearchOptions" runat="server"></asp:DropDownList>
                </div>
                <div>
                    <asp:TextBox ID="txtSearch" CssClass="textBox" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSearch" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Search" />
                </div>
            </div>

            <div id="resultsTable">
                <asp:DataGrid runat="server" ID="dgvSchedule"></asp:DataGrid>
            </div>

            <div id="bottomButtons">
                <asp:Button ID="btnNew" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Update StartTime" />
                <asp:Button ID="btnView" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Update EndTime Booking" />
                <asp:Button ID="btnMechDate" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Change Date" />
                <asp:Button ID="btnCancel" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Add Notes" />
            </div>

            <div class="footer">
                <asp:Label ID="lblLoggedInAs" runat="server" Text="Logged in as "></asp:Label>
                <asp:Image id="logo" ImageUrl="~/images/logos/autoclinic.png" runat="server" AlternateText="AutoClinic.Exe Logo" />
            </div>
        </div>
    </form>
</body>
</html>
