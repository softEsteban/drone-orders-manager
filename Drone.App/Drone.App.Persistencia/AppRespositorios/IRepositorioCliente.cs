using System.Collections;
using System;
using System.Collections.Generic;
using Drone.App.Dominio;

namespace Drone.App.Persistencia
{
    public interface IRepositorioCliente
    {
        ///Cliente AddCliente(Cliente cliente);

        IEnumerable<Cliente> GetAll();

    }

}