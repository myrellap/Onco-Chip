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


        public DbSet<Onco_Chip.Models.App> App { get; set; } = default!;
        public DbSet<Onco_Chip.Models.Cadastro> Cadastro { get; set; } = default!;
        public DbSet<Onco_Chip.Models.Contato> Contato { get; set; } = default!;
        public DbSet<Onco_Chip.Models.Paciente> Paciente { get; set; } = default!;
    }
}
