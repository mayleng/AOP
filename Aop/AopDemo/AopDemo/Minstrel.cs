using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AopDemo
{
    // 一个行吟诗人
    public class Minstrel
    {
        public string singBefore(IKnight knight)
        {
            return "Fa la la; Sir " + knight.Name + " is so brave!";
            
        }
        public string  singAfter(IKnight knight)
        {
            return "Tee-hee-he; Sir " + knight.Name + " did embark on a quest!";
        }
    }
}
