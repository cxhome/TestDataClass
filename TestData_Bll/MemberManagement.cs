using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestData_Bll
{
    using TestData_Model;//会员实体
    using TestData_Dal;//会员数据库访问
    /// <summary>
    /// 会员管理，业务逻辑 bll 类
    /// </summary>
    public class MemberManagement
    {
        /// <summary>
        /// 返回会员数据
        /// </summary>
        /// <returns></returns>
        public List<Member> GetMembersList()
        {
            return MemberDB.GetMemberList();
        }

        /// <summary>
        /// 通过会员ID返回一个会员的实例
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Member GetMember(int id)
        {
            Member member = new Member();
            //var member = member.Where<>
            var querymember = MemberDB.GetMemberList().Select(c => c.ID == id);

            return member;
        }
    }
}
