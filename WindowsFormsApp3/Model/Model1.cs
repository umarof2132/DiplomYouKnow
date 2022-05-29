using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp3.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Auth> Auth { get; set; }
      
        public virtual DbSet<GeneralTable> GeneralTable { get; set; }
        public virtual DbSet<Postavshiki> Postavshiki { get; set; }
        public virtual DbSet<Sklad> Sklad { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auth>()
                .HasOptional(e => e.GeneralTable)
                .WithRequired(e => e.Auth);

       

            modelBuilder.Entity<Postavshiki>()
                .HasMany(e => e.GeneralTable)
                .WithRequired(e => e.Postavshiki)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sklad>()
                .HasMany(e => e.GeneralTable)
                .WithRequired(e => e.Sklad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zakaz>()
                .Property(e => e.Nakladnaya)
                .IsFixedLength();

            modelBuilder.Entity<Zakaz>()
                .Property(e => e.Price)
                .IsFixedLength();

            modelBuilder.Entity<Zakaz>()
                .HasMany(e => e.GeneralTable)
                .WithRequired(e => e.Zakaz)
                .WillCascadeOnDelete(false);
        }
    }
}
