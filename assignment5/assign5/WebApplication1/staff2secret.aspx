<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staff2secret.aspx.cs" Inherits="WebApplication1.staff2secret" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        this page contains the sensitive information only staff two can see<br />
        <br />
        view both staff 1 names and passwords?<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="staff1" />
        <br />
        view both members names and passwords?<br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="members" />
        </div>
    </form>
</body>
</html>
