﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService:IGenericService<Blog>
	{
		List<Blog> GetBlogListWithCategory();
		List<Blog> GetBlogListByWriter(int id);
		int BlogCountById(int id);
		int BlogCount();
	}
}
