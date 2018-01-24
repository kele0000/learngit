using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GYFilmWeb
{
    public partial class ShopCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
                BindRepeater();

                
        }
                    
        protected void BindRepeater()
        {
            if (Session["Customer"] == null)
            {
                Response.Write("<script>alert('亲，请您先登录账号..');window.location.href ='Login.aspx'</script>");
                return;
            }
            dgdShowFilm.DataSource = (List<FilmModel.ShopCar>)Session["ShopCar"];
            dgdShowFilm.DataBind();

            decimal total = 0;//计算总价
            foreach (FilmModel.ShopCar s in (List<FilmModel.ShopCar>)Session["ShopCar"])
            {
                total += s.Count * s.Price;
            }
            lblTotal.Text = string.Format("{0:C}", total);
            ((HyperLink)(Master).FindControl("ShopCar")).Text = "购物车[" + ((List<FilmModel.ShopCar>)Session["ShopCar"]).Count + "]";
        }

        protected void dgdShowFilm_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            foreach (FilmModel.ShopCar item in (List<FilmModel.ShopCar>)Session["ShopCar"])
            {
                if (item.FilmID == (string)e.CommandArgument)
                {
                    switch (e.CommandName)
                    {
                        case "Delete"://如果用户按了删除按钮时
                            ((List<FilmModel.ShopCar>)Session["ShopCar"]).Remove(item);
                            break;
                        case "Add"://如果用户按了添加按钮时
                            item.Count += 1;
                            break;
                        case "Cut"://如果用户按了减少按钮时
                            if (item.Count > 1)
                                item.Count -= 1;
                            break;
                    }
                    break;
                }
            }
            BindRepeater();
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            decimal total = 0;//计算总价
            foreach (FilmModel.ShopCar s in (List<FilmModel.ShopCar>)Session["ShopCar"])
            {
                total += s.Count * s.Price;
            }
            lblMsg.Text = "购买成功，您一共消费了 " + total + " 元";
        }
    }
}