<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmResponseWrite.aspx.cs" Inherits="FirstWepApp.FrmResponseWrite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnMsg" runat="server"
                text="클릭" OnClick="BtnMsg_Click" />
            <br />
            <%="또만나요<br />"%>
            <asp:Button ID="BtnJs" runat="server"
                Text="Js Greeting" OnClick="BtnJs_Click" />
            <br />
            <asp:Button ID="BtnLink" runat="server"
                Text="네이버" OnClick="BtnLink_Click" />
            <asp:LinkButton ID="Button1" runat="server"
                Text="네이버" OnClick="BtnLink_Click" />
        </div>
    </form>
</body>
</html>
