using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transport_Logistics.Entities
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey(nameof(CarBrand))]
        public Guid CarBrandId { get; set; }
        public CarDirectory CarBrand { get; set; }

        [ForeignKey(nameof(Driver))]
        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}