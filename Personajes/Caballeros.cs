using System;

namespace Personajes
{
    public class Caballeros
    {
        public String Nombre { get; set; }
        public string Tecnica { get; set; }

        public Caballeros(String nombre, String tecnica)
        {
            Nombre = nombre;
            Tecnica = tecnica;
        }
    }
}
