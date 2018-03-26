using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Data.Entities;
using Test.Data.Enums;

namespace Test.Data
{
    public class NewContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("getdate()");



            modelBuilder.ApplyConfiguration<Post>(new PostTypeConfiguration());
        }


    }

    public class PostTypeConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.DateCreated).HasDefaultValueSql("GetDate()");
            builder.Property(p => p.Status).HasDefaultValue(Status.Reminder);
        }
    }
}
