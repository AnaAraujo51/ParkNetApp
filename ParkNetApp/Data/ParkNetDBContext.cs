using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ParkNetApp.Data.Entities;

namespace ParkNetApp.Data
{
    public class ParkNetDBContext : IdentityDbContext
    {
        public ParkNetDBContext(DbContextOptions<ParkNetDBContext> options)
            : base(options)
        {
        }

        public DbSet<Utilizador> Utilizadors { get; set; }
        public DbSet<Parque> Parques { get; set; }
        public DbSet<Estacionamento> Estacionamentos { get; set; }

        public DbSet<Avenca> Avencas { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Utilizador>()
                .Property(u => u.Saldo)
                .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Avenca>()
                .Property(a => a.Preco)
                .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Pagamento>(entity =>
            {
                entity.ToTable("Pagamentos");

                entity.HasKey(p => p.Id);

                entity.Property(p => p.Valor)
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(p => p.Utilizador)
                    .WithMany()
                    .HasForeignKey(p => p.UtilizadorId)
                    .OnDelete(DeleteBehavior.Restrict); // Evita problemas de cascata

                entity.HasOne(p => p.Avenca)
                    .WithMany()
                    .HasForeignKey(p => p.AvencaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}