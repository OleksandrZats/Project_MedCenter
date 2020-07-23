using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidService.ViewModels
{
	public class LoginModel
	{
		[Required(ErrorMessage = "Не указан E-Mail")]
		[DataType(DataType.EmailAddress, ErrorMessage = "Wrong email!")]
		[RegularExpression(@"^(([A-Za-z]{1})([\w\.]{1,})@([-\w]{1,}\.){1,}[-A-Za-z]{2,})$", ErrorMessage = "Password incorect.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Не указан пароль")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
