using firstStore.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace firstStore.UI.Data
{
    public class FirstStoreDataContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=newfirstStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Produto> Produtos { get; set; }

    }
}
