using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        
        public string Description { get; set; }

        public List<Sale> Sales { get; set; }



    }
}
