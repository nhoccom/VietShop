﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }


        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(50)]
        public string Type { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }


    }
}