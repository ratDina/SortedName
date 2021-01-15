<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewData.aspx.cs" Inherits="AppSortedName.ViewData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="btnLook" Text="Look File" OnClick="btnLook_Click" />
        </div>
        <p></p>
        <div>

            <br />
            <table border="1">
                <thead>
                </thead>
                <td style="color: darkgray;">Unsorted List Name</td>
                <asp:Label runat="server" ID="lbFile"></asp:Label>
            </table>

        </div>

        <div>

            <br />
            <br />

            <table border="1">

                <td style="color: orangered;">Sorted List Name</td>
                <asp:Label runat="server" ID="lbSort"></asp:Label>

            </table>
            <p></p>
            <asp:Label runat="server" ID="lbInfo"></asp:Label>
        </div>
    </form>
</body>
</html>
