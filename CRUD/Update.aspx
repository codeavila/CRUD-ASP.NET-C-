<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="CRUD.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>UPDATE VISTA</h1>

            <asp:TextBox ID="asp_UsuarioID" runat="server"  ></asp:TextBox>
            <asp:Label ID="lbl_UsuarioNombre" runat="server" Text="Nombre de Usuario"></asp:Label>
            <asp:TextBox ID="asp_UsuarioNombre" runat="server"></asp:TextBox>
            <asp:Label ID="lbl_UsuarioPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="asp_UsuarioPassword" runat="server"></asp:TextBox>

            <asp:Button ID="btn_Actualizar" runat="server" Text="Actualizar"  OnCommand="btn_LoginSwitchCase" CommandName="Comando_Update"/>
            <asp:Button ID="btn_Regresar" runat="server" Text="Regresar a la pagina anterior"  OnCommand="btn_LoginSwitchCase" CommandName="Comando_Back"/>
        </div>
    </form>
</body>
</html>
