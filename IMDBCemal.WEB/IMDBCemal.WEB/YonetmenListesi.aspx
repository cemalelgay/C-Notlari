<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YonetmenListesi.aspx.cs" Inherits="IMDBCemal.WEB.YonetmenListesi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yönetmen Ekle</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
            <h1>Yönetmen Listesi</h1>
            <a href="FilmListesi.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            <div class="table-responsive">
                <table class="table table-bordered">
                    <tr>
                        <th>Yönetmen</th>
                        <th style="width:30%">Islemler</th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("YonetmenAdi") %></td>
                                <td>
                                    <a href="YonetmenEkle.aspx?ID=<%#Eval("YonetmenID") %>" class="btn btn-warning">Düzenle</a>
                                    <a href="YonetmenListesi.aspx?ID=<%#Eval("YonetmenID") %>" class="btn btn-warning">Sil</a>
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
