using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using Spring.Context.Support;
using Spring.Context;
using Spring.Aop.Framework;

namespace AopDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        IApplicationContext context= new XmlApplicationContext("~/objects.xml");

            IKnight knight = context.GetObject("knight") as IKnight;

            knight.embarkOnQuest();

           Thread.Sleep(10);
            // 创建代理工厂
           ProxyFactory pf = new ProxyFactory(knight);
            // 创建代理对象
            IKnight ic = pf.GetProxy() as IKnight;
            Response.Write(ic.GetType());
            Response.Write("<br/>");
            Response.Write(ic.Name);
            ic.embarkOnQuest();

        }

       
    }
}