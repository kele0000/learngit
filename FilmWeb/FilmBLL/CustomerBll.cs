using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBLL
{ /// <summary>
  /// 业务逻辑类：用户对象
  /// </summary>
    public class CustomerBLL
    {
        /// <summary>
        /// 方法：获取所有用户信息
        /// </summary>
        ///// <returns>用户信息集合</returns>
        //public List<FilmModel.Customer> GetCustomer()
        //{
        //   // return new FilmDAL.CustomerDAL().GetCustomer();
        //}

        /// <summary>
        /// 方法：获取用户的数量
        /// </summary>
        ///// <returns>用户的数量</returns>
        //public int GetCustomer2()
        //{
        //    return new FilmDAL.CustomerDAL().GetCustomer2();
        //}

        /// <summary>
        /// 方法：根据用户编号获取用户信息
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns>用户信息</returns>
        public FilmModel.Customer GetCustomer(string id)
        {
            return new FilmDAL.CustomerDAL().GetCustomer(" and [ID]='" + id + "'")[0];
        }

        /// <summary>
        /// 方法：找回用户登录密码
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <param name="question">保密问题</param>
        /// <param name="answer">答案</param>
        /// <returns>操作结果</returns>
        public FilmModel.Customer FindPassword(string loginName, string answer = null)
        {
            FilmModel.Customer customer = new FilmModel.Customer();
            List<FilmModel.Customer> cus = new FilmDAL.CustomerDAL().GetCustomer(" and LoginName = '" + loginName + "'");

            if (cus.Count == 0)
            {
                customer.LoginInfo = "账号不存在！";
                return customer;
            }


            if (answer != null)
            {
                if (cus[0].Answer != answer)
                    customer.LoginInfo = "答案错误！";
                else
                {
                    if (new FilmDAL.CustomerDAL().UpdateCustomer(new FilmModel.Customer() { ID = cus[0].ID, Password = Encryption("12345") }) > 0)
                    {
                        customer.LoginInfo = "密码重置成功！";
                    }
                    else
                        customer.LoginInfo = "密码重置失败！请联系管理员或再次尝试重置！";
                }

                return customer;
            }

            return cus[0];
        }

        /// <summary> 
        /// 方法：用户登录
        /// </summary>
        /// <param name="uid">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>用户对象</returns>
        public FilmModel.Customer Login(string uid, string pwd)
        {
            //加密密码
            pwd = Encryption(pwd);

            if (new Rule.CustomerRule().TestInsert(uid))
            {
                return new FilmModel.Customer() { ID = "", LoginInfo = "用户名不存在！" };
            }

            List<FilmModel.Customer> cus = new List<FilmModel.Customer>();
            cus = new FilmDAL.CustomerDAL().GetCustomer(" [LoginName]='" + uid + "' and [Password]='" + pwd + "'");

            if (cus.Count != 1)
            {
                return new FilmModel.Customer() { ID = "",LoginInfo  = "账号错误或者密码错误！" };
            }
            else
                return cus[0];

        }

        /// <summary>
        /// 方法：添加新用户
        /// </summary>
        /// <param name="cus">用户对象</param>
        /// <returns>添加操作结果</returns>
        public int InsertCustomer(FilmModel.Customer cus)
        {
            if (new Rule.CustomerRule().TestInsert(cus.LoginName)==false)
                return -3;
            cus.Password = Encryption(cus.Password);
            return new FilmDAL.CustomerDAL().InsertCustomer(cus);
        }

        /// <summary>
        /// 方法：更新用户信息
        /// </summary>
        /// <param name="cus">用户对象</param>
        /// <returns>更新操作结果</returns>
        public string UpdateCustomer(FilmModel.Customer cus)
        {
            if (!string.IsNullOrEmpty(cus.Password))
                cus.Password = Encryption(cus.Password);

            return Option(new FilmDAL.CustomerDAL().UpdateCustomer(cus), "更新");
        }

        /// <summary>
        /// 方法：删除用户信息
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns>删除操作结果</returns>
        public string DeleteCustomer(string id)
        {
            if (!new Rule.CustomerRule().TestDelete(id))
                return "该用户还有未处理的任务！暂时不能删除！";

            return Option(new FilmDAL.CustomerDAL().DeleteCustomer(id), "删除");
        }

        /// <summary>
        /// 方法：完成操作
        /// </summary>
        /// <param name="count">受影响的行数</param>
        /// <param name="type">操作类型</param>
        /// <returns>操作结果</returns>
        private string Option(int count, string type)
        {
            switch (count)
            {
                case -2:
                    return "数据库连接异常！请检查您的数据库或联系管理员！";
                case -1:
                    return "数据操作异常！请检查您的数据或联系管理员！";
                case 0:
                    return "没有" + type + "任何数据！";
                default:
                    return "成功" + type + count.ToString() + "条数据！";
            }
        }

        /// <summary>
        /// 方法：对密码进行MD5加密
        /// </summary>
        /// <param name="pwd">原始密码</param>
        /// <returns>加密后的密码</returns>
        private string Encryption(string pwd)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(pwd);
            bytes = md5.ComputeHash(bytes);
            return BitConverter.ToString(bytes);
        }
    }
}
