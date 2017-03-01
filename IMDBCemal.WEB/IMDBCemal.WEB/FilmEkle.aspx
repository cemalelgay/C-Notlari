<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilmEkle.aspx.cs" Inherits="IMDBCemal.WEB.FilmEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Film Ekle</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Film Ekle</h1>
            <a href="FilmListesi.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            <table class="table table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Film Adı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFilmAdi" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Film Konusu:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFilmKonusu" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Çıkış Tarihi:"></asp:Label>
                    </td>
                    <td>
                        <asp:Calendar CssClass="form-control" ID="calender1" runat="server" BackColor="White" BorderColor="#999999" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" CellPadding="4" DayNameFormat="Shortest">
                            <DayHeaderStyle Font-Bold="True" Font-Size="7pt" BackColor="#CCCCCC" />
                            <NextPrevStyle VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#808080" />
                            <SelectedDayStyle BackColor="#666666" ForeColor="White" Font-Bold="True" />
                            <SelectorStyle BackColor="#CCCCCC" />
                            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Yönetmen:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlYonetmen" CssClass="form-control" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Film Türü:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlFilmTur" CssClass="form-control" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnEkle" CssClass="btn btn-primary btn-block" runat="server" Text="Ekle" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
