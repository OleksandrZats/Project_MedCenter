using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MidService.Models
{
	public class Specialty
	{
		[Key]
		public int SpecialtyId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public List<Doctor> Doctors { get; set; }

	}
}
