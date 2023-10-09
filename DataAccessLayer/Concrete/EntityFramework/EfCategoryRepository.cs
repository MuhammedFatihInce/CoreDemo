using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
	public class EfCategoryRepository:GenericRepository<Category>, ICategoryDal
	{
		public int CategoryCount()
		{
			using (var c = new Context())
			{
				return c.Categories.Count();
			}
		}
	}
}
