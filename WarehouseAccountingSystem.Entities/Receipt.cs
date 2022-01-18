using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseAccountingSystem.Abstractions;

namespace WarehouseAccountingSystem.Entities
{
    [Table("Receipts")]
    public class Receipt:DbEntity
    {
        [Column("ReceiptQuantity")]
        public int ReceiptQuantity { get; set; }

        [Column("ReciptAmount")]
        public decimal ReceiptAmount { get; set; }

        [Column("ReceiptDate")]
        public DateTime ReceiptDate { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
