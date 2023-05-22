using Microsoft.AspNetCore.Mvc;
using MVC_Core_07.Models;

namespace MVC_Core_07.ViewComponents
{
	public class ProjectsViewComponent:ViewComponent
	{
		public	IViewComponentResult Invoke(string name)
		{
			var projects = new List<Project>
			{
				new Project(1,"PetService","Take care about pets ...","pet.jpeg","MehPet"),
				new Project(2,"BabyService","Take care about babies ...","baby.jpeg","MehBabe"),
				new Project(3,"FlowerService","Take care about flowers ...","flower.jpeg","MehFlow"),
				new Project(4,"PersonalService","Take care about personal ...","personal.jpeg","MehPer"),
				
			};
			return View("_Projects",projects);
		}
	}
}
