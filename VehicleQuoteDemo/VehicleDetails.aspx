<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicleDetails.aspx.cs" Inherits="VehicleQuoteDemo.VehicleDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="container">
            <table class="table-condensed">
                <tr>
                    <td>
                        <label class="control-label">Year</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlYear" OnSelectedIndexChanged="ddlYear_Change" AutoPostBack="true">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label class="control-label">Make</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlMake">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label class="control-label">Model</label>
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlModel">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnSubmit" runat="server" CssClass="btn-primary" Text="Proceed" OnClick="Proceed"  />
        </div>
    </form>
</body>
</html>
