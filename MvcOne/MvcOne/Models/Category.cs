using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcOne.Models
{
	public class Category
	{
		[Key]  // Add data annotations for database primary key
		public int Id { get; set; }
		public string Name { get; set; }

		[DisplayName("Display Order")]  // Data annotations added
		[Required]
		[Range(1,int.MaxValue,ErrorMessage ="Display the Order for Category that must be greater than zero.")]
		public int DisplayOrder{ get; set; }
	}
}
