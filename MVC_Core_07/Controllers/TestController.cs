using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace MVC_Core_07.Controllers
{
	public class TestController : Controller
	{
		public FileResult Index()
		{
			var fileByte = System.IO.File.ReadAllBytes("wwwroot/mhresume.txt");
			const string fileName = "Resume.txt";
			return File(fileByte, MediaTypeNames.Text.Plain, fileName);
		}

		//public JsonResult Index()
		//{
		//	return Json(new
		//	{
		//		id= 64,
		//		name ="Mohammad Hoseein",
		//		job ="Developer"

		//	});
		//}

		//public JavascriptResult Index()
		//{
		//	return new JavascriptResult("alert('Hi EveryBody .....')");
		//}

		//public IActionResult Index()
		//{
		//	//return new OkResult();
		//	return new NotFoundResult();
		//	//return new BadRequestResult();
		//	//return new NoContentResult();
		//	//return new StatusCodeResult(89654);
		//}
	}

	//public class JavascriptResult : ContentResult
	//{
	//	public JavascriptResult(string data)
	//	{
	//		Content = data;
	//		ContentType = "Application/Javascript";

	//	}
	//}
}
