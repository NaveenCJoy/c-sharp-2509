using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using webapitest.Models;

namespace webapitest.Controllers
{
    public class EmployeeController : Controller
    {
        IList<EmployeeClass> employees = new List<EmployeeClass>
        {
            new EmployeeClass { EmployeeID = 1, EmployeeName = "Naveen" },
            new EmployeeClass { EmployeeID = 2, EmployeeName = "abcd" }
        };

        public string GetEmployee()
        {
            return JsonConvert.SerializeObject(employees);
        }
        public string GetResult()
        {
            return "{\"name\":\"John\", \"age\":30, \"car\":null}";
        }

    }
}
