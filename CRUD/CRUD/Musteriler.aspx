<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="CRUD.Musteriler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Musteriler</h1>
            <a href="#">Yeni Ekle</a>
            <table border="1">
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
                                <a href="#">Güncelle</a>
                                <a href="#">Sil</a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>

            </table>
        </div>
    </form>
</body>
</html>
