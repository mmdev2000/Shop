using System;

namespace Shop.Data.Enums
{
	public enum ShipmentMethods
	{
		Post = 0,
		Inperson = 1,
	}
	public enum ProductType
	{
		File = 0,
		Physical = 1
	}
	public enum ProductStatus
	{
		CommingSoon = 0,
		Stock = 1,
		Sold = 2
	}

	public enum InvoiceStatus
	{
		PendingPayment = 0,
		Paid = 1,
		sending = 2,
		Sent = 3,
		Delivered = 4,
		Cancel = 5
	}

}
