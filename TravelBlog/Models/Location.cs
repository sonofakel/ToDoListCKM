using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
	[Table("Locations")]
	public class Location
	{
		[Key]
		public int Id { get; set; }
		public string Country { get; set; }
        public string City { get; set; }
	}
}
