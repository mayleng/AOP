using AopAlliance.Intercept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AopDemo
{
    // 通知者
    public class Advisor : IMethodInterceptor  // 使用环绕通知

    {
        public Minstrel Minstrel { set; get; }

        public object Invoke(IMethodInvocation invocation)
        {
            IKnight knight = invocation.Target as IKnight;  // 取得骑士
            this.Minstrel.singBefore(knight);               // 前置通知
            object result = invocation.Proceed();
            this.Minstrel.singAfter(knight);                // 后置通知

            return result;
        }
    }

    /*
    public class AdvisorBefore:
        Spring.Aop.IMethodBeforeAdvice, 
        Spring.Aop.IAfterReturningAdvice
    {
        public Minstrel Minstrel { set; get; }

        public void Before(System.Reflection.MethodInfo method, object[] args, object target)
        {
            this.Minstrel.singBefore(target as KnightOfTheRoundTable);
        }

        public void AfterReturning(object returnValue, System.Reflection.MethodInfo method, object[] args, object target)
        {
            this.Minstrel.singAfter(target as KnightOfTheRoundTable);
        }
    }

    public class AdvisorAfter :        
        Spring.Aop.IAfterReturningAdvice
    {
        public Minstrel Minstrel { set; get; }

        public void Before(System.Reflection.MethodInfo method, object[] args, object target)
        {
            this.Minstrel.singBefore(target as KnightOfTheRoundTable);
        }

        public void AfterReturning(object returnValue, System.Reflection.MethodInfo method, object[] args, object target)
        {
            this.Minstrel.singAfter(target as KnightOfTheRoundTable);
        }
    }
    */
}
