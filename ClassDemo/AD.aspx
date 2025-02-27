﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AD.aspx.cs" Inherits="ClassDemo.AD" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ad Rotator and File Upload</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- AdRotator Control -->
            <asp:AdRotator
                ID="AdRotator1"
                runat="server"
                AdvertisementFile="~/Advertisements.xml"
                Width="300px"
                Height="250px" />
            
            <br /><br />

            <!-- File Upload Section -->
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload Image" />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
