using Microsoft.EntityFrameworkCore;

namespace car_rentals_project.Models
{
    //Classe que reprenta o banco de dados dentro da aplicação
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        { }

        // public DbSet<Client> Client { get; set; }
        public DbSet<Automobile> Automobile { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Client> Client { get; set; }

    }
}