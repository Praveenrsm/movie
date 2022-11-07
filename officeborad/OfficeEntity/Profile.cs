using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OfficeEntity
{
    public class Profile
    {
        //[Key]
        //[Required]
        //public string UserId { get; set; }

        //[MaxLength(40)]
        [Key]
        public string Name { get; set; }

       // [MaxLength(40)]
        public string Position { get; set; }

        //[MaxLength(40)]
        public string Department { get; set; }
    }
}
