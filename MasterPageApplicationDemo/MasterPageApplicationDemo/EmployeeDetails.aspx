<%@ Page Title="" Language="C#" MasterPageFile="~/Page1.Master" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="MasterPageApplicationDemo.EmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="Center">
        Employee Details
    </h2>
    <asp:GridView ID="GridView1" align="Center" runat="server" Height="379px" Width="485px"></asp:GridView>
</asp:Content>
