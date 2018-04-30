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
            <h1>Datos de Usuario</h1>
            <asp:Label ID="lbl_UsuarioNombre" runat="server" Text="Nombre de Usuario"></asp:Label>
            <asp:TextBox ID="asp_UsuarioNombre" runat="server"></asp:TextBox><br />  
            

            <asp:Label ID="lbl_UsuarioPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="asp_UsuarioPassword" runat="server"></asp:TextBox><br />  
            
            <h1>Datos de Personales</h1>
            <asp:Label ID="lbl_Detail_usuarioNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="aps_Detail_usuarioNombre" runat="server"></asp:TextBox><br />  

            <asp:Label ID="lbl_Detail_usuarioApellido" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="asp_Detail_usuarioApellido" runat="server"></asp:TextBox><br />  

            <asp:Label ID="lbl__Detail_usuarioTelefono" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="asp_Detail_usuarioATelefono" runat="server"></asp:TextBox><br />  

            <asp:Label ID="lbl__Detail_usuarioEstado" runat="server" Text="Estado"></asp:Label>
            <asp:TextBox ID="asp_Detail_usuarioEstado" runat="server"></asp:TextBox><br />  

            <asp:Label ID="lbl__Detail_usuarioCiudad" runat="server" Text="Ciudad"></asp:Label>
            <asp:TextBox ID="asp_Detail_usuarioCiudad" runat="server"></asp:TextBox><br />  
            <br />
            <asp:Label ID="lbl_messageEmailValidation" runat="server" Text=""></asp:Label>
            <asp:Label ID="lbl_Detail_usuarioEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="asp_Detail_usuarioEmail" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Registrar Nuevo" OnCommand="btn_LoginSwitchCase" CommandName="Comando_ValidarEmail"/>         
            <br />
            <asp:Button ID="btn_Registrar" runat="server" Text="Registrar Nuevo" OnCommand="btn_LoginSwitchCase" CommandName="Comando_Register"/>
            <asp:Button ID="btn_Regresar" runat="server" Text="Regresar a la pagina anterior"   OnCommand="btn_LoginSwitchCase" CommandName="Comando_Back"/>
        </div>
    </form>
</body>
</html>
