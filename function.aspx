<%@ Page Language="C#" AutoEventWireup="true" CodeFile="function.aspx.cs" Inherits="function" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="下底"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="高"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="邊長"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="計算三角形面積" OnClick="Button1_Click" />
        <br/>
        <asp:Label ID="Lbl_result" runat="server" Text=""></asp:Label>

    </div>
    </form>
</body>
</html>
