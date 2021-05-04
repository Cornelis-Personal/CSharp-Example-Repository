using Cornelis.Examples.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Cornelis.Examples.DataAccess.DataContexts.SQL
{
    public class SQLContext : DbContext
    {
        #region Tables

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Plant> Plant { get; set; }
        public DbSet<AnimalPlantHistory> AnimalPlantHistory { get; set; }

        #endregion Tables

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public SQLContext(DbContextOptions options) : base(options)
        {
        }

        #endregion Constructors

        #region Table attributes and relationships

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* User */
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username);
                entity.Property(e => e.Role)
                      .IsRequired();
            });

            /* Role */
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd();
            });

            /* Animals */
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.HasKey(e => e.Rfid);
            });

            /* Plant */
            modelBuilder.Entity<Plant>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                      .ValueGeneratedOnAdd();
            });

            /* Animal Plant History */
            // As an example we will be using Data Annotations instead of fluent api. See AnimalPlantHistory.
        }

        #endregion Table attributes and relationships
    }
}