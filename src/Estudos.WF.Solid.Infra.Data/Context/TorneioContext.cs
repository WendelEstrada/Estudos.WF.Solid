using System.Data.Entity;
using Estudos.WF.Solid.Core.Entities;

namespace Estudos.WF.Solid.Infra.Data
{
    public partial class TorneioContext : DbContext
    {
        public TorneioContext()
            : base("name=TorneioContext")
        {
        }

        public virtual DbSet<ArtesMarciais> ArtesMarciais { get; set; }
        public virtual DbSet<Atleta> Atleta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atleta>()
                .ToTable("Atleta");

            modelBuilder.Entity<ArtesMarciais>()
                .ToTable("ArtesMarciais");

            modelBuilder.Entity<ArtesMarciais>()
                .Property(e => e.Nome)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false);

            modelBuilder.Entity<ArtesMarciais>()
                .HasMany(e => e.Atleta)
                .WithMany(e => e.ArtesMarciais)
                .Map(m => m.ToTable("Atleta_x_ArtesMarciais").MapLeftKey("IdArtesMarciais").MapRightKey("IdAtleta"));

            modelBuilder.Entity<Atleta>()
                .Property(e => e.Nome)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false);
        }
    }
}
