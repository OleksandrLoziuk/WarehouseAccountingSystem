using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseAccountingSystem.Abstractions;

namespace WarehouseAccountingSystem.Entities
{
    [Table("Products")]
    public class Product:DbEntity
    {
        [Column("ProductName")]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Column("Cost")]
        public decimal Cost { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual Color Color { get; set; }
        public int ColorId { get; set; }
        public virtual List<Balance> Balance { get; set; }
        public virtual List<Receipt> Receipts { get; set; }
        public virtual List<StringsOrder> StringsOrders { get; set; }
    }
}
