using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Transport_Logistics.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }

        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey(nameof(Destination))]
        public Guid DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}