﻿using Shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class Product:BaseEntity
    {
		public string Name { get; set; }
		public string Barcode { get; set; }
		public decimal Price { get; set; }
		public decimal Discount { get; set; }
		public int Weight{ get; set; }
		public int Quantity{ get; set; }
		
		public ProductStatus Status{ get; set; }

		public ProductType Type { get; set; }

		public Category Category { get; set; }
		public int CategoryId { get; set; }
	}
}
