using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseAccountingSystem.Abstractions;

namespace WarehouseAccountingSystem.Entities
{
    [Table("Balance")]
    public class Balance:DbEntity
    {
        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("Amount")]
        public decimal Amount { get; set; }

        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
