using Microsoft.EntityFrameworkCore;

namespace APIPizzaria.Model
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
