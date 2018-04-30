<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowDetail.aspx.cs" Inherits="CRUD.ShowDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
        <title>Sistema EUAB</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Detalles de: </h1>          
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
        </div>
    </form>
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</body>
</html>
