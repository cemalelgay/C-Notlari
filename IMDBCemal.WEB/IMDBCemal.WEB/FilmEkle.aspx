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
                        <asp:TextBox ID="txtCıkısTarihi" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>               
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Yönetmen:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlYonetmen" CssClass="form-control" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnEkle" CssClass="btn btn-primary btn-block" runat="server" Text="Ekle"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
