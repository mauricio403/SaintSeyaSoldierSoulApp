using System;
using Personajes;
using Interfaces;

namespace Ataques
{
    public class Tecnica : ITecnica
    {
        public bool Atacar(Caballero personaje)
        {
            Console.WriteLine("El personaje {0}, ha realizado la tecnica {1}", personaje.Nombre, personaje.Tecnica);
            return true;
        }
    }
}
