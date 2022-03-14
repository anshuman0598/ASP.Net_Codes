<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormDemo.aspx.cs" Inherits="FormDemo_TakingInput_and_StoringData_.FormDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table width ="40%" align="center" bgcoloe ="#cccccc">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Mobile No: </td>
                <td>
                    <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="age" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td align="left">
                    <asp:RadioButtonList ID="gender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>

                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td colspan="2" align ="center" class="auto-style1">
                    <asp:Button ID="Submit" runat="server" Text="Click To Register" OnClick="Submit_Click" />

                </td>
            </tr>
            <tr>
                <td colspan="2" align="Center">
                    <asp:Label ID="Registered" runat="server" Text="Registration Status"></asp:Label>

                </td>
            </tr>

        </table>


    </form>
</body>
</html>
