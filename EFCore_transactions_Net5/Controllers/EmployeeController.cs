using EFCore_transactions_Net5.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_transactions_Net5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public NORTHWNDContext DataContext = new NORTHWNDContext();

        [HttpGet]
        public object GetEmployees(int employeeId)
        {

            var transaction = DataContext.Database.BeginTransaction();

            try
            {
                var employees = DataContext.Employees.FirstOrDefault(f=> f.EmployeeId == employeeId);
                employees.FirstName = "Nancy";
                //employees.FirstName = "Pr " + employeeId + ".";
                DataContext.SaveChanges();
                transaction.Commit();
                return employees;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return null;
            }
           
        }
    }
}
