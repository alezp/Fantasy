using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Shared.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }

        [Required]
        [StringLength(200)]
        public required string Origin { get; set; }

        [Required]
        [StringLength(200)]
        public required string Destination { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public User Driver { get; set; }

        [ForeignKey("Operator")]
        public int OperatorId { get; set; }
        public User Operator { get; set; }

        [Required]
        public required string OrderStatus { get; set; } // Pendiente, Aceptado,  realizado o cancelado

        public required Rout Route { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
