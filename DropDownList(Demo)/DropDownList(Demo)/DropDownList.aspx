<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="DropDownList_Demo_.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table align="Center">
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="306px" AppendDataBoundItems="True" >
                            <asp:ListItem Text="--Select--" Value="--Select--" Selected="True"></asp:ListItem>
                        </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="See Details" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="Mobile" HeaderText="Mobile" />
                            <asp:BoundField DataField="Age" HeaderText="Age" />
                            <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
        

            
        
       
    </form>
</body>
</html>
