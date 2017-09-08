using System;
using System.Collections.Generic;

namespace TestData_Dal
{
    using TestData_Model;//引用实体层的类
    /// <summary>
    /// 会员数据层，这里用一个静态类来演示
    /// 在这一层可以访问数据，获得实际应用中所需要的数据
    /// </summary>
    public static class MemberDB
    {
        //瘾式的构造函数
        //利用【对象初始化器】，生成一些测试数据出来，18条会员数据
        private static List<Member> members = new List<Member>
        {
            new Member{ID = 1,Name="王小红",Gender=false,Birthday= DateTime.Parse("1982-1-14"),Balance = 540,Address = "东风东路14号"},
            new Member{ID = 2,Name="陈芳",Gender=false,Birthday= DateTime.Parse("1978-6-19"),Balance = 121.8,Address = "北市区小康路33号，家园小区"},
            new Member{ID = 5,Name="李星",Gender=true,Birthday = DateTime.Parse("1977-6-22"),Balance = 258.66,Address = "云南|昆明|小西门家兴路55号，庆大小区"},
            new Member{ID = 15,Name="农正国",Gender=true,Birthday= DateTime.Parse("1993-01-08"),Balance = -9.8,Address = "云南农业大学"},
            new Member{ID = 23,Name="吴雨琴",Gender=false,Birthday= DateTime.Parse("1989-05-27"),Balance = 984.1,Address = "昆明市霖雨路嘉年华购物广场A座1202室"},
            new Member{ID = 6,Name="潘江涛",Gender=true,Birthday= DateTime.Parse("1995-10-25"),Balance = 51,Address = "云南工商学校"},
            new Member{ID = 3,Name="李进芬",Gender=false,Birthday= DateTime.Parse("1993-09-10"),Balance = 77,Address = "云南省普洱市景东县漫湾镇"},
            new Member{ID = 5,Name="庄贺云",Gender=true,Birthday= DateTime.Parse("1990-09-08"),Balance = 321.5,Address = "昆明市北市区红云小区1栋1单元302室"},
            new Member{ID = 8,Name="刘向东",Gender=true,Birthday= DateTime.Parse("1989-11-27"),Balance = 199.9,Address = "昆明市北市区德惠小区"},
            new Member{ID = 9,Name="李露",Gender=false,Birthday= DateTime.Parse("1990-08-18"),Balance = 0,Address = "昆明市五华区海源路假日城市小区"},
            new Member{ID = 11,Name="张旭东",Gender=true,Birthday= DateTime.Parse("1966-04-25"),Balance = 300,Address = "云南省昆明市寻甸县"},
            new Member{ID = 22,Name="刘姗姗",Gender=false,Birthday= DateTime.Parse("1984-05-02"),Balance = 33.33,Address = "云南省曲靖市罗平县"},
            new Member{ID = 33,Name="吴瑞",Gender=true,Birthday= DateTime.Parse("1986-08-16"),Balance = 850.5,Address = "云南宣威"},
            new Member{ID = 55,Name="陈雨勤",Gender=false,Birthday= DateTime.Parse("1986-08-08"),Balance = 261.3,Address = "云南省保山市龙陵县"},
            new Member{ID = 66,Name="刘振宇",Gender=true,Birthday= DateTime.Parse("1987-04-26"),Balance = 450,Address = "江苏省江阴市"},
            new Member{ID = 77,Name="李云",Gender=true,Birthday= DateTime.Parse("1985-05-16"),Balance = 117.5,Address = "云南省曲靖市麒麟区小区"},
            new Member{ID = 88,Name="马云",Gender=true,Birthday= DateTime.Parse("1964-05-16"),Balance = 999.99,Address = "昆明市北市区红锦路192号"},
            new Member{ID = 99,Name="陈小春",Gender=true,Birthday= DateTime.Parse("1976-11-19"),Balance = 2888.88,Address = "昆明市官渡区官南路188号，有钱人小区"}
        };

        /// <summary>
        /// 类的外部获得会员数据
        /// </summary>
        /// <returns></returns>
        public static List<Member> GetMemberList()
        {
            //返回会员列表数据
            return members;
        }
        /// <summary>
        /// 增加一个会员到会员表中，模拟数据库操作
        /// </summary>
        /// <param name="member"></param>
        /// <returns>0 = 增加失败；1 = 增加成功</returns>
        public static int AddMember(Member member)
        {
            if (member.ID==0 )
            {
                return 0;
            }
            members.Add(member);//实际业务中，对数据库的操作可以放在这里
            return 1;
        }
    }
    
}
