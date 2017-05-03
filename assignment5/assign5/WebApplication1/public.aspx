<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="public.aspx.cs" Inherits="WebApplication1._public" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 123px;
        }
        .auto-style2 {
            width: 72px;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 133px;
        }
        .auto-style5 {
            width: 96px;
        }
        .auto-style6 {
            width: 426px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        This application is intended for a registered user to search and view any video 
        details on the youtube website. It uses the youtube api to generate a video title and description based on the video id entered by the user. the staff users can generate hashcodes and are able to grant members access to different pages.<br />
        <br />
        <br />
        In order to use this service you be over 18 and register yourself with a user name and password, once completed you will be able to log in and have unlimited access to search for video titles and descritpions.<br />
        <br />
        To sign up please follow this link to the sign up page where more information is given on the application and its functions.<br />
        <br />
        members or new members click here<br />
        <asp:HyperLink ID="HyperLink1" runat="server">sign up/ login page</asp:HyperLink>
        <br />
        <br />
        staff group 1 login page click here<br />
        <asp:HyperLink ID="HyperLink2" runat="server">staff1 login</asp:HyperLink>
        <br />
        <br />
        staff group 2 login page click here<br />
        <asp:HyperLink ID="HyperLink3" runat="server">staff2 login</asp:HyperLink>
        <br />
        <br />
        <table class="auto-style3">
            <tr>
                <td class="auto-style1">provider name</td>
                <td class="auto-style2">type</td>
                <td class="auto-style4">operation name</td>
                <td class="auto-style5">parameters</td>
                <td>return type</td>
                <td class="auto-style6">descritpion</td>
                <td>tryit</td>
            </tr>
            <tr>
                <td class="auto-style1">matthew dunning</td>
                <td class="auto-style2">webservice</td>
                <td class="auto-style4">getVideoDetails</td>
                <td class="auto-style5">string: id</td>
                <td>string<br />
                    of videos</td>
                <td class="auto-style6">enter a video id and the title and description of the video will be displayed, also search for playlists</td>
                <td>
                    <asp:HyperLink ID="HyperLink4" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">asu repo</td>
                <td class="auto-style2">&nbsp;DLL&nbsp;</td>
                <td class="auto-style4">encryption/decryption</td>
                <td class="auto-style5">string: id</td>
                <td>string</td>
                <td class="auto-style6">enter a string to encrypt or decrypt</td>
                <td>
                    <br />
                    <asp:HyperLink ID="HyperLink5" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">matthew dunning</td>
                <td class="auto-style2">webservice</td>
                <td class="auto-style4">register an account</td>
                <td class="auto-style5">string: name<br />
                    string password</td>
                <td>added account to an xml file</td>
                <td class="auto-style6">enter a name and password the verify it with an image verifier and you have an account</td>
                <td>
                    <br />
                    <asp:HyperLink ID="HyperLink6" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">asu repo</td>
                <td class="auto-style2">webservice</td>
                <td class="auto-style4">image verifier</td>
                <td class="auto-style5">string: image content</td>
                <td>verifies you&#39;re a real person</td>
                <td class="auto-style6">enter the image that appears to create an account</td>
                <td>
                    <br />
                    <asp:HyperLink ID="HyperLink7" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">matthew dunning</td>
                <td class="auto-style2">DLL</td>
                <td class="auto-style4">current user<br />
                    encryptIt/decryptIt</td>
                <td class="auto-style5">string: current user<br />
                    <br />
                    string: code<br />
                    <br />
                    string code</td>
                <td>string: current user<br />
                    <br />
                    string:<br />
                    encrypted code<br />
                    <br />
                    string: decrypted code</td>
                <td class="auto-style6">
                    <br />
                    encodes and decodes the strings for processing security</td>
                <td>
                    <br />
                    <asp:HyperLink ID="HyperLink8" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">matthew dunning</td>
                <td class="auto-style2">Webservice</td>
                <td class="auto-style4">help menu</td>
                <td class="auto-style5">none</td>
                <td>string:<br />
                    menu help</td>
                <td class="auto-style6">shows a help dialog box </td>
                <td>
                    <br />
                    <asp:HyperLink ID="HyperLink9" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">matthew dunning</td>
                <td class="auto-style2">Webservice</td>
                <td class="auto-style4">create hash code</td>
                <td class="auto-style5">none</td>
                <td>string resulting hashcode</td>
                <td class="auto-style6">shows the user what a hashcode is based on a key and code given to users to access other pages</td>
                <td>
                    <br />
                    <asp:HyperLink ID="HyperLink10" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">matthew dunning</td>
                <td class="auto-style2">user control</td>
                <td class="auto-style4">fragment caching </td>
                <td class="auto-style5">none</td>
                <td>the access time of page</td>
                <td class="auto-style6">shows the user when the inital time attempt was to access the account creation page</td>
                <td>
                    <br />
                    <asp:HyperLink ID="HyperLink11" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">matthew
                    <br />
                    dunning</td>
                <td class="auto-style2">webservice</td>
                <td class="auto-style4">ageverifier</td>
                <td class="auto-style5">int: age</td>
                <td>string access or denial of membership</td>
                <td class="auto-style6">shows the user if they are old enough to access the
                    <br />
                    web content</td>
                <td>
                    <asp:HyperLink ID="HyperLink12" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">asu repo</td>
                <td class="auto-style2">webservice</td>
                <td class="auto-style4">hashcode</td>
                <td class="auto-style5">string: code<br />
                    string salt</td>
                <td>generates a hash code based on the salt key and input code</td>
                <td class="auto-style6">generates a hash code for the staff page users to validate info</td>
                <td>
                    <asp:HyperLink ID="HyperLink13" runat="server">tryItLink</asp:HyperLink>
                </td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
