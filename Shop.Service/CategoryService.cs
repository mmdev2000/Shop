using System;
using System.Collections.Generic;
using System.Text;
using Shop.Data;
using Shop.Repo;

namespace Shop.Service
{
	public class CategoryService : ICategoryService
	{

		private IRepository<Category> _categoryRepository;

		public CategoryService(IRepository<Category> categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public void DeleteCategory(Category category)
		{
			_categoryRepository.Remove(category);
		}

		public Category GetById(long id)
		{
			return _categoryRepository.Get(id);
		}

		public IEnumerable<Category> GetCategories()
		{
			return _categoryRepository.GetAll();
		}

		public Category GetParentById(long parentId)
		{
			return _categoryRepository.Get(parentId);
		}

		public void InsertCategory(Category category)
		{
			_categoryRepository.Insert(category);
		}

		public void UpdateCategory(Category category)
		{
			_categoryRepository.Update(category);
		}
	}
}
