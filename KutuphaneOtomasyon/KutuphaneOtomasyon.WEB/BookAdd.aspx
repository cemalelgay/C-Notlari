<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookAdd.aspx.cs" Inherits="KutuphaneOtomasyon.WEB.BookAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Kitap Ekle</h1>
            <table class="table table-bordered">
                <%--bootstrap table--%>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Kitap Adi:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtBookName" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Kitap Konusu:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSubject" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Sayfa Sayisi:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPageCount" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Raf No:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtShelfNumber" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Yazar Adi:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlWriter" CassClass="form-control" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnKaydet" CssClass="btn btn-primary btn-block" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
