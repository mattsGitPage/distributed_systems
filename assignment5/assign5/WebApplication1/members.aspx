<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="members.aspx.cs" Inherits="WebApplication1.member" %><%@ Register src="FragmentCtrl1.ascx" tagname="FragmentCtrl1" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        By signing up for this service you will recieve unlimited access to searches of youtube video ids. This provides unlimited access to youtubes video details and all you have to provide is the youtube video id.<br />
        <br />
        <br />
        <br />
        Create an account fragment cached at
        <uc1:FragmentCtrl1 ID="FragmentCtrl11" runat="server" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="user name"></asp:Label>
&nbsp;&nbsp;
      
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
      
        <br />
        <br />
        age&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
      
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="confirm password"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="image string length"></asp:Label>
&nbsp;=
        <asp:TextBox ID="TextBox7" runat="server" Width="35px"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="show the image string" />
&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" style="width: 14px" />
        <br />
        <asp:Label ID="Label8" runat="server" Text="enter the string here"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="create account" />
        &nbsp;<br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp; at time
        <br />
        <br />
        Already a member?<br />
        Sign in<br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="user name"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="password"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="login" />
        <br />
    
    </div>
    </form>
</body>
</html>
