<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.BookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kitap Listesi</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Bilge Adam Kütüphanesi Kitap Listesi</h1>
            <a href="#" class="btn btn-primary">Yeni Ekle</a><br />
            &nbsp;
            <div class="table-responsive">
                <table class="table table-bordered">
                    <tr>
                        <%--<th style="visibility:hidden">ID</th>--%>
                        <th>Kitap Adı</th>
                        <th>Kitap Konusu</th>
                        <th>Yazar Adı</th>
                        <th>Sayfa Sayısı</th>
                        <th>Durumu</th>
                        <th>İşlem</th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <%--FOREACH gibi--%>
                        <ItemTemplate>
                            <tr>
                                <%--<td style="visibility:hidden"><%# Eval("CustomerID") %></td>--%>
                                <td><%# Eval("BookName") %></td>
                                <td><%# Eval("BookSubject") %></td>
                                <td><%# Eval("WriterName") %></td>
                                <td><%# Eval("PageCount") %></td>
                                <td><%# Eval("IsRented") %></td>
                                <td>
                                    <a href="Musteri_Duzenle.aspx?ID=<%#Eval("BookID") %>" class="btn btn-warning">Güncelle</a>
                                    <a href="Musteriler.aspx?ID=<%# Eval("BookID") %>" class="btn btn-danger">Sil</a>
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
