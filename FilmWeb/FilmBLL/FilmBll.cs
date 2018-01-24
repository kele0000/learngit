using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBLL
{
    public class FilmBll
    {
        /// <summary>
        /// 方法：获取所有图书信息
        /// </summary>
        /// <returns></returns>
        public List<FilmModel.Film> GetFilm()
        {
            return new FilmDAL.Filmdal().GetFilm();
        }

        public List<FilmModel.Film> GetFilms(int categoryID = 0, int page = 0)
        {
            string where = "";

            if (categoryID > 0)
                where += " and [CategoryID]=" + categoryID;

            //return new DAL.BookDAL().GetBook(where,(page+1)*10,(page+2)*10);
            return new FilmDAL.Filmdal().GetFilms(where, 1, 100);
        }

        /// <summary>
        /// 获取图书的ID，显示选中ID电影信息
        /// </summary>
        /// <param name="id">点击的ID</param>
        /// <returns></returns>
        public FilmModel.Film GetFilm(string id)
        {
            return  new FilmDAL.Filmdal().GetFilm("where [FID]=" + id )[0];
        }
    }
}