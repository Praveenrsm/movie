using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodCourtEntity
{
   public class salesEL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FoodName { get; set; }
        public int ActualPrice { get; set; }
        public int Discount { get; set; }
        public int TotalPrice { get; set; }
    }
}
