using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELSystem.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<EmpTB> Get()
        {
            using(EmployeeEntities entities=new EmployeeEntities())
            {
                return entities.EmpTBs.ToList();
            }
        }
    }

}
