using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseAccountingSystem.Abstractions;

namespace WarehouseAccountingSystem.Entities
{
    [Table("Colors")]
    public class Color:DbEntity
    {
        [Column("ColorName")]
        [StringLength(50)]
        public string ColorName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
