using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EfCoreDemo.API.Entities
{
    public partial class IKUNContext : DbContext
    {
        public IKUNContext()
        {
        }

        public IKUNContext(DbContextOptions<IKUNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> People { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=127.0.0.1;database=IKUN;uid=sa;pwd=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("person");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.PAge).HasColumnName("p_age");

                entity.Property(e => e.PGender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("p_gender")
                    .IsFixedLength();

                entity.Property(e => e.PName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("p_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
