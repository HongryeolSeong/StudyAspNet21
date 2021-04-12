<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRichControl.aspx.cs" Inherits="FirstWepApp.FrmRichControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar runat="server" ID="CalMain" BackColor="DarkSeaGreen" BorderColor="Green"
                BorderWidth="1px" DayNameFormat="Shortest" OnSelectionChanged="CalMain_SelectionChanged">
                <DayHeaderStyle BackColor="Orange" Font-Bold="true" Height="1px" />
            </asp:Calendar>
        </div>
    </form>
</body>
</html>
