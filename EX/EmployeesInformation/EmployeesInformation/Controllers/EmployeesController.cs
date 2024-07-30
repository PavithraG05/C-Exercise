using EmployeesInformation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesInformation.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase

    {
        [HttpGet]
        public JsonResult GetEmployees()
        {
            var employees = EmployeesDataStore.current.Employees;
            return new JsonResult(employees);
        }

        [HttpGet("{id}")]

        public ActionResult<Employee> GetSingleEmployees(int id)
        {
            var employee = EmployeesDataStore.current.Employees.FirstOrDefault(emp => emp.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
    }
}
