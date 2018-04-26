<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabla_Usuarios.aspx.cs" Inherits="CRUD.tabla_Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tabla Usuarios</h1>
            <asp:Button ID="btn_BackLogin" runat="server" Text="Regresar al Login" OnCommand="btn_DoSwitchCase" CommandName="Comando_Back" />
            <asp:Button ID="btn_Read" runat="server" Text="Leer BD" OnCommand="btn_DoSwitchCase" CommandName="Comando_Read" />
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
                            <asp:Button ID="btn_Read" runat="server" Text="Detalles" OnCommand="btn_DoSwitchCase" CommandName="Comando_Read" CommandArgument='<%# Eval("id_usuario") %>' />
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

        <asp:Label ID="lbl_BusquedaUsuarios" runat="server" Text="Busqueda de Usuarios Por Fecha"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="lbl_FechaSeleccionadaIni" runat="server" Text="Fecha Inicio"></asp:Label>
        <asp:TextBox ID="asp_FechaIni" runat="server"></asp:TextBox>

        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
        <asp:Label ID="lbl_FechaSeleccionadaFin" runat="server" Text="Fecha Final"></asp:Label>
        <asp:TextBox ID="asp_FechaFin" runat="server"></asp:TextBox>

    </form>
</body>
</html>
