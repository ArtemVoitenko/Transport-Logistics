using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transport_Logistics.Entities
{
    public class CarDirectory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string CarBrand { get; set; }
        public int CarryingCapacity { get; set; }
        public decimal Price { get; set; }
    }
}