<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tempASP._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Temperature Converter</h1>
        <p>where we convert your celius to farenhiet and your farenhiet to celcius</p>
        <p>&nbsp;</p>
        <p>enter degrees in Celcius
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert To Farenheit" />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;</p>
        <p>&nbsp;</p>
        <p>enter degrees in Farenheit
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Convert To Celcius" OnClick="Button2_Click" />
&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            &nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
            <p>
            </p>
        </div>
    </div>

</asp:Content>
