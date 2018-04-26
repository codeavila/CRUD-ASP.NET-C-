<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CRUD.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Login</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_UsuarioNombre" runat="server" Text="Nombre de Usuario"></asp:Label>
            <asp:TextBox ID="asp_UsuarioNombre" runat="server"></asp:TextBox>

            <asp:Label ID="lbl_UsuarioPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="asp_UsuarioPassword" runat="server"></asp:TextBox>

            <asp:Button ID="btn_Ingresar" runat="server" Text="Ingresar"  OnCommand="btn_LoginSwitchCase" CommandName="Comando_Ingresar"/>
            <asp:Button ID="btn_Registrar" runat="server" Text="Nuevo Usuario" OnCommand="btn_LoginSwitchCase" CommandName="Comando_Registrar"  />
        </div>
    </form>
</body>
</html>
