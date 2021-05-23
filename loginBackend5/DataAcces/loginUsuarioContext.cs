using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace loginBackend5.DataAcces
{
    public partial class loginUsuarioContext : DbContext
    {
        public loginUsuarioContext()
        {
        }

        public loginUsuarioContext(DbContextOptions<loginUsuarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UsuarioLog> UsuarioLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAP-LUIS-REYNA;Database=loginUsuario;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<UsuarioLog>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("PK__usuarioL__EAE6D9DF23BFF042");

                entity.ToTable("usuarioLog");

                entity.Property(e => e.Iduser).HasColumnName("IDUser");

                entity.Property(e => e.EmailUser).HasColumnName("emailUser");

                entity.Property(e => e.NombreUser)
                    .HasMaxLength(10)
                    .HasColumnName("nombreUser");

                entity.Property(e => e.PasswordUser)
                    .IsUnicode(false)
                    .HasColumnName("passwordUser");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
