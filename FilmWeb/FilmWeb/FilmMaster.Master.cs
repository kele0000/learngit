using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GYFilmWeb
{
    public partial class FilmMaster1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        { 

            if (!IsPostBack && Session["Customer"] != null)
            {
                FilmModel.Customer cus = Session["Customer"] as FilmModel.Customer;
                hyLogin.Text =  cus.CustomerName + "|";
                btnEnd.Visible = true;
                IbtnUser.PostBackUrl = "";
                IbtnUser.ImageUrl = "~/images/icon-address.png";
            }
        }

        protected void btnEnd_Click(object sender, EventArgs e)
        {
            Session["Customer"] = null;
            Session["ShopCar"] = null;
            hyLogin.Text = "用户";
            IbtnUser.PostBackUrl = "Login.aspx";
            btnEnd.Visible = false;
            IbtnUser.ImageUrl = "~/images/用户.ico";
            ShopCar.Text = "购物车[0]";
        }
        
    }
}