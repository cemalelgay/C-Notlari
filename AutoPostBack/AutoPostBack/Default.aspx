<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AutoPostBack.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Lütfen İl Seçin"></asp:Label>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Lütfen İlçe Seçin"></asp:Label>
        </p>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </form>
</body>
</html>
