using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models
{
   
	public class CategoryViewModel
	{
		[HiddenInput]
		public Int64 Id { get; set; }

		[Display(Name = "Parnt Name")]
		public string ParentCategoryName { get; set; }

		[HiddenInput]
		public Int64? ParentCategoryId { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }

		[Display(Name = "Added Date")]
		public DateTime AddedDate { get; set; }

		[Display(Name = "Is Published")]
		public bool IsPublished { get; set; }

		[Display(Name = "Display Order")]
		public int DisplayOrder { get; set; }

	}
}
