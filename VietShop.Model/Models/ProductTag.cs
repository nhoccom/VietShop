﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VietShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order =1)]
        public int ProductID { set; get; }

        [Key]
        [Column(TypeName = "varchar", Order = 2)]
        [MaxLength(50)]
        public string TagID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}