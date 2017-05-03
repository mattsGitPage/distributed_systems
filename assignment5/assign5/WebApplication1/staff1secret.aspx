<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staff1secret.aspx.cs" Inherits="WebApplication1.staff1secret" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        this page contains information only staff one can see<br />
        <br />
        view all members and their passwords<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="view users and passwords" />
        </div>
    </form>
</body>
</html>
