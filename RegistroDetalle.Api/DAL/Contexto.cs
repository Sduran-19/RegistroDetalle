using RegistroDetalle.Models;
using Microsoft.EntityFrameworkCore;

namespace RegistroDetalle.Api.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Prioridades>? Prioridades { get; set; }

        public DbSet<Clientes>? Clientes { get; set; }

        public DbSet<Tickets>? Tickets { get; set; }

        public DbSet<Sistemas>? Sistemas { get; set; }

        public DbSet<TicketsDetalle>? TicketsDetalle { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    }
}
