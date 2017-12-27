<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Project.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link rel="stylesheet" href="styles/forms.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>

              <div class="login-page">
  <div class="form">
    <form class="login-form" style="margin-top:100px">
        <h2>Register</h2>
        <asp:Label ID="lblmsg" CssClass="lblerror" runat="server" Text=""></asp:Label>
        <div id="mtop" runat="server">
        <asp:TextBox ID="txtfullname" runat="server" placeholder="Full Name"></asp:TextBox>
        <asp:TextBox ID="txtusername" runat="server" placeholder="Username"></asp:TextBox>
        <asp:TextBox ID="txtemail" runat="server" placeholder="Email"></asp:TextBox>
        <asp:TextBox ID="txtpassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtrepeatpassword" runat="server" placeholder="Repeat Password" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtmobile" runat="server" placeholder="Mobile Number"></asp:TextBox>
        <asp:Button ID="btnregister" runat="server" Text="Register" class="btnclass" OnClick="btnregister_Click"/>
      <p class="message">Already registered? <a href="/login">Login here</a></p>
        </div>
    </form>
  </div>
</div>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
        </div>
    </form>
</body>
</html>
