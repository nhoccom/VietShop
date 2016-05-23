using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietShop.Model.Models
{
    [Table("Orders")]
   public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustormerName { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustormerAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustormerEmail { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustormerMobile { set; get; }

        [MaxLength(256)]
        public string CustormerMessage { set; get; }

        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }

        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail>  OrderDetails { set; get; }
            
    }
}
