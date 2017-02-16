<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultPage.aspx.cs" Inherits="RepeaterProdocut.DefaultPage" %>

<%@ Import Namespace="RepeaterProdocut" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Urun
        {
            width:200px;
            background-color:red;
            margin: 10px;
            color:white;
        }
        p
        {
            padding:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                using (NorthwindEntities db = new NorthwindEntities())
                {
                    List<Product> productList = db.Products.ToList();

                    foreach (var item in productList)
                    {
            %>
            <div class="Urun" id='<%=item.ProductID %>' onmouseover="Degistir(<%=item.ProductID %>)" onmouseout="GeriDondur(<%=item.ProductID %>)">
                <p><b><i><%=item.ProductName %></i></b></p></div>
             <%--b=kalın i=italik--%>
            <%
                    }
                }
            %>
        </div>
    </form>
    <script>
        function Degistir(id)
        {
            document.getElementById(id).style.backgroundColor = "Aqua";
        }

        function GerDondur(id)
        {
            document.getElementById(id).style.backgroundColor = "White";
        }
    </script>
</body>
</html>
