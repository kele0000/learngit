<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="GYFilmWeb.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>南方影院|注册</title> 
  <link rel="stylesheet" type="text/css" href="css/style.css"  />
<style>
body{height:100%;background:#16a085;overflow:hidden;}
canvas{z-index:-1;position:absolute;}
    .auto-style1 {
        left: 0px;
        top: 0px;
        width: 300px;
        height: 42px;
    }
    .auto-style2 {
        left: 0px;
        top: 0px;
        height: 83px;
    }
    .auto-style3 {
        color: #FF0066;
    }
</style>
<script src="js/jquery.js"></script>
<script src="js/verificationNumbers.js" ></script>
<script src="js/Particleground.js" ></script>
<script>
$(document).ready(function() {
  //粒子背景特效
  $('body').particleground({
    dotColor: '#5cbdaa',
    lineColor: '#5cbdaa'
  });
});
</script>
</head>
<body>
    <form id="form1" runat="server">
            <dl class="admin_login">
    <dt>
  <strong>南方影院</strong>
  <em>The southern theater</em> <span class="textWhite">
      <strong>注册</strong></span>
 </dt>
                
 <dd class="user_icon">
<asp:TextBox ID="txtUName" runat="server" class="login_txtbx" placeholder="昵称"></asp:TextBox>
 </dd>
 <dd class="user_icon">
<asp:TextBox ID="txtUid" runat="server" class="login_txtbx" placeholder="账号"></asp:TextBox>
 </dd>
 <dd class="pwd_icon" style="left: 0px; top: 0px; width: 300px">
<asp:TextBox ID="txtPwd" runat="server" class="login_txtbx" placeholder="密码" TextMode="Password"></asp:TextBox>
 </dd>
 <dd class="pwd_icon2" style="left: 0px; top: 0px; width: 300px">
<asp:TextBox ID="txtRPwd" runat="server" class="login_txtbx" placeholder="再次输入密码" TextMode="Password"></asp:TextBox>
 </dd>
                
 <dd class="pwd_icon3" style="left: 0px; top: 0px; width: 300px">
<asp:TextBox ID="txtEmail" runat="server" class="login_txtbx" placeholder="邮箱"></asp:TextBox>
 </dd><dd>
  &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMsg" runat="server" Text="" CssClass="auto-style3" ></asp:Label>

      </dd>
 <dd class="auto-style1">
     <asp:Button ID="btnInset" class="submit_btn" runat="server" Text="注  册" OnClick="btnInset_Click"  />
 </dd> <dd class="auto-style2">

<p>
                    <a href="http://www.gd-nf.com.cn/" target="_blank">南方宇宙学院</a>版权所有</p>
                <p>
                    服务热线：0756-6811222 0756-6813333</p>
                <p>
                    CopyRight &copy; 1996-2016 South Vocational College. All Rights Reserved.
                </p>
 </dd>

        </dl>
    </form>
</body>
</html>
