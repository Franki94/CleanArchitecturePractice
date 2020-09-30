using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>( entity => {
                entity.HasKey(e => e.Id)
                .HasName("pk_books");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.ISBN).HasColumnName("isbn");
                entity.Property(e => e.AuthorName).HasColumnName("author_name");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
