using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace hospital_mangment.Models
{
    public partial class HospitalDB_Context : DbContext
    {
        public HospitalDB_Context()
        {
        }

        public HospitalDB_Context(DbContextOptions<HospitalDB_Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<FrontDesk> FrontDesk { get; set; }
        public virtual DbSet<RegDoctor> RegDoctor { get; set; }
        public virtual DbSet<Register> Register { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-AD5D06OP\\MSSQLSERVER1;Initial Catalog=Person_Database;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.ToTable("appointments");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasColumnName("department")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doctor)
                    .IsRequired()
                    .HasColumnName("doctor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Room)
                    .IsRequired()
                    .HasColumnName("room")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasColumnName("time")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FrontDesk>(entity =>
            {
                entity.ToTable("front desk");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasMaxLength(250);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasColumnName("department")
                    .HasMaxLength(250);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("eMail")
                    .HasMaxLength(250);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(250);

                entity.Property(e => e.VerifyPassword)
                    .IsRequired()
                    .HasColumnName("verifyPassword")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<RegDoctor>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("eMail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specialization)
                    .HasColumnName("specialization")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerifyPassword)
                    .IsRequired()
                    .HasColumnName("verifyPassword")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("register");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(250);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasMaxLength(250);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("eMail")
                    .HasMaxLength(250);

                entity.Property(e => e.EmergencyNumber).HasColumnName("emergencyNumber");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(250);

                entity.Property(e => e.History)
                    .IsRequired()
                    .HasColumnName("history")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(250);

                entity.Property(e => e.Prescription)
                    .HasColumnName("prescription")
                    .HasMaxLength(50);

                entity.Property(e => e.Sickness)
                    .IsRequired()
                    .HasColumnName("sickness")
                    .HasMaxLength(250);

                entity.Property(e => e.VerifyPassword)
                    .IsRequired()
                    .HasColumnName("verifyPassword")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.ToTable("rooms");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasColumnName("department")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Doctor)
                    .IsRequired()
                    .HasColumnName("doctor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Room).HasColumnName("room");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
