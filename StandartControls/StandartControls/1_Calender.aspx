<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Calender.aspx.cs" Inherits="StandartControls._1_Calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Calendar ID="Calendar1" runat="server"
                BackColor="White"
                BorderColor="White"
                BorderWidth="1px"
                Font-Names="Verdana"
                Font-Size="9pt"
                ForeColor="Black"
                Height="190px"
                Width="350px"
                NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle Font-Bold="true" Font-Size="8pt"/>
                <NextPrevStyle Font-Bold="true" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom"/>
                <OtherMonthDayStyle ForeColor="#999999"/>
                <SelectedDayStyle ForeColor="White" BackColor="#333399"/>
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="true" Font-Size="12pt" ForeColor="#333399"/>
                <TodayDayStyle BackColor="#CCCCCC"/>
            </asp:Calendar>

        </div>
    </form>
</body>
</html>
