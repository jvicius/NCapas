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

        public Amigo Clone()
        {
            Amigo amigo=new Amigo();
            amigo.idamigo = idamigo;
            amigo.nombre = nombre;
            amigo.fecnac = fecnac;
            amigo.direccion = direccion;
            amigo.telefono = telefono;

            return amigo;
        }
    }
}