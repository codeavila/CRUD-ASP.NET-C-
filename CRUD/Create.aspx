<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="CRUD.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Crear Usuario Nuevo</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_UsuarioNombre" runat="server" Text="Nombre de Usuario"></asp:Label>
            <asp:TextBox ID="asp_UsuarioNombre" runat="server"></asp:TextBox>
            <asp:Label ID="lbl_UsuarioPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="asp_UsuarioPassword" runat="server"></asp:TextBox>
            <asp:Button ID="btn_Registrar" runat="server" Text="Registrar Nuevo" OnCommand="btn_LoginSwitchCase" CommandName="Comando_Register"/>
            <asp:Button ID="btn_Regresar" runat="server" Text="Regresar a la pagina anterior"   OnCommand="btn_LoginSwitchCase" CommandName="Comando_Back"/>
        </div>
    </form>
</body>
</html>
