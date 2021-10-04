using System;

namespace Drone.App.Dominio
{
    public class Pedido
    {
        public int Id {get; set;}
        public string Contenido {get; set;}
        public DateTime Fecha {get; set;}
        public string Satisfaccion {get; set;}
        public string Estrellas {get; set;}

        public Cliente ClienteF {get; set;}
        public Encargado EncargadoF {get; set;}
    }
}