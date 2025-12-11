using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }

    }
}
