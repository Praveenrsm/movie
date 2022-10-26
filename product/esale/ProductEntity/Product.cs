using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProductEntity
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int ProductYear { get; set; }
        public int ChannelId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }

        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public List<Article> articles { get ; set; } 
    }
}
