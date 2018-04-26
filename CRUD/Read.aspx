<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Read.aspx.cs" Inherits="CRUD.Read" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Read</h1>

            <asp:DropDownList ID="ddlSubject" runat="server" AppendDataBoundItems="true">
                <asp:ListItem Text="<Default>" Value="0" />
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
