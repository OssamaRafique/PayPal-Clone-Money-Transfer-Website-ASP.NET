<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Project.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="styles/forms.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <div class="login-page">
  <div class="form">
    <form class="login-form" style="margin-top:100px">
        <h2>Login</h2>
        <asp:Label ID="lblmsg" CssClass="lblerror" runat="server" Text=""></asp:Label>
        <div id="mtop" runat="server">
        <asp:TextBox ID="txtusername" runat="server" placeholder="Username"></asp:TextBox>
        <asp:TextBox ID="txtpassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnlogin" runat="server" Text="Login" class="btnclass" OnClick="btnlogin_Click"/>
      <p class="message">Not registered? <a href="/register">Create an account</a></p>
        </div>
    </form>
  </div>
</div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
        </div>
    </form>
</body>
</html>
