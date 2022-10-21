using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace movieentity
{
    public class MovieEL
    {
        
            [Key] 
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string Name { get; set; }
            public string MovieDesc { get; set; }
            public string MovieType { get; set; }
        
    }
}
