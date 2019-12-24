using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAcces
{
    
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    }
    [Serializable]
    public class Company
    {
        public int Id { get; set; }
        public int Company_Id { get; set; }

        
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
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