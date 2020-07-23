using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MidService.Models
{
	public class Service
	{
		[Key]
		public int SeviceId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }

		public List<Order> Orders { get; set; }

	}
}
