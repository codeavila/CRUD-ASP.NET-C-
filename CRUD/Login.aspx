<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CRUD.Login"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
        <title>LOGIN EUAB - ASP.NET</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <div class="container">
               <h1>Login</h1>
            <div class="form-group">
                <asp:Label ID="lbl_UsuarioNombre" runat="server"  Text="Nombre de Usuario" ></asp:Label>
                <asp:TextBox ID="asp_UsuarioNombre" runat="server"  CssClass="form-control" ></asp:TextBox>
             </div>
             <div class="form-group">
                <asp:Label ID="lbl_UsuarioPassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="asp_UsuarioPassword" runat="server"  CssClass="form-control"  Type="password"></asp:TextBox>            
             </div>
             <div class="form-group">
                <asp:Button ID="btn_Ingresar" runat="server" Text="Ingresar" CssClass="btn btn-primary"  OnCommand="btn_LoginSwitchCase" CommandName="Comando_Ingresar"/>
                <asp:Button ID="btn_Registrar" runat="server" Text="Nuevo Usuario" CssClass="btn btn-warning"  OnCommand="btn_LoginSwitchCase" CommandName="Comando_Registrar"  />
                </div>
            </div>
        </div>
    </form>
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</body>
</html>
