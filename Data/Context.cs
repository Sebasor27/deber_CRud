using Microsoft.EntityFrameworkCore;
using Deber.Models;

namespace Context.Data
{
    public class DeberContext : DbContext
    {
        public DeberContext(DbContextOptions<DeberContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
