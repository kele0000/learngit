using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmModel
{/// <summary>
/// 模型类：购物车
/// </summary>
    public class ShopCar
    { /// <summary>
    ///构造：创建购物车对象
    /// </summary>
        public ShopCar() { }


        /// <summary>
        /// 构造：根据指定的数据创建购物车对象
        /// </summary>
        /// <param name="Filmid">电影编号</param>
        /// <param name="title">电影名称</param>
        /// <param name="price">价格</param>
        /// <param name="count">数量</param>
        /// <param name="cover">封面</param>
        public ShopCar(string Filmid, string title, decimal price, int count, string cover)
        {
            FilmID = Filmid;
            Title = title;
            Price = price;
            Count = count;
            Cover = cover;
        }


        /// <summary>
        /// 属性：电影编号
        /// </summary>
        public string FilmID { get; set; }

        /// <summary>
        /// 属性：电影名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 属性：电影价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 属性：购买数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 属性：电影封面
        /// </summary>
        public string Cover { get; set; }
    }
}