using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class InvoiceItem:BaseEntity
    {

		public Invoice Invoice { get; set; }
		public int InvoiceId { get; set; }

		public Product Product{ get; set; }
		public int ProductId{ get; set; }
		
		public int Quantity{ get; set; }
		public decimal Price{ get; set; }
		public decimal Discount{ get; set; }
		public decimal TotalPrice { get { return (Price - Discount) * Quantity; } }

	}
}
