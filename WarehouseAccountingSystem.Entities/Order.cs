using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseAccountingSystem.Abstractions;

namespace WarehouseAccountingSystem.Entities
{
    [Table("Orders")]
    public class Order:DbEntity
    {
        [Column("Date")]
        public DateTime OrderDate { get; set; }
        public virtual User User { get; set; }
        public virtual List<StringsOrder> StringsOrders { get; set; }
    }
}
