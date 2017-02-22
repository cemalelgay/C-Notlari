<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kitaplar.aspx.cs" Inherits="KütüphaneOtomasyonuCemal.Kitaplar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kitaplar</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        body {
            font-family: Calibri;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1><b>Kütüphane Kitap Lisesi</b></h1>
            <a href="Kitap_Ekle.aspx" class="btn btn-primary">Kitap Ekle</a><br />
            &nbsp;
            <div class="table-responsive">
                <table class="table table-bordered">
                    <tr>
                        <th>Kitap Ad</th>
                        <th>Kitap Yazar</th>
                        <th>Kitap Durum</th>
                        <th>Düzenle</th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("KitapAd") %></td>
                                <td><%# Eval("YazarAd") %></td>
                                <td><%# Eval("Durum") %></td>
                                <td>
                                    <a href="Kitap_Duzenle.aspx?ID=<%#Eval("KitapID") %>" class="btn btn-danger ">Guncelle</a>
                                    <a href="Kitaplar.aspx?ID=<%#Eval("KitapID") %>" class="btn btn-success">Sil</a>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
