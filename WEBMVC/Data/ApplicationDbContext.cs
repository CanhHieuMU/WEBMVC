using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WEBMVC.Models;

namespace WEBMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
            
        }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<CategoryRole> CategoryRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User and Account relationship one to one
            modelBuilder.Entity<User>()
            .HasOne(e => e.Account)
            .WithOne(e => e.User)
            .HasForeignKey<Account>(e => e.UserId)
            .IsRequired();

            // Book and CategoryBook relationship many to many
            base.OnModelCreating(modelBuilder);
        }
        
    }

}
