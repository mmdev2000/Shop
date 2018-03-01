using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Repo;
using Shop.Service;
using Shop.Web.Models;

namespace Shop.Web.Controllers
{
	public class CategoryController : BaseController
	{
		private readonly ICategoryService categoryService;
		private readonly ApplicationContext context;

		public CategoryController(ICategoryService categoryService,ApplicationContext context)
		{
			this.categoryService = categoryService;
			this.context = context;
			context.Initialize();
		}

		[HttpGet]
		public IActionResult Index()
		{
			List<CategoryViewModel> model = new List<CategoryViewModel>();
			categoryService.GetCategories().ToList().ForEach(c =>
			{
				Category parentCategory = null;
				if (c.ParentCategoryId.HasValue)
					parentCategory = categoryService.GetParentById(c.ParentCategoryId.Value);
				CategoryViewModel cat = new CategoryViewModel
				{
					Id = c.Id,
					Name = c.Name,
					IsPublished = c.IsPublished,
					ParentCategoryName = c.ParentCategory?.Name,
					ParentCategoryId = c.ParentCategoryId
				};
				model.Add(cat);
			});

			return View(model);
		}
	}
}