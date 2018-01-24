using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDAL
{
    /// <summary>
    /// 对象操作类：电影
    /// </summary>
        public class Filmdal
    {
        /// <summary>
        /// 方法：查询电影信息
        /// </summary>
        /// <param name="whereStr">查询条件</param>
        public List<FilmModel.Film> GetFilm(string whereStr=null)
        {
            List<FilmModel.Film> Films = new List<FilmModel.Film>();

            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader("select * from vw_Film "+whereStr);

                if (dr != null)
                {
                    while (dr.Read())
                        Films.Add(new FilmModel.Film(
                            dr["FID"] as string,
                            dr["FTitle"] as string,
                            dr["Director"] as string, 
                            (int)dr["FTypeID"],
                            dr["Actor"] as string,
                            dr["PublisherName"] as string, 
                            dr["PublishDate"] as string,
                            dr["ISBN"] as string, 
                            (decimal)dr["FPrice"],
                            dr["FDesc"]as string,
                    dr["FTypeName"]as string));
                          
                }
                SQLHelp.CloseConnection();
            }

            return Films;
        }

        public List<FilmModel.Film> GetFilms(string whereStr = null,int start=1,int end=100)
        {
            List<FilmModel.Film> Films = new List<FilmModel.Film>();

            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader("select * from(select ROW_NUMBER() over(Order by FID) as FID, * from[vw_Film] where" + whereStr + ") as c where c.BID between " + start + " and " + end);

                if (dr != null)
                {
                    while (dr.Read())
                        Films.Add(new FilmModel.Film(
                            dr["FID"] as string,
                            dr["FTitle"] as string,
                            dr["Director"] as string,
                            (int)dr["FTypeID"],
                            dr["Actor"] as string,
                            dr["PublisherName"] as string,
                            dr["PublishDate"] as string,
                            dr["ISBN"] as string,
                            (decimal)dr["FPrice"],
                            dr["FDesc"] as string,
                    dr["FTypeName"] as string));

                }
                SQLHelp.CloseConnection();
            }

            return Films;
        }
    }
}
