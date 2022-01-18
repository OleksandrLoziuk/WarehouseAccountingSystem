using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseAccountingSystem.Abstractions;

namespace WarehouseAccountingSystem.Entities
{
    [Table("StringsOrders")]
    public class StringsOrder:DbEntity
    {
        [Column("OrderQuantity")]
        public int OrderQuantity { get; set; }

        [Column("OrderAmount")]
        public decimal OrderAmount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
