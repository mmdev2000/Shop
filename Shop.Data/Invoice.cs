using Shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data
{
    public class Invoice:BaseEntity
    {
		
		public User User { get; set; }
		public int UserId { get; set; }

		public DateTime CreateDate{ get; set; }
		public string PaidTransactionId{ get; set; }
		public DateTime? PaidDate { get; set; }
		public decimal TotalProductPrice{ get; set; }
		public decimal Tax{ get { return TotalProductPrice * 0.09m; } }
		public decimal ShipmentPrice{ get; set; }
		public decimal CouponDiscount{ get; set; }
		public string CouponId{ get; set; }
		public decimal InvoicePrice { get { return TotalProductPrice + Tax - CouponDiscount + ShipmentPrice; } }
		public InvoiceStatus Status{ get; set; }
	}
}
