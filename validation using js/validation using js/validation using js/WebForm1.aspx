﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="validation_using_js.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">  
    function Allvalidate()  
    {  
        var ValidationSummary = "";  
        ValidationSummary += NameValidation();  
        ValidationSummary += EmailValidation();  
        ValidationSummary += PhonenoValidation();  
        if (ValidationSummary != "")  
        {  
            alert(ValidationSummary);  
            return false;  
        }  
        else  
        {  
            alert("Information submited successfuly");  
            return true;  
        }   
    }  
    function NameValidation()  
    {  
        var userid;  
        var controlId = document.getElementById("<%=txtcontct.ClientID %>");  
        userid = controlId.value;  
        var val;  
        val = /^[0-9]+$/;  
        var digits = /\d(10)/;  
        if (userid == "")  
        {  
            return ("Please Enter PhoneNo" + "\n");  
        }  
        else if (val.test(userid))  
        {  
            return "";  
        }  
   
        else  
        {  
            return ("PhoneNo should be only in digits" + "\n");  
        }  
    }  
    function EmailValidation()  
    {  
        var userid;  
        var controlId = document.getElementById("<%=txtname.ClientID %>");  
        userid = controlId.value;  
        var val = /^[a-zA-Z ]+$/  
        if (userid == "")  
        {  
            return ("Please Enter Name" + "\n");  
        }  
        else if (val.test(userid))  
        {  
            return "";  
   
        }  
        else  
        {  
            return ("Name accepts only spaces and charcters" + "\n");  
        }  
    }  
    function PhonenoValidation()  
    {  
        var userid;  
        var controlId = document.getElementById("<%=txtemail.ClientID %>");  
        userid = controlId.value;  
        var val = /\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*/;  
        if (userid == "")  
        {  
            return ("Please Enter Email Id" + "\n");  
        }  
        else if (val.test(userid))  
        {  
            return "";  
        }  
   
        else  
        {  
            return ("Email should be in this form example: xyz@abc.com" + "\n");  
        }  
    }  
    </script>  
</head>
<body>
    <form id="form1" runat="server"> 
        <table style="border-color: #333300; z-index: 1; left: 15px; top: 54px; position: absolute; height: 122px; width: 261px">  
        <tr>  
            <td>  
                <asp:Label ID="lblname" runat="server" Text="FirstName"></asp:Label>  
            </td>  
            <td>  
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>  
            </td>  
            <td>  
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Label ID="lblCntno" runat="server" Text="Phone No"></asp:Label>  
            </td>  
            <td>  
                <asp:TextBox ID="txtcontct" runat="server"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td></td>  
            <td>  
                <asp:Button ID="bttnsubmit" runat="server" Text="Submit" OnClientClick ="javascript:Allvalidate()" Font-Bold="True" OnClick="bttnsubmit_Click" />  
            </td>  
        </tr>  
        </table>  
    </form>
</body>
</html>
