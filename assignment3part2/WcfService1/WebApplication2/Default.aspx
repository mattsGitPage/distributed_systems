<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Enter a video ID:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="197px"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Get Video" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Video Title"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="title"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Video Description"></asp:Label>
&nbsp;
        <asp:Label ID="Label5" runat="server" Text="description"></asp:Label>
        <br />
        get a playlist of videos!
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="search" />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="154px" Width="462px"></asp:ListBox>
    </div>

</asp:Content>
