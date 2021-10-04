using Microsoft.EntityFrameworkCore;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Encargado> Encargados {get; set;}
        public DbSet<Pedido> Pedidos {get; set;}
        public DbSet<Estado> Estados {get; set;}
        public DbSet<Empresa> Empresas {get; set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            if(!optionsBuilder.IsConfigured){

                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DroneDataBase");
            }

        }


    }
}