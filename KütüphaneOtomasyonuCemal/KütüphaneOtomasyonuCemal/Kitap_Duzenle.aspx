<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kitap_Duzenle.aspx.cs" Inherits="KütüphaneOtomasyonuCemal.Kitap_Duzenle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <h1>Kitap Düzenle</h1>
        <table class="table table-bordered">
                            <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Kitap Ad:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtAd" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Yazar:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSoyad" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Kitap Konusu:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtTelefon" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Kitap RafNo"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtAdres" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGuncelle" CssClass="btn btn-info btn-block" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
                    </td>
                </tr>
        </table>
    </div>
    </form>
</body>
</html>
