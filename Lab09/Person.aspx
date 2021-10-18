<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="Lab09.Person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Person</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center g-3 col-md-8 ms-auto me-auto mt-auto">
                <div class="col-md-4">
                    <asp:Label ID="Label1" runat="server" Text="Nombre" AssociatedControlID="textFirstName" CssClass="mb-1"></asp:Label>
                    <asp:TextBox ID="textFirstName" runat="server" CssClass="form-control" AutoCompleteType="FirstName"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="Label2" runat="server" Text="Apellido" AssociatedControlID="textLastName" CssClass="mb-1"></asp:Label>
                    <asp:TextBox ID="textLastName" runat="server" CssClass="form-control" AutoCompleteType="LastName"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Label ID="Label3" runat="server" Text="Usuario" AssociatedControlID="textUser" CssClass="mb-1"></asp:Label>
                    <div class="input-group">
                        <div class="input-group-text">@</div>
                        <asp:TextBox ID="textUser" runat="server" CssClass="form-control" AutoCompleteType="None"></asp:TextBox>
                    </div>
                </div>
                <div class="col-4">
                    <asp:Label ID="Label4" runat="server" Text="Departamento" AssociatedControlID="ddlDepartment" CssClass="mb-1"></asp:Label>
                    <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="form-select">
                        <asp:ListItem Text="Administración" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Contabilidad" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Recursos Humanos" Value="3"></asp:ListItem>
                        <asp:ListItem Text="TI" Value="4"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-8">
                    <asp:Label ID="Label5" runat="server" Text="Dirección" AssociatedControlID="textDirection" CssClass="mb-1"></asp:Label>
                    <asp:TextBox ID="textDirection" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-12">
                    <div class="form-check">
                        <asp:TextBox ID="checkBox" runat="server" CssClass="form-check-input" type="checkbox"></asp:TextBox>
                        <asp:Label ID="Label6" runat="server" Text="Aceptar los términos y condiciones" 
                            AssociatedControlID="checkBox" CssClass="form-check-label"></asp:Label>
                    </div>
                </div>
                <div class="col-12">
                    <asp:Button ID="btnRegister" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="BtnGreeting_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
