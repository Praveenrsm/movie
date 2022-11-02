using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodCourtEntity
{
    public class FoodEntityEL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodId { get; set; }
        public int price { get; set; }
        public string FoodName { get; set; }
    }
}
