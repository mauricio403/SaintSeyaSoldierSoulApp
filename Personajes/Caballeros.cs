using System;

namespace Personajes
{
    public class Caballero
    {
        public String Nombre { get; set; }
        public string Tecnica { get; set; }

        public Caballero(String nombre, String tecnica)
        {
            Nombre = nombre;
            Tecnica = tecnica;
        }
    }
}
