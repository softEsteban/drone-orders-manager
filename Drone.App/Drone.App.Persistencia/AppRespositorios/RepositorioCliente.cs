using System.Collections.Generic;
using System.Linq;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {

        ///---------------------------------------
        ///PSEUDO DATABASE

        List<Cliente> clientes;

        public RepositorioCliente()
        {
            clientes = new List<Cliente>()
            {
                new Cliente {Id= 1, Nombre= "Andres", Apellido= "Parra", Cedula= "75841236", Telefono= "312453614", Correo= "andres@gmail.com", Direccion= "Calle 5", PasswordClie= "shgdlsbd541" },
                new Cliente {Id= 2, Nombre= "Anamaria", Apellido="Carvajal", Cedula= "24156324", Telefono= "314785123", Correo= "anamaria@gmail.com", Direccion= "Avenida 12", PasswordClie= "KJABDJHSW55" }
            };
        }

        public IEnumerable<Cliente> GetAll()
        {
            return clientes;
        }

        ///---------------------------------------

        /// <summary>
        /// </summary>

        private readonly AppContext _appContext;

        /// <summary>
        /// </summary>
        /// <param name="appContext"></param>

        // public RepositorioCliente(AppContext appContext)
        // {
        //     _appContext = appContext;
        // }

        
        // public IEnumerable<Cliente> GetAll()
        // {
        //     return _appContext.Clientes;

        // }


        // Cliente IRepositorioCliente.AddCliente(Cliente cliente)
        // {
        //     var clienteInsertado = _appContext.Clientes.Add(cliente);
        //     _appContext.SaveChanges();
        //     return clienteInsertado.Entity;
        // }

        

        

    }
}