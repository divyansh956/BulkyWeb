﻿using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "KoKo1", DisplayOrder = 1 },
													new Category { Id = 2, Name = "KoKo2", DisplayOrder = 2 },
													new Category { Id = 3, Name = "KoKo3", DisplayOrder = 3 });
		}
	}
}
