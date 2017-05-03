<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Welcome to the YouTube API  Search Any Video ID"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="enter a video ID"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Video Data" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Video Title"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="title"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Video Description"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="description"></asp:Label>
    </form>
</body>
</html>
