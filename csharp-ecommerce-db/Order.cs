using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    [Table("order")]
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<Payment> Payments { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public List<Product> Products { get; set; }
    }
}
