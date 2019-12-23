using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAcces
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Phone { get; set; }

        
        public virtual ICollection<Company> Companies { get; set; }

        public Employee()
        {
            Companies = new List<Company>();
        }
    }
    public class Company
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public Company()
        {
            Employees = new List<Employee>();
        }
    }






/*    public class EmployeePasport
    {
        [Key]
        [ForeignKey("Employee")]
        public int Id { get; set; }
        public string Type { get; set; }

        public string Number { get; set; }
        



    }*/










}