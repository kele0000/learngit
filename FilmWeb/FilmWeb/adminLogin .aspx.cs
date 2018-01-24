using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GYFilmWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load2(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click2(object sender, EventArgs e)
        {  
            if (string.IsNullOrEmpty(this.txtUserName2.Text.Trim()) || string.IsNullOrEmpty(this.txtPwd2.Text.Trim()))
            {
                lblMsg2.Text = "请输入您的账号和密码！不能为空！！";
                return;
            }
            //验证用户名和密码：返回一个用户对象或字符串
            FilmModel.Customer cu = new FilmBLL.CustomerBLL().Login(txtUserName.Text.Trim().ToLower(), txtPwd.Text.Trim());
                if (string.IsNullOrEmpty(cu.LoginInfo))
                {
                ////保存用户状态 设置购物车
                cu.Password = null;
                Session["Customer"] = cu;
                Session["ShopCar"] = new List<FilmModel.ShopCar>();
                //创建用户Cookie
                HttpCookie cook = new HttpCookie("LoginName", cu.LoginName);
                cook.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cook);
                Response.Write("<script>alert('管理员登录成功！进入管理员界面....');window.location.href ='admin.html'</script>");
            
            }
                else
                {
                    lblMsg.Text = cu.LoginInfo;
                return;
                
            }
            
        }
    }
    
}