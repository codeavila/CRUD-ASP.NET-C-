<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="CRUD.Read" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Nombre de Usuario</h1>
        <asp:DropDownList ID="DropDown_Usuarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDown_Usuarios_SelectedIndexChanged"></asp:DropDownList>
        <h2>Passord del Usuario</h2>
        <asp:DropDownList ID="DropDown_Passwords" runat="server"></asp:DropDownList>

    </form>

</body>
</html>
