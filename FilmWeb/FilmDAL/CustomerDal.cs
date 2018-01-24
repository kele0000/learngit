using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FilmDAL
{
    /// <summary>
    /// 对象操作类：用户对象
    /// </summary>
    public class CustomerDAL
    {
        /// <summary>
        /// 方法：根据给定的条件查询用户信息
        /// </summary>
        /// <param name="whereStr">查询条件</param>
        /// <param name="start">开始行号</param>
        /// <param name="end">结束行号</param>
        /// <returns>用户信息集合</returns>
        public List<FilmModel.Customer> GetCustomer(string whereStr = null) { 
        
            List<FilmModel.Customer> customer = new List<FilmModel.Customer>();

            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader(" select * from [Customer] where " + whereStr + "");

                if (dr != null)
                {
                    while (dr.Read())
                        customer.Add(new FilmModel.Customer(dr["ID"] as string, dr["LoginName"] as string, dr["Password"] as string, dr["CustomerName"] as string,  dr["Email"] as string, dr["Question"] as string, dr["Answer"] as string, dr["Phone"] as string,  dr["Gender"] as string));
                }

                SQLHelp.CloseConnection();
            }

            return customer;
        }

        /// <summary>
        /// 方法：获取用户的数量
        /// </summary>
        /// <returns>用户的数量</returns>
        public int GetCustomer()
        {
            return (int)SQLHelp.ExecScalar("select count(*) from [Customer]");
        }

        /// <summary>
        /// 方法：添加用户信息
        /// </summary>
        /// <param name="cus">用户对象</param>
        /// <returns>添加结果</returns>
        public int InsertCustomer(FilmModel.Customer cus)
        {
            return SQLHelp.ExecQuery("Insert into [Customer]([ID],[LoginName],[Password],[CustomerName],[Email]) values('" + cus.ID + "','" + cus.LoginName + "','" + cus.Password + "','" + cus.CustomerName + "','" + cus.Email + "')");
        }

        /// <summary>
        /// 方法：更新用户信息
        /// </summary>
        /// <param name="cus">用户对象</param>
        /// <returns>更新结果</returns>
        public int UpdateCustomer(FilmModel.Customer cus)
        {
            string sql = "Update [Customer] set [State] = 0";

            if (!string.IsNullOrEmpty(cus.Password))
                sql += ",[Password]='" + cus.Password + "'";

            if (!string.IsNullOrEmpty(cus.CustomerName))
                sql += ",[CustomerName]='" + cus.CustomerName + "'";

            if (!string.IsNullOrEmpty(cus.Email))
                sql += ",[Email]='" + cus.Email + "'";

            if (!string.IsNullOrEmpty(cus.Question))
                sql += ",[Question]='" + cus.Question + "'";

            if (!string.IsNullOrEmpty(cus.Answer))
                sql += ",[Answer]='" + cus.Answer + "'";
            

            if (!string.IsNullOrEmpty(cus.Phone))
                sql += ",[Phone]='" + cus.Phone + "'";
            

            if (!string.IsNullOrEmpty(cus.Gender))
                sql += ",[Gender]='" + cus.Gender + "'";
            
            sql += " where [ID]='" + cus.ID + "'";
            return SQLHelp.ExecQuery(sql);
        }

        /// <summary>
        /// 方法：删除用户信息
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns>删除结果</returns>
        public int DeleteCustomer(string id)
        {
            return SQLHelp.ExecQuery("Update [Customer] set [State]=1 where [ID] in (" + id + ")");
        }
    }
}
