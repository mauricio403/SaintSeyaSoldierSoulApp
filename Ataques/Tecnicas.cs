using System;
using Personajes;
using Interfaces;

namespace Ataques
{
    public class Tecnicas: ITecnica 
    {
        

        public bool Atacar(Caballeros personaje)
        {
            Console.WriteLine("El personaje {0}, ha realizado la tenica {1}", personaje.Nombre, personaje.Tecnica);
            return true;
        }
      
        
    }
}
