using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HandsOnMvcClass.Entities
{
    public class Order
    {
        [Key]
        [StringLength(5)]
        [Column(TypeName = "char")]
        public string OrderId { get; set; }
        //[DataType(DataType.Date)]
        public DateTime OrderDate = DateTime.Now;
        public int Quantity { get; set; }
        [ForeignKey("ProductNavigation")]
        public string ProductId { get; set; }

        public Product ProductNavigation { get; set; }

    }
}