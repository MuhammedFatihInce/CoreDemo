using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IBlogDal : IGenericDal<Blog>
	{
		List<Blog> GetListWithCategory();
		List<Blog> GetListWithCategoryByWriter(int id);
		int BlogCount(Expression<Func<Blog, bool>> filter);
		int BlogCount();
	}
}
