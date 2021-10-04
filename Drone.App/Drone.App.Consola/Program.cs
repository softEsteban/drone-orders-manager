using System.Net.NetworkInformation;
using System.Data;
using System.IO;
using System;
using Drone.App.Persistencia;
using Drone.App.Dominio;

namespace Drone.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddCliente();
        }

        static void AddCliente()
        {
            var cliente = new Cliente
            {

                Nombre = "Mariana",
                Apellido = "Londoño",
                Cedula = "12014535",
                Telefono = "321452145",
                Correo = "mariana@gmail.com",
                Direccion = "Avenida 45",
                PasswordClie = "EnyIkl78"

            };

            _repoCliente.AddCliente(cliente);


        }
    }
}
