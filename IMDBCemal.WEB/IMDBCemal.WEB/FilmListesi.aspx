<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilmListesi.aspx.cs" Inherits="IMDBCemal.WEB.FilmListesi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Film Listesi</h1>
            <%--<a href="BookAdd.aspx" class="btn btn-primary">Yeni Ekle</a><br />--%>
            <div class="btn-group">
                <button type="button" class="btn btn-primary">İşlemler</button>
                <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                    <span class="caret"></span>
                </button>
                <ul class="dropdown-menu" role="menu">
                    <li><a href="FilmEkle.aspx">Film Ekle</a></li>
                    <li><a href="YonetmenEkle.aspx">Yönetmen Ekle</a></li>
                    <li><a href="#">Tür Ekle</a></li>
                    <li><a href="#">Film Listesi</a></li>
                    <li><a href="YonetmenListesi.aspx">Yönetmen Listesi</a></li>
                    <li><a href="#">Tür Listesi</a></li>
                </ul>
            </div>
            &nbsp;
            <div class="table-responsive">
                <table class="table table-bordered">
                    <tr>
                        <th>Film Adı</th>
                        <th>Film Konusu</th>
                        <th>Film Puanı</th>
                        <th>Çıkış Tarihi</th>
                        <th>Yönetmen</th>
                        <th>İşlem</th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr class="<%#Eval("FilmAdı")%>">
                                <td><%# Eval("FilmKonusu") %></td>
                                <td><%# Eval("Filmpuani") %></td>
                                <td><%# Eval("FilmCikisTarihi") %></td>
                                <td><%# Eval("PageCount") %></td>
                                <td><%#Eval("FilmYonetmeni")%></td>
                                <td>
                                    <a href="FilmEkle.aspx?ID=<%#Eval("FilmID") %>" class="btn btn-primary btn-floating">Güncelle</a>
                                    <a href="#?ID=<%#Eval("FilmID") %>" class="btn btn-danger btn-floating">Ekle</a>
                                    <a href="#?ID=<%#Eval("FilmID") %>" class="btn btn-success btn-floating">Sil</a>
                                    <a href="#?ID=<%#Eval("FilmID") %>" class="btn btn-warning btn-floating">Detay</a>
                                    <a href="#?ID=<%#Eval("FilmID") %>" class="btn btn-info btn-floating">OyVer</a>
                                    <%--                                    <a href="Musteriler.aspx?ID=<%# Eval("BookID") %>" class="btn btn-danger btn-block">Sil</a>--%>
                                    <%--<asp:Button runat="server" ID="btn" OnClientClick="return confirm('Here give some meaningful text')" OnClick="BtnClick" />--%>
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
