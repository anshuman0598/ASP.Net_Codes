﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchName.aspx.cs" Inherits="SearchingaValueInTable.SearchName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table width="40%" align="center">
           <tr>
               <td>
               <asp:TextBox ID="age" runat="server" Width="395px"></asp:TextBox>
               </td>
               <td>
                   <asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" Width="148px" />
               </td>
           </tr>
           
           <tr>
               <td>
                   <asp:Label ID="result" runat="server" Text=""></asp:Label>
               </td>
           </tr>
           <tr>
               <td colspan="2">
                   <asp:GridView ID="Goutput" runat="server" Height="186px" Width="549px"></asp:GridView>
               </td>
           </tr>
       </table>
    </form>
</body>
</html>
