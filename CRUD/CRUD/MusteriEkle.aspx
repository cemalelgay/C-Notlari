<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MusteriEkle.aspx.cs" Inherits="CRUD.MusteriEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Musteri Ekle</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <style type="text/css">
        body {
            font-family: Calibri;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Müşteri Ekle</h1>
            <table class="table table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Ad:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAd" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Soyad:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSoyad" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Telefon:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTelefon" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Adres:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAdres" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" CssClass="btn-block btn btn-danger" OnClick="btnKaydet_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
