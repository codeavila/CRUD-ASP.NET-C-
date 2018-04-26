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

            <asp:DropDownList ID="DropDown_UserName" runat="server" OnSelectedIndexChanged="DropDown_UserName_SelectedIndexChanged">
                <asp:ListItem Text="<Select Subject>" Value="0" />
            </asp:DropDownList>

            



        </div>
    </form>
</body>
</html>
