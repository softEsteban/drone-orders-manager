using System;

namespace Drone.App.Dominio
{
    public class Estado
    {
        public int Id {get; set;}
        public DateTime Hora {get; set;}
        public string Ubicacion {get; set;}
        public float Temperatura {get; set;}
        public float TiempoFaltante {get; set;}

        public Pedido PedidoF {get; set;}
        
    }
}