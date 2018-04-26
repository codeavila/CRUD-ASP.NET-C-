<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PopulateDropDown.aspx.cs" Inherits="CRUD.PopulateDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table><tr>
<td><strong>Country :</strong></td>
<td>
    <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="True"  onselectedindexchanged="ddlCountry_SelectedIndexChanged"></asp:DropDownList>
   </td>
    <td><strong>State:</strong></td>
    <td><asp:DropDownList ID="ddlState" runat="server" AutoPostBack="True" onselectedindexchanged="ddlState_SelectedIndexChanged"></asp:DropDownList></td>
   <td><strong>City:</strong></td>
   <td><asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="True"> </asp:DropDownList></td>
    </tr>
  <tr><td><asp:Label ID="lblMsg" runat="server"></asp:Label>
     </td>
 </tr>  
 </table>
        </div>
    </form>
</body>
</html>
