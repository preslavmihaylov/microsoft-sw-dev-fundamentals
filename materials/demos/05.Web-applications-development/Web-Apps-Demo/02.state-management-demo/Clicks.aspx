<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clicks.aspx.cs" Inherits="_02.state_management_demo.Clicks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="clicksLabel" runat="server"></asp:Label>
    </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Click!" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
