<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MechanicQueries.aspx.cs" Inherits="AutoClinicWeb.Mechanic2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main_css.css"" />
    <style type="text/css">
        #wholepage {
            height: 127px;
            width: 999px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="wholepage">
          <asp:Table runat="server" Height="3178px" Width="558px"> 
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:ImageButton ID="menuIcon" CssClass="collapsible" ImageUrl="~/images/icons/menu.png" AlternateText="Menu Icon" runat="server" OnClick="menuIcon_Click" />&nbsp;&nbsp;Menu
                        <div class="content">
                            <ul>
                                <li>
                                    <asp:ImageButton ID="bookingsIcon" CssClass="icon" ImageUrl="~/images/icons/bookings.png" runat="server" />Bookings
                                </li>
                                <li>
                                    <asp:ImageButton ID="jobsIcon" CssClass="icon" ImageUrl="~/images/icons/jobs.png" runat="server" />Jobs
                                </li>
                                <li>
                                    <asp:ImageButton ID="quotesIcon" CssClass="icon" ImageUrl="~/images/icons/jobs.png" runat="server" />Quotes
                                </li>
                                <li>
                                    <asp:ImageButton ID="myAccountIcon" CssClass="icon" ImageUrl="~/images/icons/myaccount.png" runat="server" />My Account
                                </li>
                                <li>
                                    <asp:ImageButton ID="helpIcon" CssClass="icon" ImageUrl="~/images/icons/help.png" runat="server" />Help
                                </li>
                                <li>
                                    <asp:ImageButton ID="logOutIcon" CssClass="icon" ImageUrl="~/images/icons/logout.png" runat="server" />Log Out
                                </li>
                            </ul>
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <h1>Customers Enquiries</h1>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server">Search by: </asp:Label>
                        <asp:DropDownList ID="customerSearchOptions" runat="server"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtSearch" CssClass="textBox" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Search" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:DataGrid runat="server" ID="dgvCustomerList"></asp:DataGrid>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnNewCustomerQuery" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="Add New Customer" />
                        <asp:Button ID="btnViewCustomer" CssClass="btn btn-primary mainButton w-auto p-3" runat="server" Text="View Customer Details" />
                        <asp:Button ID="btnDeleteCustomerQuery" CssClass="btn-primary mainButton w-auto p-3tton" runat="server" Text="Delete Customer" />
                    </asp:TableCell>
                </asp:TableRow>

            

            
               
            </asp:Table>
            
            <div id="resultsTable">
                <asp:DataGrid runat="server" ID="DataGrid1" Width="553px"></asp:DataGrid>
            </div>

            <div class="footer">
                <asp:Image id="logo" ImageUrl="~/images/logos/autoclinic.png" runat="server" AlternateText="AutoClinic.Exe Logo" />
                <asp:Label ID="lblLoggedInAs"  runat="server" Text="Logged in as "></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
