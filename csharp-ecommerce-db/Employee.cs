using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    [Table("employee")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }

        public List<Order> Orders { get; set; }

        public Employee(string name, string level)
        {
            Name = name;
            Level = level;
        }
    }
}
