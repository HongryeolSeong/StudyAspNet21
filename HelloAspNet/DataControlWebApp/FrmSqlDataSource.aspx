<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSqlDataSource.aspx.cs" Inherits="DataControlWebApp.FrmSqlDataSource" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>데이터소스 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="CboMemoName" runat="server" DataSourceID="SdsMemoName" DataTextField="Name" DataValueField="Num" ></asp:DropDownList>
            <asp:SqlDataSource ID="SdsMemoName" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnString %>" 
                SelectCommand="SELECT [Num], [Name] FROM [Memos] ORDER BY [Num] DESC"></asp:SqlDataSource><br />
            <asp:Chart ID="Chart1" runat="server">
                <Series>
                    <asp:Series Name="Series1">
                        <Points>
                            <asp:DataPoint AxisLabel="국어" YValues="90.0" />
                            <asp:DataPoint AxisLabel="영어" YValues="100.0" />
                            <asp:DataPoint AxisLabel="수학" YValues="95.0" />
                        </Points>
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">

                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
    </form>
</body>
</html>
