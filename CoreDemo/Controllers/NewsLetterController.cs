﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}

		[HttpPost]
		public IActionResult SubscribeMail(NewsLetter p)
		{
			p.MailStatus = true;
			nm.AddNewsLetter(p);
			return RedirectToAction("Index", "Blog");
		}
	}
}
