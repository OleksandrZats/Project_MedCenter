using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MidService.Models
{
	public class Doctor
	{
		[Key]
		public int DoctorId { get; set; }
		public string FIO { get; set; }
		public string TNumber { get; set; }
		public string Status { get; set; }

		public int SpecialtyId { get; set; }
		public Specialty Specialty { get; set; }

		public List<Order> Orders { get; set; }

	}
}
