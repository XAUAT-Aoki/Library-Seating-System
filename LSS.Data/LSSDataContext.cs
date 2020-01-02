using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LSS.Data
{
    public partial class LSSDataContext : DbContext
    {
        public LSSDataContext()
        {
        }

        public LSSDataContext(DbContextOptions<LSSDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administor> Administor { get; set; }
        public virtual DbSet<Library> Library { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Seat> Seat { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=121.36.49.183;port=3306;user=jm;password=Jm@123456;database=LSSData", x => x.ServerVersion("5.7.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administor>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PRIMARY");

                entity.ToTable("administor");

                entity.Property(e => e.Aid)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Aname)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Apassword)
                    .HasColumnType("varchar(96)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.HasKey(e => e.Lid)
                    .HasName("PRIMARY");

                entity.ToTable("library");

                entity.Property(e => e.Lid).HasColumnType("int(10)");

                entity.Property(e => e.Lefloor).HasColumnType("int(11)");

                entity.Property(e => e.Lerror)
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Llatitute)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Llongitude)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lname)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lsfloor).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PRIMARY");

                entity.ToTable("order");

                entity.HasIndex(e => e.Sid)
                    .HasName("Sid");

                entity.HasIndex(e => e.Tid)
                    .HasName("Tid");

                entity.Property(e => e.Oid)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Octime).HasColumnType("datetime");

                entity.Property(e => e.Oetime).HasColumnType("datetime");

                entity.Property(e => e.Ostate)
                    .HasColumnType("varchar(2)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ostime).HasColumnType("datetime");

                entity.Property(e => e.Sid)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tid)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Sid)
                    .HasConstraintName("Sid");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.Tid)
                    .HasConstraintName("Tid");
            });

            modelBuilder.Entity<Seat>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PRIMARY");

                entity.ToTable("seat");

                entity.HasIndex(e => e.Lid)
                    .HasName("Lid");

                entity.Property(e => e.Tid)
                    .HasColumnType("varchar(8)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lid)
                    .HasColumnType("int(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Tfloor)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Tstate)
                    .HasColumnType("varchar(48)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.HasOne(d => d.L)
                    .WithMany(p => p.Seat)
                    .HasForeignKey(d => d.Lid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Lid");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PRIMARY");

                entity.ToTable("student");

                entity.Property(e => e.Sid)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Semail)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slock)
                    .HasColumnType("varchar(11)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sname)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Spassword)
                    .HasColumnType("varchar(96)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ssex)
                    .HasColumnType("varchar(11)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("0代表男，1代表女")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Svalue).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
