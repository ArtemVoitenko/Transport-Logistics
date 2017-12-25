using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transport_Logistics.Entities
{
    public class BookedCar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public decimal CargoMass { get; set; }
        public decimal Distance { get; set; }

        [ForeignKey(nameof(Car))]
        public Guid CarId { get; set; }
        public Car Car { get; set; }

        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}