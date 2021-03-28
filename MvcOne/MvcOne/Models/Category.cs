﻿using System;
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
		public int DisplayOrder{ get; set; }
	}
}
