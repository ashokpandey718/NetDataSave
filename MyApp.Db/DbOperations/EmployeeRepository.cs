using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;
namespace MyApp.Db.DbOperations
{
   public class EmployeeRepository
    {
        public int AddEmployee(EmployeeModel model)
        {
            using (var context = new EmployeeDBEntities())
            {
                Employee emp = new Employee();
                {
                    emp.FirstName = model.FirstName;
                    emp.LastName = model.LastName;
                    emp.Email = model.Email;
                    emp.Code = model.Code;
                }
                context.Employee.Add(emp);
                context.SaveChanges();
                return emp.Id;
            }
            
        }
    }}
