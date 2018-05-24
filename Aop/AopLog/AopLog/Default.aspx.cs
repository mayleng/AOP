using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AopLog
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
    }
}