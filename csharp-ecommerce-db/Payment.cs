using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    [Table("payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
