using System;

namespace DomainLayer.Models
{
    public class Amigo
    {
        public int idamigo { set; get; }
        public string nombre { set; get; }
        public DateTime fecnac { set; get; }
        public string direccion { set; get; }
        public string telefono { set; get; }

        public Amigo Clonar()
        {
            return new Amigo { nombre = nombre, fecnac = fecnac, direccion = direccion, telefono = telefono };
        }
    }
}