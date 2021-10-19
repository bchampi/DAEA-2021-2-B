<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListPersonDB.aspx.cs" Inherits="Lab09.ListPersonDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Listado de Personas</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container justify-content-center col-md-7 ms-auto me-auto mt-3">
            <a class="btn btn-dark" href="/Person/">Regresar</a>
            <asp:GridView ID="dgvPerson" runat="server" CssClass="col-12 table table-light table-striped mt-3" border="0">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
