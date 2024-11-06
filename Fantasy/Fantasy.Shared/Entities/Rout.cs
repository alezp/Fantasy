using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Shared.Entities
{
    public class Rout
    {
        [Key]
        public int RouteId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [Required]
        public string Coordinates { get; set; } // This would typically be a more complex type

        public TimeSpan EstimatedTime { get; set; }

        [Required]
        public string RouteStatus { get; set; } // on route, completed

    }
}
