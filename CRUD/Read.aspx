<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="CRUD.Read" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>LEER TODOS LOS ELEMENTOS</h1>
        <h2>Nombre del Usuario</h2>
        <asp:TextBox ID="asp_DetallesDelUSuario" runat="server"></asp:TextBox>
        <h1>Nombre de Usuario</h1>
        <asp:DropDownList ID="DropDown_Usuarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDown_Usuarios_SelectedIndexChanged"></asp:DropDownList>
        <h2>Passord del Usuario</h2>
       

            <h1>Datos de Usuario</h1>
            <asp:Label ID="lbl_UsuarioID" runat="server" Text="ID Usuario"></asp:Label>
                <asp:TextBox ID="asp_UsuarioID" runat="server"></asp:TextBox><br />  

            <asp:Label ID="lbl_UsuarioNombre" runat="server" Text="Nombre de Usuario"></asp:Label>
                <asp:TextBox ID="asp_UsuarioNombre" runat="server"></asp:TextBox><br />  

            <asp:Label ID="lbl_UsuarioPassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="asp_UsuarioPassword" runat="server"></asp:TextBox><br />

            <asp:Label ID="lbl_UsuarioFechaRegister" runat="server" Text="Fecha de Registro"></asp:Label>
                <asp:TextBox ID="asp_RegisterDate" runat="server"></asp:TextBox><br />

            <asp:Label ID="lbl_UsuarioFechaUpdate" runat="server" Text="Fecha de la Ultima Actualizacion"></asp:Label>
                <asp:TextBox ID="asp_UpdateDate" runat="server"></asp:TextBox><br />
            
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

            <asp:Label ID="lbl_Detail_usuarioEmail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="asp_Detail_usuarioEmail" runat="server"></asp:TextBox>


        <asp:Button ID="btn_Back" runat="server" Text="Regresar a las Tablas" OnClick="btn_Back_Click" />

    </form>

</body>
</html>
