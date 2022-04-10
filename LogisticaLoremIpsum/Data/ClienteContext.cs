using LogisticaLoremIpsum.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticaLoremIpsum.Data
{
    public class ClienteContext: DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Endereco>().HasOne(endereco => endereco.cliente).WithMany(cliente => cliente.Endereco).HasForeignKey(endereco => endereco.id_cliente);
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Endereco> Endereco { get; set; }
    }
}
