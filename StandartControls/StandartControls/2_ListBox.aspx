<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_ListBox.aspx.cs" Inherits="StandartControls._2_ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row" style="margin-top: 50px">
                <div class="panel1 panel-default">
                    <div class="panel-body">
                        <div class="col-Ig-12">
                            <asp:DropDownList CssClass="form-control" ID="ddlKategoriler" runat="server" Height="16px" Width="984px" AutoPostBack="true" OnSelectedIndexChanged="ddlKategoriler_SelectedIndexChanged">
                            </asp:DropDownList>
                            <br />
                            <asp:ListBox ID="lbUrunler" CssClass="form-control" runat="server" Width="979px"></asp:ListBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
