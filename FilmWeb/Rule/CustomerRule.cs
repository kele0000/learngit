using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    /// <summary>
    /// 业务规则类：用户对象
    /// </summary>
    public class CustomerRule
    {
        /// <summary>
        /// 方法：查询指定的用户名是否存在
        /// </summary>
        /// <param name="loginName">用户名字</param>
        /// <returns>是否存在</returns>
        public bool TestInsert(string loginName)
        {
            return (int)FilmDAL.SQLHelp.ExecScalar("select count(*) from [Customer] where [LoginName]='" + loginName+ "'") == 0;
        }

        /// <summary>
        /// 方法：查询指定的用户编号是否存在相关联的数据
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns>是否存在相关联的数据</returns>
        public bool TestDelete(string id)
        {
            return true;
        }
    }
}