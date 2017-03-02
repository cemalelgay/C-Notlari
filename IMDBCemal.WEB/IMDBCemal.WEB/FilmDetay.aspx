<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilmDetay.aspx.cs" Inherits="IMDBCemal.WEB.FilmDetay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Film Detay</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
            <h1>Film Bilgileri</h1>
            <a href="FilmListesi.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            <table class="table table-bordered table-responsive">
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label1" runat="server" Text="Film Adı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFilmAdi" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label2" runat="server" Text="Film Konusu:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFilmKonusu" CssClass="auto-style1" runat="server" ReadOnly="true" TextMode="MultiLine" Height="199px" Width="850px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label3" runat="server" Text="Çıkış Tarihi:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCikisTarihi" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label4" runat="server" Text="Film Türü:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTur" CssClass="form-control" runat="server" Enabled="false"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td width="30%">
                        <asp:Label ID="Label5" runat="server" Text="Yönetmen:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlYonetmen" CssClass="form-control" runat="server" Enabled="false"></asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
