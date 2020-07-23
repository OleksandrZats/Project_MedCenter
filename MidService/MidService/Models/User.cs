using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MidService.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		public string FIO { get; set; }
		public string Email { get; set; }
		public string TNumber { get; set; }
		public string Gender { get; set; }
		public string Password { get; set; }
		public int Role { get; set; }

		public List<Order> Orders { get; set; }

	}
}
