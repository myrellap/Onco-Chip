using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Onco_Chip.Models;

namespace Onco_Chip.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<App> Apps { get; set; }
        public DbSet<Cadastro> Cadastros { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
