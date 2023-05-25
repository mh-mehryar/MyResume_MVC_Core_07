using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Core_07.Models;
using System.Diagnostics;

namespace MVC_Core_07.Controllers
{
    //[Route("Inventory/products/{action}")]
    //[Route("Inventory/products")]
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"طلایی"),
            new Service(2,"الماس"),
            new Service(3,"نقره ای"),
            new Service(4,"پلاتین")
        };
        //[Route("MyIndex/{productName}/{model}")]
        public IActionResult Index(string productName, string model)
        {
            return View();
        }


        public IActionResult ProjectDetails(long id)
        {
            var projectById = Data.ProjectStore.GetProjectsBy(id);
            return View(projectById);
        }
        //[HttpGet("MyContact/{id}")]
        public IActionResult Contact(int id)
        {

            var model = new ContactForm
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}
        //[HttpPost]
        //public JsonResult Contact(ContactForm form)
        //{
        //    Console.WriteLine(form.ToString());
        //    return Json(Ok());
        //}

        [HttpPost]
		public IActionResult Contact(ContactForm model)
		{
			model.Services = new SelectList(_services, "Id", "Name");
			//if(ModelState.IsValid == false)
			if (!ModelState.IsValid)
			{
				ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید";
				return View(model);
			}

			ModelState.Clear();

			model = new ContactForm
			{
				Services = new SelectList(_services, "Id", "Name")
			};
			ViewBag.success = "پیغام شما با موفقیت ارسال شد. باتشکر";
			return View(model);
			//return RedirectToAction("Index");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}