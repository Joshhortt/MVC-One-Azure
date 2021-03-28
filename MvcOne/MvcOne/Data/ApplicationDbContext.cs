using Microsoft.EntityFrameworkCore;
using MvcOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcOne.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			
	    }
		public DbSet<Category> Category { get; set; }  // The entity prop we want to create to the DB is Category with the same name
		public DbSet<ApplicationType> ApplicationType { get; set; }  // The entity prop we want to create to the DB is ApplicationType with the same name

	}
}
