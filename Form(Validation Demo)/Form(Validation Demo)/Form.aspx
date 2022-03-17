<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Form_Validation_Demo_.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" bgcoloe ="#cccccc" style="width: 54%">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name to Submit" ControlToValidate="name" Display="Dynamic" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <tr>
                <td>Mobile No: </td>
                <td>
                    <asp:TextBox ID="mob" runat="server" TextMode="Number"></asp:TextBox>
                     </td>
            </tr>
            <tr>
                
                <td Align="center" colspan="2">
                    
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Enter Valid Mobile No." ControlToValidate="mob" ValidationExpression="^[6-9]\d{9}$" Display="Dynamic" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan ="2">
                    <asp:RequiredFieldValidator  ID="RequiredFieldValidator3" runat="server" ControlToValidate="mob" Display="Dynamic" ForeColor="#FF3300" Font-Size="Small">You must enter Mobile Number</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>EmailID: </td>
                <td>
                    <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                
                <td Align="center" colspan="2">
                    
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Valid Email" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan ="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="email" Display="Dynamic" Font-Size="Small" ForeColor="#FF3300">You must enter EmailID</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm EmailID: </td>
                <td>
                    <asp:TextBox ID="email2" runat="server" TextMode="Email"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                
                <td Align="center" colspan="2">
                    
                   <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Email Mismatch" ControlToCompare="email" ControlToValidate="email2" Display="Dynamic" Font-Size="Smaller" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Password: </td>
                <td>
                    <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                    
                   
                </td>
                
            </tr>
            <tr>
                
                <td Align="center" colspan="2">
                    
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Weak Password" ControlToValidate="password" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&amp;])[A-Za-z\d@$!%*#?&amp;]{8,}$" Display="Dynamic" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td colspan ="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="password" Display="Dynamic" Font-Size="Small" ForeColor="Red">You must enter a Password</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Password: </td>
                <td>
                    <asp:TextBox ID="cpassword" runat="server" TextMode="Password"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
               <td Align="center" colspan="2">
                    
                   <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Password Mismatch" ControlToCompare="password" ControlToValidate="cpassword" Display="Dynamic" Font-Size="Smaller" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>

            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="age" runat="server" TextMode="Number"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
               <td Align="center" colspan="2">
                    
                   <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age must be more than 18 and less than 50" ControlToValidate="age" MaximumValue="50" MinimumValue="18" Display="Dynamic" Font-Size="Smaller" ForeColor="Red"></asp:RangeValidator>
                </td>
            </tr>

            <tr>
                <td colspan ="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="age" Display="Dynamic" Font-Size="Small" ForeColor="Red">You must enter your Age</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td align="left">
                    <asp:RadioButtonList ID="gender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>

                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="gender" Display="Dynamic" Font-Size="Small" ForeColor="Red">Must Select Any One</asp:RequiredFieldValidator>
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
