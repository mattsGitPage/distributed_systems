<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="membersSecret.aspx.cs" Inherits="WebApplication1.membersSecret" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        this page contains information only members can see<br />
        <br />
        search a youtube video based on its video id&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="go" />
        <br />
        <br />
        <br />
        video title&nbsp;
        <asp:Label ID="Label1" runat="server" Text=".."></asp:Label>
        <br />
        <br />
        Video Description
        <asp:Label ID="Label2" runat="server" Text=".."></asp:Label>
        <br />
        </div>
    </form>
</body>
</html>
