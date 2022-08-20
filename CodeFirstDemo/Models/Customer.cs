using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public virtual ICollection<Orders> Orders { get; set; }
	}
	public class Orders
	{
		[Key]
		public int OrderId { get; set; }
		public DateTime OrderDate { get; set; }
		public string ShippingName { get; set; }
		public virtual Customer Customer { get; set; }

	}
}
