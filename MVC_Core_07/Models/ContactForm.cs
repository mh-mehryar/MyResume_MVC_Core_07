using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MVC_Core_07.Models
{
	public class ContactForm
	{
		[Required(ErrorMessage = "این فیلد اجباری است")]
		[MinLength(3, ErrorMessage = "حداقل طول نام، 3 کاراکتر است")]
		[MaxLength(100, ErrorMessage = "حداکثر طول نام، 100 کاراکتر است")]
		public string Name { get; set; }

		[Required(ErrorMessage = "این فیلد اجباری است")]
		[EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست")]
		public string Email { get; set; }

		public int Service { get; set; }
		public string Message { get; set; }
		public SelectList Services { get; set; }
	}
}
