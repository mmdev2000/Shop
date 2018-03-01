using Shop.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Shop.Repo
{
	public static class DbInitialization
	{


		public async static void Initialize(this ApplicationContext context)
		{
			context.Database.EnsureCreated();
			var category = context.Set<Category>();
			// Look for any students.
			if (await category.AnyAsync())
			{
				return;   // DB has been seeded
			}

			var categories = new List<Category>();

			categories.Add(new Category { AddedDate = DateTime.Now, DisplayOrder = categories.Count, IsPublished = true, ModifiedDate = DateTime.Now.AddHours(1), Name = "cat_" + categories.Count, });
			categories.Add(new Category { AddedDate = DateTime.Now, DisplayOrder = categories.Count, IsPublished = true, ModifiedDate = DateTime.Now.AddHours(1), Name = "cat_" + categories.Count, });
			categories.Add(new Category { AddedDate = DateTime.Now, DisplayOrder = categories.Count, IsPublished = true, ModifiedDate = DateTime.Now.AddHours(1), Name = "cat_" + categories.Count, ParentCategory = categories[0] });

			categories.Add(new Category { AddedDate = DateTime.Now, DisplayOrder = categories.Count, IsPublished = true, ModifiedDate = DateTime.Now.AddHours(1), Name = "cat_" + categories.Count, });
			
			//categories.Add(new Category { AddedDate = DateTime.Now, DisplayOrder = categories.Count, IsPublished = true, ModifiedDate = DateTime.Now.AddHours(1), Name = "cat_" + categories.Count, 
			//	ParentCategoryId = categories[1].Id });
			categories.Add(new Category { AddedDate = DateTime.Now, DisplayOrder = categories.Count, IsPublished = false, ModifiedDate = DateTime.Now.AddHours(1), Name = "cat_" + categories.Count, });
			categories.Add(new Category { AddedDate = DateTime.Now, DisplayOrder = categories.Count, IsPublished = true, ModifiedDate = DateTime.Now.AddHours(1), Name = "cat_" + categories.Count, });
			categories.Add(new Category { AddedDate = DateTime.Now, DisplayOrder = categories.Count, IsPublished = false, ModifiedDate = DateTime.Now.AddHours(1), Name = "cat_" + categories.Count, });
			category.AddRange(categories);
			context.SaveChanges();
		}

	}
}
