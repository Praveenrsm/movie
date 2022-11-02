using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodCourtEntity
{
    public class FoodCategoryEL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodId { get; set; }
        public string Type { get; set; }
        public string FoodName { get; set; }
    }
}
