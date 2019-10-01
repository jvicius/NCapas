using System;

namespace DomainLayer.Models
{
    public class Amigo
    {
        public Amigo() { }
        public Amigo(string n, string d, string t, DateTime f)
        {
            nombre = n;
            direccion = d;
            telefono = t;
            fecnac = f;
        }
        public int idamigo { set; get; }
        public string nombre { set; get; }
        public DateTime fecnac { set; get; }
        public string direccion { set; get; }
        public string telefono { set; get; }

        public Amigo Clone()
        {
            return new Amigo { idamigo = idamigo, nombre = nombre, direccion = direccion, telefono = telefono, fecnac = fecnac };
        }
    }
}