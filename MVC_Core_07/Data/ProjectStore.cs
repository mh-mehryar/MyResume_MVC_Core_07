namespace MVC_Core_07.Data;

public class ProjectStore
{
	public static List<Models.Project> GetProjects()
	{
		 return new List<Models.Project>
		{
			new Models.Project(1,"PetService","Take care about pets ...","pet.jpeg","MehPet"),
			new Models.Project(2,"BabyService","Take care about babies ...","baby.jpeg","MehBabe"),
			new Models.Project(3,"FlowerService","Take care about flowers ...","flower.jpeg","MehFlow"),
			new Models.Project(4,"PersonalService","Take care about personal ...","personal.jpeg","MehPer"),

		};
	}

	public static Models.Project GetProjectsBy(long id)
	{
		return GetProjects().FirstOrDefault(x => x.Id == id);
	}
}
