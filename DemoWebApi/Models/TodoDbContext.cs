using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebApi.Models
{
	public class TodoDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder options)
				=> options.UseSqlServer("Server=.;Database=TodoDB;Trusted_Connection=True");

		//public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
		//{
			
		//}

		public DbSet<TodoItem> ToDoItems { get; set; }
	}
}
