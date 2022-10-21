using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace movieentity1
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Booking")]
        public int BookingId { get; set; }

        public Booking booking { get; set; }
        //[ForeignKey("User")]
        //public int UserId { get; set; }
        //public User user { get; set; }
        public Location  location{ get; set; }
    }
}
