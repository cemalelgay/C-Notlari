<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="CRUD.Musteriler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Müşteriler</title>
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
            <h1>Erdal Bakkalın Müşterileri</h1>
            <a href="MusteriEkle.aspx" class="btn-primary">Yeni Ekle</a><br />
            <br />
            <div class="table-responsive"></div>
            <table class="table table-bordered">
                <tr>
                    <th>ID</th>
                    <th>Ad</th>
                    <th>Soyad</th>
                    <th>Telefon</th>
                    <th>Adres</th>
                    <th>Düzenle</th>
                </tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("CustomerID") %></td>
                            <td><%#Eval("CustomerName") %></td>
                            <td><%#Eval("CustomerSurname") %></td>
                            <td><%#Eval("PhoneNumber") %></td>
                            <td><%#Eval("Adress") %></td>
                            <td>
                                <a href="MusteriDuzenle.aspx?ID=<%#Eval("CustomerID") %>" class="btn btn-primary">Güncelle</a>
                                <a href="#" class="btn btn-success">Sil</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
