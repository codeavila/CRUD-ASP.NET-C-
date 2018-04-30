<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabla_Usuarios.aspx.cs" Inherits="CRUD.tabla_Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
            <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>
         <title>EUAB - ASP.NET</title>
</head>

<body>
    <form id="form1" runat="server">
            <nav class='navbar navbar-default'>
                <div class='container-fluid'>
                    <a class='navbar-brand'>Bienvenido <strong><span id="span_Session_userName" runat="server"></span></strong></a>      
                    <asp:Button ID="btn_BackLogin" runat="server" class='btn navbar-btn btn-sm navbar-right' Text="Cerrar Sesion" OnCommand="btn_DoSwitchCase" CommandName="Comando_Back" />
                    <asp:Button ID="btn_Read" runat="server" class='btn navbar-btn btn-sm navbar-right' Text="Administracion" OnCommand="btn_DoSwitchCase" CommandName="Comando_Read" />                     
                </div>
            </nav>

        <div class="container-fluid">
           
            <asp:Repeater ID="rptTable" runat="server">
                <HeaderTemplate>
                    <table class="table">
                        <tr>
                          <th >ID Usuario</th>
                          <th >Nombre de Usuario</th>
                          <th >Password</th>
                          <th >Fecha de Creacion</th>
                          <th >Fecha de Modificacion</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td ><%# Eval("id_usuario") %></td>
                        <td ><%# Eval("user_name") %></td>
                        <td ><%# Eval("user_password") %></td>
                        <td ><%# Eval("user_create_date") %></td>
                        <td ><%# Eval("user_update_date") %></td>
                        <td>
                            <asp:Button ID="btn_Delete" runat="server" Text="Eliminar" OnCommand="btn_DoSwitchCase" CommandName="Comando_Delete" CommandArgument='<%# Eval("id_usuario") %>' />
                        </td>
                        <td>
                            <asp:Button ID="btn_Read" runat="server" Text="Detalles" OnCommand="btn_DoSwitchCase" CommandName="Comando_ShowDetail" CommandArgument='<%# Eval("id_usuario") %>' />
                        </td>
                        <td>
                            <asp:Button ID="btn_Update" runat="server" Text="Actualizar" OnCommand="btn_DoSwitchCase" CommandName="Comando_Update" CommandArgument='<%# Eval("id_usuario") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>

        <div class="container">
        <asp:Label ID="lbl_BusquedaUsuarios" runat="server" Text="Busqueda de Usuarios Por Fecha"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="lbl_FechaSeleccionadaIni" runat="server" Text="Fecha Inicio"></asp:Label>
        <asp:TextBox ID="asp_FechaIni" runat="server"></asp:TextBox>

        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
        <asp:Label ID="lbl_FechaSeleccionadaFin" runat="server" Text="Fecha Final"></asp:Label>
        <asp:TextBox ID="asp_FechaFin" runat="server"></asp:TextBox>
        
        <h1>Busqueda Por Fecha</h1>
        <asp:Button ID="btn_BusquedaPorFecha" runat="server" Text="Busqueda" OnCommand="btn_DoSwitchCase" CommandName="Comando_SearchDate"/>

        <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table">
                        <tr>
                          <th >ID Usuario</th>
                          <th >Nombre de Usuario</th>
                          <th >Password</th>
                          <th >Fecha de Creacion</th>
                          <th >Fecha de Modificacion</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td ><%# Eval("id_usuario") %></td>
                        <td ><%# Eval("user_name") %></td>
                        <td ><%# Eval("user_password") %></td>
                        <td ><%# Eval("user_create_date") %></td>
                        <td ><%# Eval("user_update_date") %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
