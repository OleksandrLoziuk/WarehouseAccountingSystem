using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseAccountingSystem.Abstractions;

namespace WarehouseAccountingSystem.Entities
{
    [Table("Users")]
    public class User:DbEntity
    {
        [Column("UserName")]
        [StringLength(50)]
        public string UserName { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
