<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AgendaLucasTesteNoSSD.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br /><br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="E-mail"></asp:Label>
            <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
            <asp:TextBox ID="txbSenha" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="bt_Logar" runat="server" Text="Logar" OnClick="AçãoLogar" />
            <br /><br />
            <asp:Label ID="IMsg" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        </div>

    </form>
</body>
</html>
