using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models
{
	public class ShoppingDbContext:DbContext
	{
		public ShoppingDbContext(DbContextOptions options) : base(options)
		{

		}
		//here we have to define what models we have created
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Orders> Orders { get; set; }
	}
}
