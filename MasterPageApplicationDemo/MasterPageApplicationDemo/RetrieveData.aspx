<%@ Page Title="" Language="C#" MasterPageFile="~/Page1.Master" AutoEventWireup="true" CodeBehind="RetrieveData.aspx.cs" Inherits="MasterPageApplicationDemo.RetrieveData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="Center">Enter The Name To Search The Person Details</h2>
    <table width="40%" align="center">
           <tr>
               <td>
               <asp:TextBox ID="Name" runat="server" Width="395px"></asp:TextBox>
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
</asp:Content>
