<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="Lab09.Person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Person</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row align-items-center container mt-4">
            <div class="col-auto">
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            </div>
            <div class="col-3">
                <asp:TextBox ID="textName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-auto">
                <asp:Button ID="BtnGreeting" runat="server" Text="Saludar" OnClick="BtnGreeting_Click" CssClass="btn btn-primary" />
            </div>
        </div>
    </form>
</body>
</html>
