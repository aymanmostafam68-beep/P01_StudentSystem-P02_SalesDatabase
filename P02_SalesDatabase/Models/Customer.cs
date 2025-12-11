using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName ="varchar(80)")]
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
