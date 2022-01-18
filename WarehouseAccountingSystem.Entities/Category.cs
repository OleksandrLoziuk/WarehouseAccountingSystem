using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseAccountingSystem.Abstractions;

namespace WarehouseAccountingSystem.Entities
{
    [Table("Categories")]
    public class Category:DbEntity
    {
        [Column("CategoryName")]
        [StringLength(50)]
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
