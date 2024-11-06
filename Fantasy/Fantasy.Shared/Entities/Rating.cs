using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Shared.Entities;

public class Rating
{
    [Key]
    public int RatingId { get; set; }

    [Required]
    public int Score { get; set; } // Rating score

    [Required]
    [StringLength(500)]
    public string Comment { get; set; }

    [ForeignKey("User")]
    public int CustomerId { get; set; }

    public User Customer { get; set; }

    [ForeignKey("User")]
    public int DriverId { get; set; }

    public User Driver { get; set; }

    public DateTime RatingDate
    {
        get; set;
    }
}        