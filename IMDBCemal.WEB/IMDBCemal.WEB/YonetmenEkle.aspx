<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YonetmenEkle.aspx.cs" Inherits="IMDBCemal.WEB.YonetmenEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yönetmen Ekle</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <form id="form1" runat="server">
   <div class="container">
            <h1>Yönetmen Ekle</h1>
            <a href="FilmListesi.aspx" class="btn btn-primary">Ana Sayfa</a><br />
            <table class="table table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Yönetmen Adı:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtYonetmenName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnKaydet" CssClass="btn btn-primary btn-block" runat="server" Text="Kaydet"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
