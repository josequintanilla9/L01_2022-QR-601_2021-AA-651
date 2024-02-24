using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace L01_2022_QR_601_2021_AA_651.Models
{
    public class restauranteContext : DbContext
    {
        public restauranteContext(DbContextOptions<restauranteContext> options) : base(options)
        {

        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Platos> Platos { get; set; }


    }
}
