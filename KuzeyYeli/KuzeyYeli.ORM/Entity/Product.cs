using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; } //db de money tipi
        public short UnitInStock { get; set; } //db de smallint tipi
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string QuantityPerUnit { get; set; }
        public short ReorderLevel { get; set; }
        public short UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; } //db de bit tipi
    }
}
