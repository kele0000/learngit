using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmModel
{

    /// <summary>
    /// 模型类：用户
    /// </summary>
    [Serializable]
    public class Customer
    {
        /// <summary>
        /// 构造：创建用户对象
        /// </summary>
        public Customer() { }

        /// <summary>
        /// 构造：根据给定的数据创建用户对象
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <param name="loginName">用户登录名</param>
        /// <param name="password">用户登录密码</param>
        /// <param name="customerName">用户姓名</param>
        /// <param name="email">电子邮箱地址</param>
        /// <param name="question">密保问题</param>
        /// <param name="answer">密保答案</param>
        /// <param name="phone">联系电话</param>
        /// <param name="gender">性别</param>
        public Customer(string id, string loginName, string password, string customerName, string email, string question, string answer, string phone, string gender)
        {
            ID = id;
            LoginName = loginName;
            Password = password;
            CustomerName = customerName;
            Email = email;
            Question = question;
            Answer = answer;
            Phone = phone;
            Gender = gender;
        }

        /// <summary>
        /// 属性：用户编号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 属性：用户登录名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 属性：用户登录密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 属性：用户姓名
        /// </summary>
        public string CustomerName { get; set; }


        /// <summary>
        /// 属性：电子邮箱地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 属性：密保问题
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// 属性：密保答案
        /// </summary>
        public string Answer { get; set; }



        /// <summary>
        /// 属性：联系电话
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// 属性：性别
        /// </summary>
        public string Gender { get; set; }
         
        /// <summary>
        /// 登录信息
        /// </summary>
        public string LoginInfo { get; set; }
    }
}

