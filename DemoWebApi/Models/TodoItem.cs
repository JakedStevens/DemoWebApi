using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.Models
{
	public class TodoItem
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsComplete { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime CreatedOn {  get; set; }
	}
}
