<%@ Page Title="" Language="C#" MasterPageFile="~/Page1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MasterPageApplicationDemo.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="Center">Register New Employees</h1>
    <table align="center" bgcoloe ="#cccccc" style="width: 54%">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name to Submit" ControlToValidate="name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Mobile No: </td>
                <td>
                    <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter Valid Mobile No." ControlToValidate="mob" ValidationExpression="^[6-9]\d{9}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            
            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="age" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age must be more than 18 and less than 50" ControlToValidate="age" MaximumValue="50" MinimumValue="18"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td align="left">
                    <asp:RadioButtonList ID="gender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>

                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Must Select Any One" ControlToValidate="gender"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Submit" runat="server" Text="Click To Register" OnClick="Submit_Click" />

                </td>
            </tr>
            <tr>
                <td colspan="2" align="Center">
                    <asp:Label ID="Registered" runat="server" Text=""></asp:Label>

                </td>
            </tr>

        </table>
</asp:Content>
