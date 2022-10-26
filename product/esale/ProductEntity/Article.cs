using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }

        [ForeignKey ("Colour")]
        public int ColourId { get; set; }
        public Colour Colour { get; set; }
    }
}
