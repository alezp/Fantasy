using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Shared.Entities
{
    public class OrderAssigment
    {
        [Key]
        public int AssignmentId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Operator")]
        public int OperatorId { get; set; }
        public User Operator { get; set; }

        public DateTime AssignmentDate { get; set; }
    }
}
