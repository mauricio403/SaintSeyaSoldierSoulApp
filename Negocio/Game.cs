using System;
using Personajes;
using Interfaces;
namespace Negocio
{
    public class Game
    {
        ITecnica tecnica;

        public Game(ITecnica tecnica)
        {
            this.tecnica = tecnica;
        }

        public void HacerLaTecnica(Caballero personaje)
        {
            tecnica.Atacar(personaje);
            
        }
    }
}
