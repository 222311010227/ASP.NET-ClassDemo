<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AD.aspx.cs" Inherits="ClassDemo.AD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="width: 1245px; height: 586px">
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Add.xml" Height="500px" Width="700px" />
        </p>
    </form>
</body>
</html>
