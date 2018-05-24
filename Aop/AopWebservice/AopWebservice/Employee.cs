using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AopWebservice
{
    public class Employee : MarshalByRefObject
    {
        public Employee() { }

        public string Name { get; set; }

        [AutoLogCallHandler()]
        public string Work()
        {
            return "Now  is working hard!";
            throw new Exception("Customer Exception");
        }

        [AutoLogCallHandler()]
        public override string ToString()
        {
            return string.Format("I'm {0}.", Name);
        }

    }
}