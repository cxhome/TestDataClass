using System;

namespace TestData_Model
{
    /// <summary>
    /// 会员实体类
    /// </summary>
    public class Member
    {
        #region  解释一下以前的类定义属性
        //3.0之前的用法
        //private int id;//定义 一个字段
        //public int ID //再定义一个属性访问器
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        #endregion
        /// <summary>
        /// 用户ID
        /// </summary>
        public int ID { get; set; }//3.0后新特性，自动属性
        /// <summary>
        /// 用户姓名
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 会员性别，false = 女，true = 男
        /// </summary>
        public bool Gender { get; set; } = false;//属性初始化值
        /// <summary>
        /// 会员生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 会员的账户余额
        /// </summary>
        public Double Balance { get; set; }
        /// <summary>
        /// 会员地址
        /// </summary>
        public string Address { get; set; }
    }
}
