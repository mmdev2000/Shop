using Shop.Data;
using System.Collections.Generic;

namespace Shop.Service
{
    public interface ICategoryService
    {
		Category GetParentById(long parentId);
		Category GetById(long id);
		IEnumerable<Category> GetCategories();

		void InsertCategory(Category category);
		void UpdateCategory(Category category);
		void DeleteCategory(Category category);
	}
}
