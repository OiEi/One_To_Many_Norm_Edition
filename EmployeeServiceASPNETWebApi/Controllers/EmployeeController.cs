using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAcces;

namespace EmployeeServiceASPNETWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        
        //Создание тестовых таблиц
        [Route("api/CreateData")]
        public void Post()
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                Employee empl1 = new Employee { Name = "Роналду", Surname = "Иванов", Phone = "9624568546" };
                Employee empl2 = new Employee { Name = "Пётр", Surname = "Кувайцев", Phone = "3333333" };
                Employee empl3 = new Employee { Name = "Семён", Surname = "Кукуев", Phone = "22123213" };
                db.Employees.AddRange(new List<Employee> { empl1, empl2, empl3 });
                db.SaveChanges();

                Company c1 = new Company { CompanyId = 35 };
                c1.Employees.Add(empl1);
                c1.Employees.Add(empl2);
                db.Companies.Add(c1);
                db.SaveChanges();

                Company c2 = new Company { CompanyId = 1 };
                c2.Employees.Add(empl3);
                db.Companies.Add(c2);
                db.SaveChanges();
                

            }

        }
    }
}
