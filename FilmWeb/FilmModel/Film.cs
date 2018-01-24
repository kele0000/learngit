using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmModel
{
    /// <summary>
    /// 模型类：电影
    /// </summary>
    [Serializable]
    public class Film
    {
        /// <summary>
        /// 构造：创建电影对象
        /// </summary>
        public Film() { }

        /// <summary>
        /// 构造：根据指定数据创建图书对象
        /// </summary>
        /// <param name="id">电影编号</param>
        /// <param name="title">电影名称</param>
        /// <param name="typeid">电影类型</param>
        /// <param name="director">导演</param>
        /// <param name="actor">演员</param>
        /// <param name="publisherName">生产地</param>
        /// <param name="publishDate">上映日期</param>
        /// <param name="isbn">电影号</param>
        /// <param name="price">电影价格</param>
        /// <param name="FDesc">电影简介</param>

        /// <param name="TypeName">电影类型名称</param>
        public Film(string id, string title,string director, int typeid, string actor, string publisherName,string publishDate, string isbn, decimal price, string Fdesc, string TypeName)
        {
            FID = id;
            FTitle = title;
            Director = Director;
            FTypeID = typeid;
            Actor = actor;
            PublisherName = publisherName;
            PublishDate = publishDate;
            ISBN = isbn;
            FPrice = price;
            FDesc = Fdesc;
            FTypeName = TypeName;
        }

        /// <summary>
        /// 属性：电影编号
        /// </summary>
        public string FID { get; set; }

        /// <summary>
        /// 属性：电影名称
        /// </summary>
        public string FTitle { get; set; }

        /// <summary>
        /// 属性：导演
        /// </summary>
        public string Director { get; set; }

        /// <summary>
        /// 属性：电影类型
        /// </summary>
        public int FTypeID { get; set; }
        /// <summary>
        /// 属性：演员
        /// </summary>
        public string Actor { get; set; }

        /// <summary>
        /// 属性：生产地
        /// </summary>
        public string PublisherName { get; set; }

        /// <summary>

        /// 属性：上映日期
        /// </summary>
        public string PublishDate { get; set; }

        /// <summary>
        /// 属性：电影号
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// <summary>
        /// 属性：电影价格
        /// </summary>
        public decimal FPrice { get; set; }

        /// <summary>
        /// 属性：电影简介
        /// </summary>
        public string FDesc { get; set; }

        /// <summary>
        /// 属性：电影类型名称
        /// </summary>
        public string FTypeName { get; set; }

    }
}
