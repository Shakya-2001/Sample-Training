using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMvcClass.Entities
{
    public class Product
    {
        //scalar property
        [Key]
        [StringLength(5)]
        [Column(TypeName = "char")]
        public string ProductId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
    }
}