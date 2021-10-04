using System.Globalization;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Drone.App.Dominio;
using Drone.App.Persistencia;


namespace Drone.App.Frontend.Pages
{
    public class conexionBDModel : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;

        public IEnumerable<Cliente> Clientes {get; set;}

        public conexionBDModel (IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente=repositorioCliente;
        }
        
        public void OnGet()
        {
            Clientes = repositorioCliente.GetAll();
        } 

    }
}
