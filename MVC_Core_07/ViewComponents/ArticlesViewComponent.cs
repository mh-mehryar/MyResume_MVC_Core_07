using Microsoft.AspNetCore.Mvc;
using MVC_Core_07.Models;

namespace MVC_Core_07.ViewComponents
{
	public class ArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			var articles = new List<Article>
			{
				new Article(1,"PetService","Take care about pets ...","blog-post-thumb-1.jpg"),
				new Article(2,"BabyService","Take care about babies ...","blog-post-thumb-2.jpg"),
				new Article(3,"FlowerService","Take care about flowers ...","blog-post-thumb-3.jpg"),
				new Article(4,"PersonalService","Take care about personal ...","blog-post-thumb-4.jpg"),
			};
			return View("_LatestArticles",articles);
		}


	}
}
