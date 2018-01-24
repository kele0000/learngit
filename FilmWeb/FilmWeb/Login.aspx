<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GYFilmWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>南方影院|用户登录</title>
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
  //验证码
  createCode();
  //测试提交，对接程序删除即可
  $(".submit_btn").click(function(){
	  location.href="javascrpt:;"/*tpa=http://***index.html*/;
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
      <strong>登录</strong></span>
 </dt>
 <dd class="user_icon">
            <asp:TextBox  placeholder="账号" class="login_txtbx" id="txtUserName" runat="server"></asp:TextBox>
 </dd>
 <dd class="pwd_icon" style="left: 0px; top: 0px; width: 300px">
    <asp:TextBox  placeholder="密码" class="login_txtbx" id="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
 </dd>
 <dd class="auto-style1">
     <asp:Button ID="btnLogin" class="submit_btn" runat="server" Text="立即登录" OnClick="btnLogin_Click1" />
 </dd><dd>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblMsg" runat="server" Text="" CssClass="auto-style2" ></asp:Label>

      </dd>
            <dd>
                 
                    没有账号？<asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="~/insert.aspx">注册</asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    忘记密码？<asp:HyperLink ID="HyperLink2" runat="server" >找回</asp:HyperLink>
                  &nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp &nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp &nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp<asp:HyperLink ID="admin" runat="server" NavigateUrl="~/aLogin .aspx" > 管理员登录</asp:HyperLink>
           </dd>
 <dd>

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
