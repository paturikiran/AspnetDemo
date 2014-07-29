<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="VehicleQuoteDemo.PersonalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table class="table-condensed">
                <tr>
                    <td>
                        <label class="control-label">First Name</label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFirstName" CssClass="form-control"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <label class="control-label">Last Name</label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtLastName" CssClass="form-control"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <label class="control-label">States</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlStates">
                            
                        </asp:DropDownList>

                    </td>
                </tr>
            </table>
            <asp:Button ID="btnSubmit" runat="server" CssClass="btn-primary" Text="Proceed"  OnClick="Proceed" />
        </div>
    </form>
</body>
</html>
