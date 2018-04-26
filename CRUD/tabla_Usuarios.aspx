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
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td ><%# Eval("id_usuario") %></td>
                        <td ><%# Eval("user_name") %></td>
                        <td ><%# Eval("user_password") %></td>
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
    </form>
</body>
</html>
