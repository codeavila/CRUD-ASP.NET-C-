<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tabla_Usuarios.aspx.cs" Inherits="CRUD.tabla_Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
            <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>
            <link rel="stylesheet" href="css.css"/>
   
         <title>EUAB - ASP.NET</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- NAVBAR -->
            <nav class='navbar navbar-default'>
                <div class='container-fluid'>
                    <a class='navbar-brand'>Bienvenido <strong><span id="span_Session_userName" runat="server"></span></strong></a>      
                    <asp:Button ID="btn_BackLogin" runat="server" class='btn navbar-btn btn-sm navbar-right' Text="Cerrar Sesion" OnCommand="btn_DoSwitchCase" CommandName="Comando_Back" />
                    <asp:Button ID="btn_Read" runat="server" class='btn navbar-btn btn-sm navbar-right' Text="Administracion" OnCommand="btn_DoSwitchCase" CommandName="Comando_Read" />                     
                </div>
            </nav>
        <!-- NAVBAR -->

        <!-- Tabla Usuario -->
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-6 col-lg-8 col-centered">
                     <table class="table table-hover table-condensed">
                        <asp:Repeater ID="rptTable" runat="server">
                            <HeaderTemplate>
                                    <tr>
                                          <th scope="row" >ID Usuario</th>
                                          <th>Nombre de Usuario</th>
                                          <th>Password</th>
                                          <th>Fecha de Creacion</th>
                                          <th>Fecha de Modificacion</th>
                                    </tr>
                            </HeaderTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <th scope="row" ><%# Eval("id_usuario") %></th>
                                        <td ><%# Eval("user_name") %></td>
                                        <td ><%# Eval("user_password") %></td>
                                        <td ><%# Eval("user_create_date") %></td>
                                        <td ><%# Eval("user_update_date") %></td>
                                        <td>
                                            <asp:Button ID="btn_Delete" runat="server" Text="Eliminar" class="btn btn-danger btn-xs"  OnCommand="btn_DoSwitchCase" CommandName="Comando_Delete" CommandArgument='<%# Eval("id_usuario") %>' />
                                        </td>
                                        <td>
                                            <asp:Button ID="btn_Read" runat="server" Text="Detalles" class="btn btn-warning btn-xs" OnCommand="btn_DoSwitchCase" CommandName="Comando_ShowDetail" CommandArgument='<%# Eval("id_usuario") %>' />
                                        </td>
                                        <td>
                                            <asp:Button ID="btn_Update" runat="server" Text="Actualizar" class="btn btn-info btn-xs" OnCommand="btn_DoSwitchCase" CommandName="Comando_Update" CommandArgument='<%# Eval("id_usuario") %>' />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            <FooterTemplate>
                   
                            </FooterTemplate>
                        </asp:Repeater>
                     </table>
                    </div>
                </div>
        </div>
        <!-- Tabla Usuario -->


        <div class="container">
            <div class="row">
                <div class="col-lg-6">
                    <div class="form-group">
                    <div class="input-group">
                        <asp:Label ID="lbl_FechaSeleccionadaIni" runat="server" Text="Fecha Inicio" CssClass="input-group-addon"></asp:Label>
                        <asp:TextBox ID="asp_FechaIni" runat="server" CssClass="form-control"></asp:TextBox>   
                            <span class="input-group-btn">
                                <asp:Button ID="Label2" runat="server" CssClass="btn btn-info" Text="Calendario"></asp:Button>
                                
                            </span>
                    </div>
                    <br />
                    <div class="input-group">
                        <asp:Label ID="lbl_FechaSeleccionadaFin" runat="server" Text="Fecha Inicio" CssClass="input-group-addon"></asp:Label>
                        <asp:TextBox ID="asp_FechaFin" runat="server" CssClass="form-control"></asp:TextBox>      
                        <span class="input-group-btn">
                                <asp:Button ID="Button1" runat="server"  Text="Calendario" CssClass="btn btn-info"></asp:Button>
                        </span>
                    </div>
                        <br/>
                    <asp:Button ID="btn_BusquedaPorFecha" runat="server" Text="Busqueda" OnCommand="btn_DoSwitchCase" CommandName="Comando_SearchDate" CssClass="btn btn-info"/>

                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" HIDDEN></asp:Calendar>
                    <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" HIDDEN></asp:Calendar> 
                    
                    </div>
                </div>
            
                <div class="col-lg-6">
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
            </div>
        
        
        </div>
    </form>
</body>
</html>
