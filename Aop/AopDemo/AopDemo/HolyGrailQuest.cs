using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AopDemo
{
    public interface IQuest
    {
        HolyGrail Embark();
    }

    public class HolyGrailQuest : IQuest

    {
        public HolyGrail Embark()
        {
           // Console.WriteLine("探险任务中......");
            return new HolyGrail();
        }
    }
}
