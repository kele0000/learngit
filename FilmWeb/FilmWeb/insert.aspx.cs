using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GYFilmWeb
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUName.Text.Trim()) || string.IsNullOrEmpty(this.txtPwd.Text.Trim()) || string.IsNullOrEmpty(this.txtEmail.Text.Trim()) || string.IsNullOrEmpty(this.txtUid.Text.Trim()))
            {
                lblMsg.Text = "请输入完整的信息！！！";
                return;
            }
            else if (this.txtPwd.Text != this.txtRPwd.Text)
            {
                lblMsg.Text = "请输入相同的密码！";
                return;
            }

            else
            {
                //将用户输入的信息放到对应的类
                FilmModel.Customer cur = new FilmModel.Customer();
                cur.ID = Guid.NewGuid().ToString();
                cur.LoginName = txtUid.Text.Trim().ToLower();
                cur.Password = txtPwd.Text;
                cur.CustomerName = txtUName.Text;
                cur.Email = txtEmail.Text;
                //引用逻辑层方法 用count接收方法的返回值
                int count = new FilmBLL.CustomerBLL().InsertCustomer(cur);
                //判断count的值来判断用户验证信息
                switch (count)
                {
                    case -3:
                        lblMsg.Text = "您输入的账号已经存在！<br/>";
                        break;
                    case -2:
                        lblMsg.Text = "数据库连接失败！<br/>请检查您的数据库或联系管理员！";
                        break;
                    case -1:
                        lblMsg.Text = "数据库连接失败！<br/>请检查您的数据库或联系管理员！";
                        break;
                    case 0:
                        lblMsg.Text = "注册失败！<br/>请检查您输入的数据！";
                        break;
                    default:
                        //Session["Customer"] = cur;
                        //Session["ShopCar"] = new List<Model.ShopCar>();
                        lblMsg.Text = "注册成功！您可以<a href='Login.aspx'>登录</a>或者<a href='Login.aspx'>完善信息</a>";
                        txtUid.Text = "";
                        txtPwd.Text = "";
                        txtUName.Text = "";
                        txtEmail.Text = "";
                        break;
                }
            }
        }
    }
}