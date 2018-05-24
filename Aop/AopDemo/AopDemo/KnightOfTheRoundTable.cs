using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AopDemo
{
    // 定义被代理方法的接口
    public interface IKnight
    {
        String Name { set; get; }
        HolyGrail embarkOnQuest();
    }

    // 被代理的方法必须通过接口实现
    public class KnightOfTheRoundTable : IKnight

    {
        public String Name { set; get; }
        public IQuest Quest { set; get; }

        public HolyGrail embarkOnQuest()
        {
            return Quest.Embark();
        }
    }
}
