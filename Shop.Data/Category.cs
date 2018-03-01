using System;

namespace Shop.Data
{
	public class Category:BaseEntity
	{
		public Category ParentCategory { get; set; }
		public Int64?	ParentCategoryId { get; set; }
		public string Name{ get; set; }
		public bool IsPublished{ get; set; }
		public int DisplayOrder{ get; set; }

	}
}