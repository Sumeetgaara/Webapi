using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace coreapi.Models
{
    public partial class BloggingContext : DbContext
    {
        
	public BloggingContext(DbContextOptions<BloggingContext> options)
	: base(options)
		{ }
		public virtual DbSet<Blog> Blog { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsRequired();
            });
        }
    }
}
