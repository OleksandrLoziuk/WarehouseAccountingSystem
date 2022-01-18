using System;
using System.ComponentModel.DataAnnotations;


namespace WarehouseAccountingSystem.Abstractions
{
    public interface IDbEntity
    {
        [Key]
        int Id { get; set; }
    }
}
