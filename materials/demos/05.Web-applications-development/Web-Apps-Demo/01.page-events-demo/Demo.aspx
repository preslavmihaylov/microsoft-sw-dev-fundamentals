<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Demo.aspx.cs" Inherits="_01.page_events_demo.Demo" EnableViewState="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" ViewStateMode="Enabled"></asp:Calendar>
    </div>
    </form>
</body>
</html>
