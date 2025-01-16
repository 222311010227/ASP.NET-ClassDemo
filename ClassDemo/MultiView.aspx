<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiView.aspx.cs" Inherits="ClassDemo.MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MultiView Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <!-- View 1 -->
                <asp:View ID="View1" runat="server">
                    <h2>Welcome to View 1</h2>
                    <p>
                        Name:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="228px"></asp:TextBox>
                    </p>
                    <p>
                        Gender:&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                    </p>
                    <p>
                        Address:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox3" runat="server" Height="49px" Width="225px"></asp:TextBox>
                    </p>
                    <p>
                        Degree:&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="101px"></asp:TextBox>
                    </p>
                    <asp:Button ID="btnToView2" runat="server" Text="Next" OnClick="btnToView2_Click" Width="96px" />
                </asp:View>

                <!-- View 2 -->
                <asp:View ID="View2" runat="server">
                    <h2>Welcome to View 2</h2>
                    <p>
                        &nbsp;</p>
                    <asp:Button ID="btnToView1" runat="server" Text="Previous" OnClick="btnToView1_Click" />
                    <asp:Button ID="btnToView3" runat="server" Text="Next" OnClick="btnToView3_Click" Width="117px" />
                </asp:View>

                <!-- View 3 -->
                <asp:View ID="View3" runat="server">
                    <h2>Welcome to View 3</h2>
                    <asp:Button ID="btnToView2From3" runat="server" Text="Previous" OnClick="btnToView2From3_Click" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
