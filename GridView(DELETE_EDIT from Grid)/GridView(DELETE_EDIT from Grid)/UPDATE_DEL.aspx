<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UPDATE_DEL.aspx.cs" Inherits="GridView_DELETE_EDIT_from_Grid_.UPDATE_DEL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="217px" DataKeyNames="ID" OnRowCancelingEdit="GridView1_RowCancelEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="Page_Load" Width="666px">
            <Columns>
               
                <asp:TemplateField HeaderText="Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtname" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mobile">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtmob" runat="server" Text='<%# Bind("Mobile") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Mobile") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Age">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtage" runat="server" Text='<%# Bind("Age") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Age") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtgender" runat="server" Text='<%# Bind("Gender") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
