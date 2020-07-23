using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MidService.Models
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }
		public DateTime Date { get; set; }

		public int DoctorId { get; set; }
		public Doctor Doctor { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public int idService { get; set; }
		public Service Service { get; set; }
	}
}
