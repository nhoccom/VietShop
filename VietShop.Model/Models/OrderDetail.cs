﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VietShop.Model.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        [Column(Order=1)]
        public int OrderID { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        public int? Quanlity { set; get; }
    }
}