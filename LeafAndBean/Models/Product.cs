using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeafAndBean.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		[DisplayFormat(DataFormatString = "{0:C}")]
		public decimal Price { get; set; }
		public string ImagePath { get; set; }
	}
}
