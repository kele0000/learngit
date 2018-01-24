using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GYFilmWeb
{
    public partial class movie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbl.Text = "1";
                //加载方法
               BindRepeater();
            }

        }
        protected void BindRepeater()
        {   //分页方法
            PagedDataSource pd = new PagedDataSource();
            pd.AllowPaging = true;
            pd.PageSize = 5;
            FilmBLL.FilmBll bookBLL = new FilmBLL.FilmBll();

            if (string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                pd.DataSource = new FilmBLL.FilmBll().GetFilm();
            }
            else
            {
                int id = int.Parse(Request.QueryString["ID"]);
                pd.DataSource = new FilmBLL.FilmBll().GetFilms(id);
            }

            int index = int.Parse(lbl.Text);
            if (index < 1)
                index = 1;
            if (index > pd.PageCount)
                index = pd.PageCount;
            pd.CurrentPageIndex = index - 1;

            ViewState["Index"] = index;
            lbl.Text = index.ToString();
            dgdShowFilm.DataSource = pd;
            dgdShowFilm.DataBind();
 lblCuont.Text = pd.PageCount + "";
        }

        protected void btnPre_Click(object sender, EventArgs e)
        {

            lbl.Text = (int.Parse(lbl.Text) - 1) + "";
            BindRepeater();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            lbl.Text = (int.Parse(lblCuont.Text) + 1) + "";
            BindRepeater();
        }

        protected void dgdShowFilm_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            FilmModel.Customer cus = Session["Customer"] as FilmModel.Customer;
            if (cus == null)
            {
                Response.Write("<script>alert('请登录后，进入购物....');window.location.href ='Login.aspx'</script>");

                return;
            }
            FilmModel.Film Film = new FilmBLL.FilmBll().GetFilm(e.CommandName);
            if (Film != null)
            {
                if ((((List<FilmModel.ShopCar>)Session["ShopCar"]).Count > 0))
                {
                    foreach (FilmModel.ShopCar s in (List<FilmModel.ShopCar>)Session["ShopCar"])
                        if (s.FilmID == Film.FID)
                        {
                            s.Count += 1;
                            return;
                        }
                }
            }
                ((List<FilmModel.ShopCar>)Session["ShopCar"]).Add(new FilmModel.ShopCar() { FilmID = Film.FID, Title = Film.FTitle, Count = 1, Price = Film.FPrice, Cover = Film.ISBN });
               ((HyperLink)(Master).FindControl("ShopCar")).Text = "购物车[" + ((List<FilmModel.ShopCar>)Session["ShopCar"]).Count + "]";
        }
    }
}