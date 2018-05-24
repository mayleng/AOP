using AopWebservice.ServiceReference1;
using AopWebservice.WebReference;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AopWebservice
{
    public partial class Default : System.Web.UI.Page
    {
        private static LogWriter logWriter = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee emp = PolicyInjection.Create<Employee>();

            emp.Name = "Lele";

            emp.Work();

            Response.Write(emp);


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.com.webxml.www.WeatherWebService ws = new cn.com.webxml.www.WeatherWebService();

            string[] r = ws.getWeatherbyCityName(this.TextBox_CityName.Text);
            this.TextBox1.Text = " ";
            if (r == null)
            {
                this.TextBox1.Text = "无" + this.TextBox_CityName.Text + "城市的天气信息";
                return;
            }

            foreach (string i in r)
            {
                this.TextBox1.Text += i;
            }

            Employee emp = PolicyInjection.Create<Employee>();

            emp.Name = "weather";

            emp.Work();

            Response.Write(emp+"<br/>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WebService1 aa = new WebService1();
            this.TextBox4.Text = aa.AddString(this.TextBox2.Text, this.TextBox3.Text);

            Employee emp = PolicyInjection.Create<Employee>();

            emp.Name = "SelfDefine";

            emp.Work();

            Response.Write(emp);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            UserClient user = new UserClient();
            user.DoWork();
            string result = user.ShowName(this.TextBox5.Text);
            TextBox6.Text=result;
        }
    }
}